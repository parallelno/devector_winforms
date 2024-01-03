using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace devector
{
	public partial class form_debugger : Form
	{
		readonly UInt16 BEFORE_ADDR_LINES = 6;

		public form_debugger()
		{
			InitializeComponent();

            update_form();
			watch_list_init();
			breakpoints_list_init();

			watch_list_add();
			breakpoints_list_add();
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

		void update_form(int _addr = -1)
		{
			var disasm_addr = Hardware.cpu.pc;

            if (_addr >= 0)
			{
				disasm_addr = (UInt16)(_addr);
			}

			// disasm listing update

            addr_list.Items.Clear();
            disasm_list.Items.Clear();
            execution_stats_list.Items.Clear();
            arg_labels_list.Items.Clear();

            var visible_lines = disasm_list.ClientSize.Height / disasm_list.ItemHeight;
            var disasm = Hardware.debugger.get_disasm(disasm_addr, visible_lines, BEFORE_ADDR_LINES);
			var pc_icon_pos_y = -1;

			int rowIndex = 0;
			foreach (var line in disasm)
			{
				var split_list = line.Split('\t');

				var addr_s = split_list[0];
                addr_list.Items.Add(addr_s);
				disasm_list.Items.Add(split_list[1]);
				execution_stats_list.Items.Add(split_list[2]);
				if (split_list.Length > 3)
					arg_labels_list.Items.Add(split_list[3]);

                int addr = Convert.ToInt32(addr_s.Substring(2), 16);
				if (addr == Hardware.cpu.pc)
				{
                    Rectangle rowBounds = addr_list.GetItemRectangle(rowIndex);
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
            var iff = Hardware.cpu.iff ? 1 : 0;

            textbox_cf.Text = $"{cf}";
            textbox_zf.Text = $"{zf}";
            textbox_pf.Text = $"{pf}";
            textbox_sf.Text = $"{sf}";
            textbox_acf.Text = $"{acf}";
            textbox_iff.Text = $"{iff}";

			// cpu cycles
			textbox_cc.Text = $"{Hardware.cpu.cc}";
            textbox_last_run.Text = $"{Hardware.cpu.cc - Hardware.debugger.cc_last}";

            // set the position of the cpu pc green arrow icon 
            img_arrow_pc.Visible = false;
            if (pc_icon_pos_y >= 0)
			{
                img_arrow_pc.Visible = true;
                var pc_icon_pos = img_arrow_pc.Location;
                pc_icon_pos.Y = pc_icon_pos_y - img_arrow_pc.Height / 2;
                img_arrow_pc.Location = pc_icon_pos;
            }

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
			Hardware.step();
            update_form();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < 256; i++)
			{
                Hardware.step();
            }
            update_form();
        }
    }
}
