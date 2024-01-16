using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using System.Collections.Generic;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

namespace devector
{
	public partial class FormDebugger : Form
	{
		const UInt16 DISASM_LOOKUP_ADDR_LINE = 6; // the line idx where disired addr should be in the list
		public UInt64 cc_last;
		PictureBox picture_display;

		ContextMenuStrip disasm_context_menu;
		//********************************************************************
		//
		//	color theme
		//
		//********************************************************************
		const int DISASM_CELL_PADDING = 2;
		const int DISASM_CELL_TEXT_OFFSET_Y = 0;


		Brush disasm_brush_cell_text = Brushes.Black;
		SolidBrush disasm_brush_selection = new SolidBrush(Color.FromArgb(80, 128, 200, 255));

		const int cell_break_w = 20;
		const int cell_addr_w = 54;
		const int cell_code_w = 200;
		const int cell_stats_w = 100;

		public class DisAsmListItem
		{
			public string addr { get; set; }
			public List<DisasmLine> code_line { get; set; }
			public string stats { get; set; }
			public string labels { get; set; }
		}

		public enum DisasmLineType
		{
			LABEL, OPCODE, COMMENT, SCALAR, OUTPUT, OPERAND_D, OPERAND_R
		}
		readonly private int[] disasm_text_offsets =
		{
			0, 20, 0, 0, 30, 0, 0
		};

		private SolidBrush[] disasm_text_colors = {
			new SolidBrush(Color.FromArgb(255, 100, 80, 0)),
			new SolidBrush(Color.Black),
			new SolidBrush(Color.Green),
			new SolidBrush(Color.Salmon),
			new SolidBrush(Color.BlueViolet),
			new SolidBrush(Color.Blue),
			new SolidBrush(Color.CadetBlue),
		};

		Font disasm_mono_font = new Font("MS Gothic", 9.75f);
		Font disasm_mono_font_small = new Font("MS Sans Serif", 8.0f);
		//Font disasm_font = new Font("MS Sans Serif", 9.75f, FontStyle.Bold);
		Font disasm_font = new Font("Consolas", 11f);


		int listBox_disasm_item_h = 20;

		//********************************************************************
		//
		//	resources
		//
		//********************************************************************

		private System.Drawing.Image img_arrow_pc;
		private System.Drawing.Image breakpoint_img;

		public FormDebugger(PictureBox _picture_display)
		{
			InitializeComponent();

			picture_display = _picture_display;

			init_img_arrow_pc();

			listBox_disasm_init();
			update_form();

			watch_list_init();
			breakpoints_list_init();

			watch_list_add();
			breakpoints_list_add();

			init_listing_context_menu();

		}

		void listBox_disasm_init()
		{
			listBox_disasm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			listBox_disasm.ItemHeight = listBox_disasm_item_h;
			listBox_disasm.DrawItem += new DrawItemEventHandler(listBox_disasm_DrawItem);
			listBox_disasm.Resize += new EventHandler(listBox_disasm_Resize);
		}

		// init the indicator of the PC reg
		private void init_img_arrow_pc()
		{
			img_arrow_pc = System.Drawing.Image.FromFile("C:\\Work\\Programming\\c#\\devector\\res\\images\\icons8-chevron-right-51.png");
			breakpoint_img = System.Drawing.Image.FromFile("C:\\Work\\Programming\\c#\\devector\\res\\images\\icons8-stop-sign-94.png");
		}

		void watch_list_init()
		{
			watch_datagrid.Rows.Clear();
			watch_datagrid.RowHeadersVisible = false;
		}
		void watch_list_add()
		{
			DataGridViewRow row = new DataGridViewRow();

			// Add cells with values for each column
			DataGridViewCell cell1 = new DataGridViewTextBoxCell();
			cell1.Value = "Column 1";
			row.Cells.Add(cell1);

			DataGridViewCell cell2 = new DataGridViewTextBoxCell();
			cell2.Value = "Column 2";
			row.Cells.Add(cell2);

			// Add the row to the DataGrid
			watch_datagrid.Rows.Add(row);
		}

		void breakpoints_list_init()
		{
			bp_datagrid.Rows.Clear();
			bp_datagrid.RowHeadersVisible = false;
		}

		private void listBox_disasm_Resize(object sender, EventArgs e)
		{
			// Force a redraw of all items
			listBox_disasm.Invalidate();
		}

		private void listBox_disasm_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index < 0) return; // return if no items

			var item = listBox_disasm.Items[e.Index];
			bool no_back = false;
			if (item is DisAsmListItem)
			{
				DisAsmListItem entity = (DisAsmListItem)item;
				if (entity.code_line.Count > 0 & (entity.code_line[0].type == DisasmLineType.COMMENT | entity.code_line[0].type == DisasmLineType.LABEL))
				{
					no_back = true;
				}
			}

			int cell_w = e.Bounds.Width;
			int cell_h = e.Bounds.Height;
			int cell_stats_pos = e.Bounds.Left + cell_break_w + cell_addr_w + cell_code_w;
			int cell_labels_w = cell_w - cell_break_w - cell_addr_w - cell_code_w - cell_stats_w;
			int cell_labels_pos = cell_stats_pos + cell_stats_w;

			// draw the background
			// back white back
			e.Graphics.FillRectangle(SystemBrushes.Info, e.Bounds.Left, e.Bounds.Top, cell_w, cell_h);
			// breakpoints
			int cell_back_pos_x = e.Bounds.Left;
			e.Graphics.FillRectangle(SystemBrushes.ActiveBorder, cell_back_pos_x, e.Bounds.Top, cell_break_w - DISASM_CELL_PADDING, cell_h);
			// addr
			cell_back_pos_x += cell_break_w;
			e.Graphics.FillRectangle(SystemBrushes.ControlLight, cell_back_pos_x, e.Bounds.Top, cell_addr_w - DISASM_CELL_PADDING, cell_h);

			if (no_back == false)
			{
				// code
				cell_back_pos_x += cell_addr_w;
				e.Graphics.FillRectangle(SystemBrushes.Window, cell_back_pos_x, e.Bounds.Top, cell_code_w - DISASM_CELL_PADDING, cell_h);
				// stats
				cell_back_pos_x += cell_code_w;
				e.Graphics.FillRectangle(SystemBrushes.ControlLight, cell_back_pos_x, e.Bounds.Top, cell_stats_w - DISASM_CELL_PADDING, cell_h);
				// labels
				cell_back_pos_x += cell_stats_w;
				e.Graphics.FillRectangle(SystemBrushes.ControlLight, cell_back_pos_x, e.Bounds.Top, cell_labels_w - DISASM_CELL_PADDING, cell_h);
			}

			// draw a selection highlight
			bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
			if (isSelected) e.Graphics.FillRectangle(disasm_brush_selection, e.Bounds.Left, e.Bounds.Top, cell_w, cell_h);

			// draw an text
			int text_pos_x;
			int text_pos_y;

			if (item is DisAsmListItem)
			{
				DisAsmListItem entity = (DisAsmListItem)item;

				// draw addr
				text_pos_x = e.Bounds.Left + cell_break_w;
				var text_pos = get_text_cell_pos(CellTextAligning.LEFT_BOTOM, e, entity.addr, disasm_mono_font, text_pos_x, cell_stats_w, listBox_disasm_item_h);
				e.Graphics.DrawString(entity.addr, disasm_mono_font, disasm_brush_cell_text, new Rectangle(text_pos.x, text_pos.y, cell_addr_w, cell_h));

				// draw code
				text_pos_x += cell_addr_w;
				SizeF text_boundary = new SizeF();
				foreach (DisasmLine part in entity.code_line)
				{
					text_pos_x += (int)text_boundary.Width + disasm_text_offsets[(int)(part.type)];
					text_boundary = e.Graphics.MeasureString(part.text, disasm_font);

					var brush_disasm_line = disasm_text_colors[(int)(part.type)];
					e.Graphics.DrawString(part.text, disasm_font, brush_disasm_line, new Rectangle(text_pos_x, (int)(e.Bounds.Top + listBox_disasm_item_h - text_boundary.Height + 3), cell_w, cell_h));
				}

				// draw stats
				text_pos = get_text_cell_pos(CellTextAligning.CENTER_BOTTOM, e, entity.stats, disasm_mono_font_small, cell_stats_pos, cell_stats_w, listBox_disasm_item_h);
				e.Graphics.DrawString(entity.stats, disasm_mono_font_small, disasm_brush_cell_text, new Rectangle(text_pos.x, text_pos.y, cell_stats_w, cell_h));
				// draw argument labels
				// cut the label stringto fit into the cell
				text_pos = get_text_cell_pos(CellTextAligning.LEFT_BOTOM, e, entity.labels, disasm_mono_font, cell_labels_pos, cell_labels_w, listBox_disasm_item_h);
				e.Graphics.DrawString(entity.labels, disasm_mono_font, disasm_brush_cell_text, new Rectangle(text_pos.x, text_pos.y, 1000, cell_h));
			}
		}
		enum CellTextAligning
		{
			LEFT_BOTOM,
			CENTER_BOTTOM
		}
		struct PosI
		{
			public int x, y; 
		}
		private PosI get_text_cell_pos(CellTextAligning aligning, DrawItemEventArgs e, string text, Font font, int cell_pos_x, int cell_w, int cell_h)
		{
			var text_boundary = e.Graphics.MeasureString(text, font);
			PosI pos = new PosI();

			if (aligning == CellTextAligning.LEFT_BOTOM)
			{
				pos.x = cell_pos_x;
				pos.y = (int)(e.Bounds.Top + cell_h - text_boundary.Height + DISASM_CELL_TEXT_OFFSET_Y);
			}
			else
			{
				pos.x = (int)(cell_pos_x + cell_w/2 - text_boundary.Width / 2);
				pos.y = (int)(e.Bounds.Top + cell_h - text_boundary.Height + DISASM_CELL_TEXT_OFFSET_Y);
			}
			return pos;
		}

		public struct DisasmLine
		{
			public DisasmLineType type;
			public string text { get; set; }
		}


		void breakpoints_list_add()
		{
			DataGridViewRow row = new DataGridViewRow();

			// Add cells with values for each column
			DataGridViewCell cell = new DataGridViewCheckBoxCell();
			cell.Value = true;
			row.Cells.Add(cell);

			cell = new DataGridViewTextBoxCell();
			cell.Value = "CPU:-W-";
			row.Cells.Add(cell);

			cell = new DataGridViewTextBoxCell();
			cell.Value = "0x0000 - 0x00FF";
			row.Cells.Add(cell);

			cell = new DataGridViewTextBoxCell();
			cell.Value = "scanline > 240";
			row.Cells.Add(cell);

			// Add the row to the DataGrid
			bp_datagrid.Rows.Add(row);
		}

		void update_form(int _addr = -1, UInt16 _before_addr_lines = DISASM_LOOKUP_ADDR_LINE)
		{
			var selected_line = listBox_disasm.SelectedIndex;

			// disasm listing update
			listBox_disasm.Items.Clear();

			// getting disasm data
			UInt16 disasm_addr = _addr >= 0 ? (UInt16)(_addr) : Hardware.cpu.pc;
			var visible_lines = listBox_disasm.ClientSize.Height / listBox_disasm.ItemHeight;
			var disasm = Hardware.debugger.get_disasm(disasm_addr, visible_lines, _before_addr_lines);

			var pc_icon_pos_y = -1;
			int rowIndex = 0;
			// fill up the disasm list form
			foreach (var line in disasm)
			{
				var split_list = line.Split('\t');
				var addr_s = split_list[0];
				var labels = "";
				if (split_list.Length > 3)
					labels = split_list[3];

				listBox_disasm.Items.Add(new DisAsmListItem { addr = addr_s, code_line = get_disasm_line(split_list[1]), stats = split_list[2], labels = labels });

				int addr = Convert.ToInt32(addr_s.Substring(2), 16);

				if (addr == Hardware.cpu.pc)
				{
					Rectangle rowBounds = listBox_disasm.GetItemRectangle(rowIndex);
					pc_icon_pos_y = rowBounds.Location.Y + rowBounds.Size.Height / 4 * 3;
				}

				rowIndex += 1;
			}

			// regs update
			textbox_af.Text = $"{Hardware.cpu.i8080_get_af():X4}";
			textbox_bc.Text = $"{Hardware.cpu.i8080_get_bc():X4}";
			textbox_de.Text = $"{Hardware.cpu.i8080_get_de():X4}";
			textbox_hl.Text = $"{Hardware.cpu.i8080_get_hl():X4}";
			textbox_sp.Text = $"{Hardware.cpu.sp:X4}";
			textbox_pc.Text = $"{Hardware.cpu.pc:X4}";

			// flags update
			var cf = Hardware.cpu.flag_c ? 1 : 0;
			var zf = Hardware.cpu.flag_z ? 1 : 0;
			var pf = Hardware.cpu.flag_p ? 1 : 0;
			var sf = Hardware.cpu.flag_s ? 1 : 0;
			var acf = Hardware.cpu.flag_ac ? 1 : 0;
			var inte = Hardware.cpu.INTE ? 1 : 0;
			var iff = Hardware.cpu.IFF ? 1 : 0;
			var hlta = Hardware.cpu.HLTA ? 1 : 0;

			textbox_cf.Text = $"{cf}";
			textbox_zf.Text = $"{zf}";
			textbox_pf.Text = $"{pf}";
			textbox_sf.Text = $"{sf}";
			textbox_acf.Text = $"{acf}";
			textbox_inte.Text = $"{inte}";
			textbox_iff.Text = $"{iff}";
			textbox_hlta.Text = $"{hlta}";

			// cpu cycles
			textbox_cc.Text = $"{Hardware.cpu.cc}";
			textbox_last_run.Text = $"{Hardware.cpu.cc - cc_last}";

			// set the position of the cpu pc green arrow icon 
			/*
			img_arrow_pc.Visible = false;
			if (pc_icon_pos_y >= 0)
			{
				img_arrow_pc.Visible = true;
				var pc_icon_pos = img_arrow_pc.Location;
				pc_icon_pos.Y = pc_icon_pos_y - img_arrow_pc.Height / 2;
				img_arrow_pc.Location = pc_icon_pos;
			}
			*/

			// mapping
			var mapping_mode_ram = Hardware.memory.mapping_mode_ram;
			string mapping_ram_mode_s = "Off";

			if ((mapping_mode_ram & (0x20 + 0x40 + 0x80)) > 0)
			{
				string mapping_ram_mode_a = (mapping_mode_ram & 0x20) > 0 ? "AC" : "--";
				string mapping_ram_mode_8 = (mapping_mode_ram & 0x40) > 0 ? "8" : "-";
				string mapping_ram_mode_e = (mapping_mode_ram & 0x80) > 0 ? "E" : "-";
				mapping_ram_mode_s = mapping_ram_mode_8 + mapping_ram_mode_a + mapping_ram_mode_e;
			}
			textbox_mapping_ram_mode.Text = mapping_ram_mode_s;
			textbox_mapping_ram_page.Text = Hardware.memory.mapping_mode_ram.ToString();

			textbox_mapping_stack_mode.Text = Hardware.memory.mapping_mode_stack ? "On" : "Off";
			textbox_mapping_stack_page.Text = Hardware.memory.mapping_page_stack.ToString();

			// display
			textbox_crt_x.Text = $"{Hardware.display.raster_pixel}";
			textbox_crt_y.Text = $"{Hardware.display.raster_line}";

			// stack data
			textbox_sp_n6.Text = $"{Hardware.memory.get_word((uint)(Hardware.cpu.sp - 8), Memory.AddrSpace.STACK):X4}";
			textbox_sp_n4.Text = $"{Hardware.memory.get_word((uint)(Hardware.cpu.sp - 6), Memory.AddrSpace.STACK):X4}";
			textbox_sp_n2.Text = $"{Hardware.memory.get_word((uint)(Hardware.cpu.sp - 4), Memory.AddrSpace.STACK):X4}";
			textbox_sp_0.Text = $"{Hardware.memory.get_word((uint)(Hardware.cpu.sp - 2), Memory.AddrSpace.STACK):X4}";
			textbox_sp_p2.Text = $"{Hardware.memory.get_word((uint)(Hardware.cpu.sp), Memory.AddrSpace.STACK):X4}";
			textbox_sp_p4.Text = $"{Hardware.memory.get_word((uint)(Hardware.cpu.sp + 2), Memory.AddrSpace.STACK):X4}";
			textbox_sp_p6.Text = $"{Hardware.memory.get_word((uint)(Hardware.cpu.sp + 4), Memory.AddrSpace.STACK):X4}";

			listBox_disasm.SelectedIndex = selected_line;

			picture_display.Invalidate();
		}

		private List<DisasmLine> get_disasm_line(string code_s)
		{
			var output = new List<DisasmLine>();
			var split_list = code_s.Split(' ');

			string operand_r = "";
			int is_operand_r = 0;

			foreach (string item in split_list)
			{
				if (is_operand_r == 1 && !(item.Length == 1 || (item.Length > 1 && item[1] == ',')))
				{
					is_operand_r = 2;
					output.Add(new DisasmLine { type = DisasmLineType.OPERAND_R, text = operand_r });
				}
				if (item[0] == '_')
				{
					output.Add(new DisasmLine { type = DisasmLineType.OPCODE, text = item.Substring(1)});
				}
				else if (item[0] >= (int)'0' && item[0] <= (int)'9')
				{
					output.Add(new DisasmLine { type = DisasmLineType.OPERAND_D, text = item });
				}
				else if (item.Length == 1 || (item.Length > 1 && item[1] == ',') || (item.Length > 2 && item[2] == ','))
				{
					is_operand_r = 1;
					operand_r += item;
				}
            }
            // flash if the operand_r was the last one
            if (is_operand_r == 1)
            {
                output.Add(new DisasmLine { type = DisasmLineType.OPERAND_R, text = operand_r });
            }
            return output;
		}

		public static bool IsHexNumber(string input)
		{
			// Optional: Allow optional leading "0x" or "0X" prefix
			if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase) || input.StartsWith("0X", StringComparison.OrdinalIgnoreCase))
			{
				input = input.Substring(2); // Remove the prefix
			}

			// Ensure it contains only valid hex digits (0-9, A-F, a-f)
			return input.All(c => char.IsDigit(c) || ((c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')));
		}

		private void search_box_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				string text = search_box.Text;

				if (IsHexNumber(text))
				{
					update_form((UInt16)(Convert.ToInt32(text, 16)));
				}
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			cc_last = Hardware.cpu.cc;

			Hardware.execute_instruction();
            update_form();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			cc_last = Hardware.cpu.cc;

			for (int i = 0; i < 256; i++)
			{
				Hardware.execute_instruction();
			}
			update_form();
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			cc_last = Hardware.cpu.cc;

			Stopwatch stopwatch = Stopwatch.StartNew();

			//for(int i = 0; i<1000; i++)
				Hardware.execute_frame();

			stopwatch.Stop();
			TimeSpan elapsedTime = stopwatch.Elapsed;
			label5.Text = $"Elapsed time: {elapsedTime}";

			update_form();
		}


		private void init_listing_context_menu()
		{
			ToolStripMenuItem item1 = new ToolStripMenuItem("Copy");
			ToolStripMenuItem item2 = new ToolStripMenuItem("Show the current break");
			ToolStripMenuItem item3 = new ToolStripMenuItem("Run to the selected line");
			ToolStripMenuItem item4 = new ToolStripMenuItem("Add/Remove a breakpoint");
			ToolStripMenuItem item5 = new ToolStripMenuItem("Remove all breakpoints");
			ToolStripSeparator separator = new ToolStripSeparator();

			disasm_context_menu = new ContextMenuStrip();
			disasm_context_menu.Items.AddRange(new ToolStripItem[] { item1, separator, item2, item3, separator, item4, item5, });

			listBox_disasm.ContextMenuStrip = disasm_context_menu;
			item1.Click += disasm_context_copy;
			item2.Click += disasm_context_show_current_break;
			item3.Click += disasm_context_to_selected_line;
			item4.Click += disasm_context_add_remove_break;
			item5.Click += disasm_context_remove_all_breaks;
		}

		private void disasm_context_copy(object sender, EventArgs e)
		{
			try
			{
				var selected_idx = listBox_disasm.SelectedIndex;
				var item = listBox_disasm.Items[selected_idx] as DisAsmListItem;
				string text = item.addr + " ";
				foreach (DisasmLine part in item.code_line)
				{
					text += part.text + " ";
				}

				Clipboard.SetText(text);
			}
			catch (SecurityException ex)
			{
				MessageBox.Show("Clipboard access is restricted.");
			}
		}
		private void disasm_context_show_current_break(object sender, EventArgs e)
		{
			// Code for Item 1 click
		}
		private void disasm_context_to_selected_line(object sender, EventArgs e)
		{
			// get the addr of the selected line
			var addr_idx = listBox_disasm.SelectedIndex;
			var addr_s = (listBox_disasm.Items[addr_idx] as DisAsmListItem).addr;

			UInt16 addr = Convert.ToUInt16(addr_s, 16);
			
			// TODO: update
			//Hardware.debugger.test_breakpoint = addr;

		}
		private void disasm_context_add_remove_break(object sender, EventArgs e)
		{
			// Code for Item 1 click
		}
		private void disasm_context_remove_all_breaks(object sender, EventArgs e)
		{
			MessageBox.Show("Action performed!");
		}

		private void disasm_list_mouse_down(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int index = (sender as ListBox).IndexFromPoint(e.Location);
				if (index != ListBox.NoMatches)
				{
					listBox_disasm.SelectedIndex = index;
				}
			}
		}

		// TODO: this is a text on how to draw icons. remove it after using
		private void main_panel_Panel2_Paint(object sender, PaintEventArgs e)
		{
			// Get the Graphics object
			Graphics g = e.Graphics;

			// Set the transparency level (0 to 1, where 1 is fully opaque)
			float transparency = 1.0f;

			// Create image attributes and set the opacity
			ImageAttributes attributes = new ImageAttributes();
			ColorMatrix matrix = new ColorMatrix { Matrix33 = transparency };
			attributes.SetColorMatrix(matrix);

			// Draw the first image (fully opaque)
			g.DrawImage(breakpoint_img, new Rectangle(500, 20, breakpoint_img.Width / 2, breakpoint_img.Height / 2));

			// Draw the second image (semi-transparent)
			g.DrawImage(img_arrow_pc, new Rectangle(500, 0, img_arrow_pc.Width, img_arrow_pc.Height), 0, 0, img_arrow_pc.Width, img_arrow_pc.Height, GraphicsUnit.Pixel, attributes);

		}

		private void listBox_disasm_KeyDown(object sender, KeyEventArgs e)
		{
			if (listBox_disasm.Focused && (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down))
			{
                var visible_lines = listBox_disasm.ClientSize.Height / listBox_disasm.ItemHeight;
				var selected_idx = listBox_disasm.SelectedIndex;

                if (e.KeyCode == Keys.Up && selected_idx == 0)
				{
					var addr_s = (listBox_disasm.Items[0] as DisAsmListItem).addr;
                    update_form((UInt16)(Convert.ToInt32(addr_s, 16)), 1);
                }
				else if (e.KeyCode == Keys.Down && selected_idx == visible_lines-1)
				{
                    var addr_s = (listBox_disasm.Items[1] as DisAsmListItem).addr;
                    update_form((UInt16)(Convert.ToInt32(addr_s, 16)), 0);
                }
			}
		}
	}
}
