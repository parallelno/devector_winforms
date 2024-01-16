namespace devector
{
    partial class FormDebugger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebugger));
            this.main_panel = new System.Windows.Forms.SplitContainer();
            this.disasm_group = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_disasm = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.middle_panel = new System.Windows.Forms.Panel();
            this.breakpoints_watch = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bp_datagrid = new System.Windows.Forms.DataGridView();
            this.br_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.br_access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.watch_datagrid = new System.Windows.Forms.DataGridView();
            this.watch_column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hardware_group = new System.Windows.Forms.GroupBox();
            this.mapping_group = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textbox_mapping_stack_page = new System.Windows.Forms.TextBox();
            this.textbox_mapping_stack_mode = new System.Windows.Forms.TextBox();
            this.textbox_mapping_ram_page = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textbox_mapping_ram_mode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textbox_crt_y = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textbox_crt_x = new System.Windows.Forms.TextBox();
            this.textbox_cc = new System.Windows.Forms.TextBox();
            this.textbox_last_run = new System.Windows.Forms.TextBox();
            this.stack_group = new System.Windows.Forms.GroupBox();
            this.label_sp_p6 = new System.Windows.Forms.Label();
            this.label_sp_p4 = new System.Windows.Forms.Label();
            this.label_sp_p2 = new System.Windows.Forms.Label();
            this.label_sp_n2 = new System.Windows.Forms.Label();
            this.label_sp_n4 = new System.Windows.Forms.Label();
            this.label_sp_n6 = new System.Windows.Forms.Label();
            this.textbox_sp_p6 = new System.Windows.Forms.TextBox();
            this.textbox_sp_p4 = new System.Windows.Forms.TextBox();
            this.textbox_sp_p2 = new System.Windows.Forms.TextBox();
            this.textbox_sp_0 = new System.Windows.Forms.TextBox();
            this.textbox_sp_n2 = new System.Windows.Forms.TextBox();
            this.textbox_sp_n6 = new System.Windows.Forms.TextBox();
            this.textbox_sp_n4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flags_group = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_hlta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_iff = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textbox_inte = new System.Windows.Forms.TextBox();
            this.textbox_acf = new System.Windows.Forms.TextBox();
            this.textbox_sf = new System.Windows.Forms.TextBox();
            this.textbox_pf = new System.Windows.Forms.TextBox();
            this.textbox_cf = new System.Windows.Forms.TextBox();
            this.textbox_zf = new System.Windows.Forms.TextBox();
            this.label_flag_c = new System.Windows.Forms.Label();
            this.label_flag_z = new System.Windows.Forms.Label();
            this.label_flag_p = new System.Windows.Forms.Label();
            this.label_flag_s = new System.Windows.Forms.Label();
            this.label_flag_ac = new System.Windows.Forms.Label();
            this.cpu_group = new System.Windows.Forms.GroupBox();
            this.textbox_pc = new System.Windows.Forms.TextBox();
            this.textbox_sp = new System.Windows.Forms.TextBox();
            this.textbox_hl = new System.Windows.Forms.TextBox();
            this.textbox_de = new System.Windows.Forms.TextBox();
            this.textbox_af = new System.Windows.Forms.TextBox();
            this.textbox_bc = new System.Windows.Forms.TextBox();
            this.label_reg_af = new System.Windows.Forms.Label();
            this.label_reg_bc = new System.Windows.Forms.Label();
            this.label_reg_de = new System.Windows.Forms.Label();
            this.label_reg_hl = new System.Windows.Forms.Label();
            this.label_reg_sp = new System.Windows.Forms.Label();
            this.label_reg_pc = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.main_panel)).BeginInit();
            this.main_panel.Panel1.SuspendLayout();
            this.main_panel.Panel2.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.disasm_group.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.middle_panel.SuspendLayout();
            this.breakpoints_watch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bp_datagrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watch_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.hardware_group.SuspendLayout();
            this.mapping_group.SuspendLayout();
            this.stack_group.SuspendLayout();
            this.flags_group.SuspendLayout();
            this.cpu_group.SuspendLayout();
            this.menu.SuspendLayout();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 55);
            this.main_panel.Name = "main_panel";
            // 
            // main_panel.Panel1
            // 
            this.main_panel.Panel1.Controls.Add(this.disasm_group);
            // 
            // main_panel.Panel2
            // 
            this.main_panel.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.main_panel.Panel2.Controls.Add(this.middle_panel);
            this.main_panel.Panel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_panel.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Panel2_Paint);
            this.main_panel.Size = new System.Drawing.Size(1259, 706);
            this.main_panel.SplitterDistance = 567;
            this.main_panel.TabIndex = 0;
            // 
            // disasm_group
            // 
            this.disasm_group.Controls.Add(this.panel2);
            this.disasm_group.Controls.Add(this.search_box);
            this.disasm_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disasm_group.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.disasm_group.Location = new System.Drawing.Point(0, 0);
            this.disasm_group.Name = "disasm_group";
            this.disasm_group.Size = new System.Drawing.Size(567, 706);
            this.disasm_group.TabIndex = 1;
            this.disasm_group.TabStop = false;
            this.disasm_group.Text = "Disasm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 667);
            this.panel2.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(542, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 667);
            this.vScrollBar1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 561F));
            this.tableLayoutPanel1.Controls.Add(this.listBox_disasm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 667);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // listBox_disasm
            // 
            this.listBox_disasm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_disasm.FormattingEnabled = true;
            this.listBox_disasm.Location = new System.Drawing.Point(3, 3);
            this.listBox_disasm.Name = "listBox_disasm";
            this.listBox_disasm.Size = new System.Drawing.Size(555, 641);
            this.listBox_disasm.TabIndex = 3;
            this.listBox_disasm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_disasm_KeyDown);
            this.listBox_disasm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.disasm_list_mouse_down);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 647);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // search_box
            // 
            this.search_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_box.Location = new System.Drawing.Point(3, 16);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(561, 20);
            this.search_box.TabIndex = 2;
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);
            // 
            // middle_panel
            // 
            this.middle_panel.Controls.Add(this.breakpoints_watch);
            this.middle_panel.Controls.Add(this.panel1);
            this.middle_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.middle_panel.Location = new System.Drawing.Point(0, 0);
            this.middle_panel.Name = "middle_panel";
            this.middle_panel.Size = new System.Drawing.Size(405, 706);
            this.middle_panel.TabIndex = 0;
            // 
            // breakpoints_watch
            // 
            this.breakpoints_watch.Controls.Add(this.splitContainer2);
            this.breakpoints_watch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breakpoints_watch.Location = new System.Drawing.Point(0, 181);
            this.breakpoints_watch.Name = "breakpoints_watch";
            this.breakpoints_watch.Size = new System.Drawing.Size(405, 525);
            this.breakpoints_watch.TabIndex = 0;
            this.breakpoints_watch.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 22);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(399, 500);
            this.splitContainer2.SplitterDistance = 233;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bp_datagrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Breakpoints";
            // 
            // bp_datagrid
            // 
            this.bp_datagrid.AllowUserToAddRows = false;
            this.bp_datagrid.AllowUserToDeleteRows = false;
            this.bp_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bp_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bp_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.br_active,
            this.br_access,
            this.br_address,
            this.br_condition});
            this.bp_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bp_datagrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.bp_datagrid.Location = new System.Drawing.Point(3, 22);
            this.bp_datagrid.Name = "bp_datagrid";
            this.bp_datagrid.Size = new System.Drawing.Size(393, 208);
            this.bp_datagrid.TabIndex = 0;
            // 
            // br_active
            // 
            this.br_active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.br_active.HeaderText = "";
            this.br_active.Name = "br_active";
            this.br_active.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.br_active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.br_active.Width = 20;
            // 
            // br_access
            // 
            this.br_access.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.br_access.HeaderText = "Access";
            this.br_access.Name = "br_access";
            this.br_access.ReadOnly = true;
            this.br_access.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.br_access.Width = 88;
            // 
            // br_address
            // 
            this.br_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.br_address.HeaderText = "Address";
            this.br_address.Name = "br_address";
            this.br_address.ReadOnly = true;
            this.br_address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.br_address.Width = 97;
            // 
            // br_condition
            // 
            this.br_condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.br_condition.HeaderText = "Condition";
            this.br_condition.Name = "br_condition";
            this.br_condition.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.watch_datagrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 263);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Watch";
            // 
            // watch_datagrid
            // 
            this.watch_datagrid.AllowUserToAddRows = false;
            this.watch_datagrid.AllowUserToOrderColumns = true;
            this.watch_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.watch_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watch_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.watch_column_name,
            this.value_column_name});
            this.watch_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watch_datagrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.watch_datagrid.Location = new System.Drawing.Point(3, 22);
            this.watch_datagrid.Name = "watch_datagrid";
            this.watch_datagrid.Size = new System.Drawing.Size(393, 238);
            this.watch_datagrid.TabIndex = 0;
            // 
            // watch_column_name
            // 
            this.watch_column_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.watch_column_name.HeaderText = "Name";
            this.watch_column_name.MinimumWidth = 250;
            this.watch_column_name.Name = "watch_column_name";
            // 
            // value_column_name
            // 
            this.value_column_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.value_column_name.FillWeight = 20F;
            this.value_column_name.HeaderText = "Value";
            this.value_column_name.MinimumWidth = 50;
            this.value_column_name.Name = "value_column_name";
            this.value_column_name.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hardware_group);
            this.panel1.Controls.Add(this.stack_group);
            this.panel1.Controls.Add(this.flags_group);
            this.panel1.Controls.Add(this.cpu_group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(409, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 181);
            this.panel1.TabIndex = 2;
            // 
            // hardware_group
            // 
            this.hardware_group.Controls.Add(this.mapping_group);
            this.hardware_group.Controls.Add(this.label14);
            this.hardware_group.Controls.Add(this.label13);
            this.hardware_group.Controls.Add(this.textbox_crt_y);
            this.hardware_group.Controls.Add(this.label16);
            this.hardware_group.Controls.Add(this.label17);
            this.hardware_group.Controls.Add(this.label18);
            this.hardware_group.Controls.Add(this.textbox_crt_x);
            this.hardware_group.Controls.Add(this.textbox_cc);
            this.hardware_group.Controls.Add(this.textbox_last_run);
            this.hardware_group.Dock = System.Windows.Forms.DockStyle.Left;
            this.hardware_group.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hardware_group.Location = new System.Drawing.Point(228, 0);
            this.hardware_group.Name = "hardware_group";
            this.hardware_group.Size = new System.Drawing.Size(177, 181);
            this.hardware_group.TabIndex = 14;
            this.hardware_group.TabStop = false;
            this.hardware_group.Text = "Hardware";
            // 
            // mapping_group
            // 
            this.mapping_group.Controls.Add(this.label21);
            this.mapping_group.Controls.Add(this.label20);
            this.mapping_group.Controls.Add(this.textbox_mapping_stack_page);
            this.mapping_group.Controls.Add(this.textbox_mapping_stack_mode);
            this.mapping_group.Controls.Add(this.textbox_mapping_ram_page);
            this.mapping_group.Controls.Add(this.label15);
            this.mapping_group.Controls.Add(this.textbox_mapping_ram_mode);
            this.mapping_group.Controls.Add(this.label19);
            this.mapping_group.Location = new System.Drawing.Point(9, 78);
            this.mapping_group.Name = "mapping_group";
            this.mapping_group.Size = new System.Drawing.Size(162, 97);
            this.mapping_group.TabIndex = 19;
            this.mapping_group.TabStop = false;
            this.mapping_group.Text = "Mapping";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(12, 75);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Stack Page";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(12, 56);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Stack Mode";
            // 
            // textbox_mapping_stack_page
            // 
            this.textbox_mapping_stack_page.BackColor = System.Drawing.Color.LightGray;
            this.textbox_mapping_stack_page.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_mapping_stack_page.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_mapping_stack_page.Location = new System.Drawing.Point(85, 75);
            this.textbox_mapping_stack_page.Name = "textbox_mapping_stack_page";
            this.textbox_mapping_stack_page.ReadOnly = true;
            this.textbox_mapping_stack_page.Size = new System.Drawing.Size(69, 13);
            this.textbox_mapping_stack_page.TabIndex = 13;
            this.textbox_mapping_stack_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_mapping_stack_mode
            // 
            this.textbox_mapping_stack_mode.BackColor = System.Drawing.Color.LightGray;
            this.textbox_mapping_stack_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_mapping_stack_mode.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_mapping_stack_mode.Location = new System.Drawing.Point(85, 56);
            this.textbox_mapping_stack_mode.Name = "textbox_mapping_stack_mode";
            this.textbox_mapping_stack_mode.ReadOnly = true;
            this.textbox_mapping_stack_mode.Size = new System.Drawing.Size(69, 13);
            this.textbox_mapping_stack_mode.TabIndex = 12;
            this.textbox_mapping_stack_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_mapping_ram_page
            // 
            this.textbox_mapping_ram_page.BackColor = System.Drawing.Color.LightGray;
            this.textbox_mapping_ram_page.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_mapping_ram_page.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_mapping_ram_page.Location = new System.Drawing.Point(85, 37);
            this.textbox_mapping_ram_page.Name = "textbox_mapping_ram_page";
            this.textbox_mapping_ram_page.ReadOnly = true;
            this.textbox_mapping_ram_page.Size = new System.Drawing.Size(69, 13);
            this.textbox_mapping_ram_page.TabIndex = 11;
            this.textbox_mapping_ram_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(12, 37);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "RAM page";
            // 
            // textbox_mapping_ram_mode
            // 
            this.textbox_mapping_ram_mode.BackColor = System.Drawing.Color.LightGray;
            this.textbox_mapping_ram_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_mapping_ram_mode.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_mapping_ram_mode.Location = new System.Drawing.Point(85, 18);
            this.textbox_mapping_ram_mode.Name = "textbox_mapping_ram_mode";
            this.textbox_mapping_ram_mode.ReadOnly = true;
            this.textbox_mapping_ram_mode.Size = new System.Drawing.Size(69, 13);
            this.textbox_mapping_ram_mode.TabIndex = 9;
            this.textbox_mapping_ram_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(12, 18);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "RAM mode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(123, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Y:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(72, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "X:";
            // 
            // textbox_crt_y
            // 
            this.textbox_crt_y.BackColor = System.Drawing.Color.LightGray;
            this.textbox_crt_y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_crt_y.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_crt_y.Location = new System.Drawing.Point(144, 59);
            this.textbox_crt_y.Name = "textbox_crt_y";
            this.textbox_crt_y.ReadOnly = true;
            this.textbox_crt_y.Size = new System.Drawing.Size(22, 13);
            this.textbox_crt_y.TabIndex = 16;
            this.textbox_crt_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(6, 59);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "CRT";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(6, 40);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Last Run";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "CPU Cycles";
            // 
            // textbox_crt_x
            // 
            this.textbox_crt_x.BackColor = System.Drawing.Color.LightGray;
            this.textbox_crt_x.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_crt_x.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_crt_x.Location = new System.Drawing.Point(93, 59);
            this.textbox_crt_x.Name = "textbox_crt_x";
            this.textbox_crt_x.ReadOnly = true;
            this.textbox_crt_x.Size = new System.Drawing.Size(22, 13);
            this.textbox_crt_x.TabIndex = 8;
            this.textbox_crt_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_cc
            // 
            this.textbox_cc.BackColor = System.Drawing.Color.LightGray;
            this.textbox_cc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_cc.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_cc.Location = new System.Drawing.Point(74, 21);
            this.textbox_cc.Name = "textbox_cc";
            this.textbox_cc.ReadOnly = true;
            this.textbox_cc.Size = new System.Drawing.Size(93, 13);
            this.textbox_cc.TabIndex = 6;
            this.textbox_cc.Text = "123456789A";
            // 
            // textbox_last_run
            // 
            this.textbox_last_run.BackColor = System.Drawing.Color.LightGray;
            this.textbox_last_run.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_last_run.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_last_run.Location = new System.Drawing.Point(74, 40);
            this.textbox_last_run.Name = "textbox_last_run";
            this.textbox_last_run.ReadOnly = true;
            this.textbox_last_run.Size = new System.Drawing.Size(93, 13);
            this.textbox_last_run.TabIndex = 7;
            this.textbox_last_run.Text = "1010";
            // 
            // stack_group
            // 
            this.stack_group.Controls.Add(this.label_sp_p6);
            this.stack_group.Controls.Add(this.label_sp_p4);
            this.stack_group.Controls.Add(this.label_sp_p2);
            this.stack_group.Controls.Add(this.label_sp_n2);
            this.stack_group.Controls.Add(this.label_sp_n4);
            this.stack_group.Controls.Add(this.label_sp_n6);
            this.stack_group.Controls.Add(this.textbox_sp_p6);
            this.stack_group.Controls.Add(this.textbox_sp_p4);
            this.stack_group.Controls.Add(this.textbox_sp_p2);
            this.stack_group.Controls.Add(this.textbox_sp_0);
            this.stack_group.Controls.Add(this.textbox_sp_n2);
            this.stack_group.Controls.Add(this.textbox_sp_n6);
            this.stack_group.Controls.Add(this.textbox_sp_n4);
            this.stack_group.Controls.Add(this.label1);
            this.stack_group.Dock = System.Windows.Forms.DockStyle.Left;
            this.stack_group.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stack_group.Location = new System.Drawing.Point(139, 0);
            this.stack_group.Name = "stack_group";
            this.stack_group.Size = new System.Drawing.Size(89, 181);
            this.stack_group.TabIndex = 13;
            this.stack_group.TabStop = false;
            this.stack_group.Text = "Stack";
            // 
            // label_sp_p6
            // 
            this.label_sp_p6.AutoSize = true;
            this.label_sp_p6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_p6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sp_p6.Location = new System.Drawing.Point(18, 135);
            this.label_sp_p6.Name = "label_sp_p6";
            this.label_sp_p6.Size = new System.Drawing.Size(21, 13);
            this.label_sp_p6.TabIndex = 18;
            this.label_sp_p6.Text = "+6";
            // 
            // label_sp_p4
            // 
            this.label_sp_p4.AutoSize = true;
            this.label_sp_p4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_p4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sp_p4.Location = new System.Drawing.Point(18, 116);
            this.label_sp_p4.Name = "label_sp_p4";
            this.label_sp_p4.Size = new System.Drawing.Size(21, 13);
            this.label_sp_p4.TabIndex = 17;
            this.label_sp_p4.Text = "+4";
            // 
            // label_sp_p2
            // 
            this.label_sp_p2.AutoSize = true;
            this.label_sp_p2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_p2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sp_p2.Location = new System.Drawing.Point(18, 97);
            this.label_sp_p2.Name = "label_sp_p2";
            this.label_sp_p2.Size = new System.Drawing.Size(21, 13);
            this.label_sp_p2.TabIndex = 16;
            this.label_sp_p2.Text = "+2";
            // 
            // label_sp_n2
            // 
            this.label_sp_n2.AutoSize = true;
            this.label_sp_n2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_n2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sp_n2.Location = new System.Drawing.Point(18, 59);
            this.label_sp_n2.Name = "label_sp_n2";
            this.label_sp_n2.Size = new System.Drawing.Size(21, 13);
            this.label_sp_n2.TabIndex = 15;
            this.label_sp_n2.Text = "-2";
            // 
            // label_sp_n4
            // 
            this.label_sp_n4.AutoSize = true;
            this.label_sp_n4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_n4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sp_n4.Location = new System.Drawing.Point(18, 40);
            this.label_sp_n4.Name = "label_sp_n4";
            this.label_sp_n4.Size = new System.Drawing.Size(21, 13);
            this.label_sp_n4.TabIndex = 14;
            this.label_sp_n4.Text = "-4";
            // 
            // label_sp_n6
            // 
            this.label_sp_n6.AutoSize = true;
            this.label_sp_n6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_n6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sp_n6.Location = new System.Drawing.Point(18, 21);
            this.label_sp_n6.Name = "label_sp_n6";
            this.label_sp_n6.Size = new System.Drawing.Size(21, 13);
            this.label_sp_n6.TabIndex = 13;
            this.label_sp_n6.Text = "-6";
            // 
            // textbox_sp_p6
            // 
            this.textbox_sp_p6.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp_p6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp_p6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp_p6.Location = new System.Drawing.Point(40, 135);
            this.textbox_sp_p6.Name = "textbox_sp_p6";
            this.textbox_sp_p6.ReadOnly = true;
            this.textbox_sp_p6.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp_p6.TabIndex = 12;
            this.textbox_sp_p6.Text = "ABCD";
            this.textbox_sp_p6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sp_p4
            // 
            this.textbox_sp_p4.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp_p4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp_p4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp_p4.Location = new System.Drawing.Point(40, 116);
            this.textbox_sp_p4.Name = "textbox_sp_p4";
            this.textbox_sp_p4.ReadOnly = true;
            this.textbox_sp_p4.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp_p4.TabIndex = 11;
            this.textbox_sp_p4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sp_p2
            // 
            this.textbox_sp_p2.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp_p2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp_p2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp_p2.Location = new System.Drawing.Point(40, 97);
            this.textbox_sp_p2.Name = "textbox_sp_p2";
            this.textbox_sp_p2.ReadOnly = true;
            this.textbox_sp_p2.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp_p2.TabIndex = 10;
            this.textbox_sp_p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sp_0
            // 
            this.textbox_sp_0.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp_0.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp_0.Location = new System.Drawing.Point(40, 78);
            this.textbox_sp_0.Name = "textbox_sp_0";
            this.textbox_sp_0.ReadOnly = true;
            this.textbox_sp_0.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp_0.TabIndex = 9;
            this.textbox_sp_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sp_n2
            // 
            this.textbox_sp_n2.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp_n2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp_n2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp_n2.Location = new System.Drawing.Point(40, 59);
            this.textbox_sp_n2.Name = "textbox_sp_n2";
            this.textbox_sp_n2.ReadOnly = true;
            this.textbox_sp_n2.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp_n2.TabIndex = 8;
            this.textbox_sp_n2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sp_n6
            // 
            this.textbox_sp_n6.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp_n6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp_n6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp_n6.Location = new System.Drawing.Point(40, 21);
            this.textbox_sp_n6.Name = "textbox_sp_n6";
            this.textbox_sp_n6.ReadOnly = true;
            this.textbox_sp_n6.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp_n6.TabIndex = 6;
            this.textbox_sp_n6.Text = "DDFF";
            this.textbox_sp_n6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sp_n4
            // 
            this.textbox_sp_n4.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp_n4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp_n4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp_n4.Location = new System.Drawing.Point(40, 40);
            this.textbox_sp_n4.Name = "textbox_sp_n4";
            this.textbox_sp_n4.ReadOnly = true;
            this.textbox_sp_n4.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp_n4.TabIndex = 7;
            this.textbox_sp_n4.Text = "1010";
            this.textbox_sp_n4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SP:";
            // 
            // flags_group
            // 
            this.flags_group.Controls.Add(this.label3);
            this.flags_group.Controls.Add(this.textbox_hlta);
            this.flags_group.Controls.Add(this.label2);
            this.flags_group.Controls.Add(this.textbox_iff);
            this.flags_group.Controls.Add(this.label12);
            this.flags_group.Controls.Add(this.textbox_inte);
            this.flags_group.Controls.Add(this.textbox_acf);
            this.flags_group.Controls.Add(this.textbox_sf);
            this.flags_group.Controls.Add(this.textbox_pf);
            this.flags_group.Controls.Add(this.textbox_cf);
            this.flags_group.Controls.Add(this.textbox_zf);
            this.flags_group.Controls.Add(this.label_flag_c);
            this.flags_group.Controls.Add(this.label_flag_z);
            this.flags_group.Controls.Add(this.label_flag_p);
            this.flags_group.Controls.Add(this.label_flag_s);
            this.flags_group.Controls.Add(this.label_flag_ac);
            this.flags_group.Dock = System.Windows.Forms.DockStyle.Left;
            this.flags_group.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flags_group.Location = new System.Drawing.Point(77, 0);
            this.flags_group.Name = "flags_group";
            this.flags_group.Size = new System.Drawing.Size(62, 181);
            this.flags_group.TabIndex = 12;
            this.flags_group.TabStop = false;
            this.flags_group.Text = "Flags";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(2, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "HLTA";
            // 
            // textbox_hlta
            // 
            this.textbox_hlta.BackColor = System.Drawing.Color.LightGray;
            this.textbox_hlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_hlta.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_hlta.Location = new System.Drawing.Point(40, 159);
            this.textbox_hlta.Name = "textbox_hlta";
            this.textbox_hlta.ReadOnly = true;
            this.textbox_hlta.Size = new System.Drawing.Size(13, 13);
            this.textbox_hlta.TabIndex = 15;
            this.textbox_hlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "IFF";
            // 
            // textbox_iff
            // 
            this.textbox_iff.BackColor = System.Drawing.Color.LightGray;
            this.textbox_iff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_iff.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_iff.Location = new System.Drawing.Point(40, 140);
            this.textbox_iff.Name = "textbox_iff";
            this.textbox_iff.ReadOnly = true;
            this.textbox_iff.Size = new System.Drawing.Size(13, 13);
            this.textbox_iff.TabIndex = 13;
            this.textbox_iff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(7, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "INTE";
            // 
            // textbox_inte
            // 
            this.textbox_inte.BackColor = System.Drawing.Color.LightGray;
            this.textbox_inte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_inte.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_inte.Location = new System.Drawing.Point(40, 121);
            this.textbox_inte.Name = "textbox_inte";
            this.textbox_inte.ReadOnly = true;
            this.textbox_inte.Size = new System.Drawing.Size(13, 13);
            this.textbox_inte.TabIndex = 11;
            this.textbox_inte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_acf
            // 
            this.textbox_acf.BackColor = System.Drawing.Color.LightGray;
            this.textbox_acf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_acf.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_acf.Location = new System.Drawing.Point(40, 97);
            this.textbox_acf.Name = "textbox_acf";
            this.textbox_acf.ReadOnly = true;
            this.textbox_acf.Size = new System.Drawing.Size(13, 13);
            this.textbox_acf.TabIndex = 10;
            this.textbox_acf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sf
            // 
            this.textbox_sf.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sf.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sf.Location = new System.Drawing.Point(40, 78);
            this.textbox_sf.Name = "textbox_sf";
            this.textbox_sf.ReadOnly = true;
            this.textbox_sf.Size = new System.Drawing.Size(13, 13);
            this.textbox_sf.TabIndex = 9;
            this.textbox_sf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_pf
            // 
            this.textbox_pf.BackColor = System.Drawing.Color.LightGray;
            this.textbox_pf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_pf.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_pf.Location = new System.Drawing.Point(40, 59);
            this.textbox_pf.Name = "textbox_pf";
            this.textbox_pf.ReadOnly = true;
            this.textbox_pf.Size = new System.Drawing.Size(13, 13);
            this.textbox_pf.TabIndex = 8;
            this.textbox_pf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_cf
            // 
            this.textbox_cf.BackColor = System.Drawing.Color.LightGray;
            this.textbox_cf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_cf.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_cf.Location = new System.Drawing.Point(40, 21);
            this.textbox_cf.Name = "textbox_cf";
            this.textbox_cf.ReadOnly = true;
            this.textbox_cf.Size = new System.Drawing.Size(13, 13);
            this.textbox_cf.TabIndex = 6;
            this.textbox_cf.Text = "0";
            this.textbox_cf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_zf
            // 
            this.textbox_zf.BackColor = System.Drawing.Color.LightGray;
            this.textbox_zf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_zf.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_zf.Location = new System.Drawing.Point(40, 40);
            this.textbox_zf.Name = "textbox_zf";
            this.textbox_zf.ReadOnly = true;
            this.textbox_zf.Size = new System.Drawing.Size(13, 13);
            this.textbox_zf.TabIndex = 7;
            this.textbox_zf.Text = "1";
            this.textbox_zf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_flag_c
            // 
            this.label_flag_c.AutoSize = true;
            this.label_flag_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_flag_c.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_c.Location = new System.Drawing.Point(23, 21);
            this.label_flag_c.Name = "label_flag_c";
            this.label_flag_c.Size = new System.Drawing.Size(14, 13);
            this.label_flag_c.TabIndex = 0;
            this.label_flag_c.Text = "C";
            // 
            // label_flag_z
            // 
            this.label_flag_z.AutoSize = true;
            this.label_flag_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_flag_z.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_z.Location = new System.Drawing.Point(23, 40);
            this.label_flag_z.Name = "label_flag_z";
            this.label_flag_z.Size = new System.Drawing.Size(14, 13);
            this.label_flag_z.TabIndex = 1;
            this.label_flag_z.Text = "Z";
            // 
            // label_flag_p
            // 
            this.label_flag_p.AutoSize = true;
            this.label_flag_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_flag_p.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_p.Location = new System.Drawing.Point(23, 59);
            this.label_flag_p.Name = "label_flag_p";
            this.label_flag_p.Size = new System.Drawing.Size(14, 13);
            this.label_flag_p.TabIndex = 2;
            this.label_flag_p.Text = "P";
            // 
            // label_flag_s
            // 
            this.label_flag_s.AutoSize = true;
            this.label_flag_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_flag_s.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_s.Location = new System.Drawing.Point(23, 78);
            this.label_flag_s.Name = "label_flag_s";
            this.label_flag_s.Size = new System.Drawing.Size(14, 13);
            this.label_flag_s.TabIndex = 3;
            this.label_flag_s.Text = "S";
            // 
            // label_flag_ac
            // 
            this.label_flag_ac.AutoSize = true;
            this.label_flag_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_flag_ac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_ac.Location = new System.Drawing.Point(18, 97);
            this.label_flag_ac.Name = "label_flag_ac";
            this.label_flag_ac.Size = new System.Drawing.Size(21, 13);
            this.label_flag_ac.TabIndex = 4;
            this.label_flag_ac.Text = "AC";
            // 
            // cpu_group
            // 
            this.cpu_group.Controls.Add(this.textbox_pc);
            this.cpu_group.Controls.Add(this.textbox_sp);
            this.cpu_group.Controls.Add(this.textbox_hl);
            this.cpu_group.Controls.Add(this.textbox_de);
            this.cpu_group.Controls.Add(this.textbox_af);
            this.cpu_group.Controls.Add(this.textbox_bc);
            this.cpu_group.Controls.Add(this.label_reg_af);
            this.cpu_group.Controls.Add(this.label_reg_bc);
            this.cpu_group.Controls.Add(this.label_reg_de);
            this.cpu_group.Controls.Add(this.label_reg_hl);
            this.cpu_group.Controls.Add(this.label_reg_sp);
            this.cpu_group.Controls.Add(this.label_reg_pc);
            this.cpu_group.Dock = System.Windows.Forms.DockStyle.Left;
            this.cpu_group.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cpu_group.Location = new System.Drawing.Point(0, 0);
            this.cpu_group.Name = "cpu_group";
            this.cpu_group.Size = new System.Drawing.Size(77, 181);
            this.cpu_group.TabIndex = 1;
            this.cpu_group.TabStop = false;
            this.cpu_group.Text = "Regs";
            // 
            // textbox_pc
            // 
            this.textbox_pc.BackColor = System.Drawing.Color.LightGray;
            this.textbox_pc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_pc.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_pc.Location = new System.Drawing.Point(28, 116);
            this.textbox_pc.Name = "textbox_pc";
            this.textbox_pc.ReadOnly = true;
            this.textbox_pc.Size = new System.Drawing.Size(38, 13);
            this.textbox_pc.TabIndex = 11;
            this.textbox_pc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_sp
            // 
            this.textbox_sp.BackColor = System.Drawing.Color.LightGray;
            this.textbox_sp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sp.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sp.Location = new System.Drawing.Point(28, 97);
            this.textbox_sp.Name = "textbox_sp";
            this.textbox_sp.ReadOnly = true;
            this.textbox_sp.Size = new System.Drawing.Size(38, 13);
            this.textbox_sp.TabIndex = 10;
            this.textbox_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_hl
            // 
            this.textbox_hl.BackColor = System.Drawing.Color.LightGray;
            this.textbox_hl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_hl.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_hl.Location = new System.Drawing.Point(28, 78);
            this.textbox_hl.Name = "textbox_hl";
            this.textbox_hl.ReadOnly = true;
            this.textbox_hl.Size = new System.Drawing.Size(38, 13);
            this.textbox_hl.TabIndex = 9;
            this.textbox_hl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_de
            // 
            this.textbox_de.BackColor = System.Drawing.Color.LightGray;
            this.textbox_de.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_de.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_de.Location = new System.Drawing.Point(28, 59);
            this.textbox_de.Name = "textbox_de";
            this.textbox_de.ReadOnly = true;
            this.textbox_de.Size = new System.Drawing.Size(38, 13);
            this.textbox_de.TabIndex = 8;
            this.textbox_de.Text = "DDDD";
            this.textbox_de.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_af
            // 
            this.textbox_af.BackColor = System.Drawing.Color.LightGray;
            this.textbox_af.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_af.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_af.Location = new System.Drawing.Point(28, 21);
            this.textbox_af.Name = "textbox_af";
            this.textbox_af.ReadOnly = true;
            this.textbox_af.Size = new System.Drawing.Size(38, 13);
            this.textbox_af.TabIndex = 6;
            this.textbox_af.Text = "0046";
            this.textbox_af.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_bc
            // 
            this.textbox_bc.BackColor = System.Drawing.Color.LightGray;
            this.textbox_bc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_bc.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_bc.Location = new System.Drawing.Point(28, 40);
            this.textbox_bc.Name = "textbox_bc";
            this.textbox_bc.ReadOnly = true;
            this.textbox_bc.Size = new System.Drawing.Size(38, 13);
            this.textbox_bc.TabIndex = 7;
            this.textbox_bc.Text = "FFFF";
            this.textbox_bc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_reg_af
            // 
            this.label_reg_af.AutoSize = true;
            this.label_reg_af.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_reg_af.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_af.Location = new System.Drawing.Point(3, 18);
            this.label_reg_af.Name = "label_reg_af";
            this.label_reg_af.Size = new System.Drawing.Size(20, 13);
            this.label_reg_af.TabIndex = 0;
            this.label_reg_af.Text = "AF";
            // 
            // label_reg_bc
            // 
            this.label_reg_bc.AutoSize = true;
            this.label_reg_bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_reg_bc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_bc.Location = new System.Drawing.Point(3, 37);
            this.label_reg_bc.Name = "label_reg_bc";
            this.label_reg_bc.Size = new System.Drawing.Size(21, 13);
            this.label_reg_bc.TabIndex = 1;
            this.label_reg_bc.Text = "BC";
            // 
            // label_reg_de
            // 
            this.label_reg_de.AutoSize = true;
            this.label_reg_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_reg_de.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_de.Location = new System.Drawing.Point(3, 56);
            this.label_reg_de.Name = "label_reg_de";
            this.label_reg_de.Size = new System.Drawing.Size(22, 13);
            this.label_reg_de.TabIndex = 2;
            this.label_reg_de.Text = "DE";
            // 
            // label_reg_hl
            // 
            this.label_reg_hl.AutoSize = true;
            this.label_reg_hl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_reg_hl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_hl.Location = new System.Drawing.Point(3, 75);
            this.label_reg_hl.Name = "label_reg_hl";
            this.label_reg_hl.Size = new System.Drawing.Size(21, 13);
            this.label_reg_hl.TabIndex = 3;
            this.label_reg_hl.Text = "HL";
            // 
            // label_reg_sp
            // 
            this.label_reg_sp.AutoSize = true;
            this.label_reg_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_reg_sp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_sp.Location = new System.Drawing.Point(2, 94);
            this.label_reg_sp.Name = "label_reg_sp";
            this.label_reg_sp.Size = new System.Drawing.Size(21, 13);
            this.label_reg_sp.TabIndex = 4;
            this.label_reg_sp.Text = "SP";
            // 
            // label_reg_pc
            // 
            this.label_reg_pc.AutoSize = true;
            this.label_reg_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_reg_pc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_pc.Location = new System.Drawing.Point(3, 113);
            this.label_reg_pc.Name = "label_reg_pc";
            this.label_reg_pc.Size = new System.Drawing.Size(21, 13);
            this.label_reg_pc.TabIndex = 5;
            this.label_reg_pc.Text = "PC";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1259, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tools
            // 
            this.tools.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tools.Location = new System.Drawing.Point(0, 24);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1259, 31);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // FormDebugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 761);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.menu);
            this.Name = "FormDebugger";
            this.Text = "Debugger";
            this.main_panel.Panel1.ResumeLayout(false);
            this.main_panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_panel)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.disasm_group.ResumeLayout(false);
            this.disasm_group.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.middle_panel.ResumeLayout(false);
            this.breakpoints_watch.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bp_datagrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watch_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.hardware_group.ResumeLayout(false);
            this.hardware_group.PerformLayout();
            this.mapping_group.ResumeLayout(false);
            this.mapping_group.PerformLayout();
            this.stack_group.ResumeLayout(false);
            this.stack_group.PerformLayout();
            this.flags_group.ResumeLayout(false);
            this.flags_group.PerformLayout();
            this.cpu_group.ResumeLayout(false);
            this.cpu_group.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer main_panel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.GroupBox disasm_group;
        private System.Windows.Forms.GroupBox breakpoints_watch;
        private System.Windows.Forms.GroupBox cpu_group;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_reg_af;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_reg_bc;
        private System.Windows.Forms.Label label_reg_de;
        private System.Windows.Forms.Label label_reg_hl;
        private System.Windows.Forms.Label label_reg_sp;
        private System.Windows.Forms.Label label_reg_pc;
        private System.Windows.Forms.TextBox textbox_af;
        private System.Windows.Forms.TextBox textbox_bc;
        private System.Windows.Forms.TextBox textbox_sp;
        private System.Windows.Forms.TextBox textbox_hl;
        private System.Windows.Forms.TextBox textbox_de;
        private System.Windows.Forms.GroupBox flags_group;
        private System.Windows.Forms.TextBox textbox_acf;
        private System.Windows.Forms.TextBox textbox_sf;
        private System.Windows.Forms.TextBox textbox_pf;
        private System.Windows.Forms.TextBox textbox_cf;
        private System.Windows.Forms.TextBox textbox_zf;
        private System.Windows.Forms.Label label_flag_c;
        private System.Windows.Forms.Label label_flag_z;
        private System.Windows.Forms.Label label_flag_p;
        private System.Windows.Forms.Label label_flag_s;
        private System.Windows.Forms.Label label_flag_ac;
        private System.Windows.Forms.TextBox textbox_pc;
        private System.Windows.Forms.GroupBox stack_group;
        private System.Windows.Forms.TextBox textbox_sp_p2;
        private System.Windows.Forms.TextBox textbox_sp_0;
        private System.Windows.Forms.TextBox textbox_sp_n2;
        private System.Windows.Forms.TextBox textbox_sp_n6;
        private System.Windows.Forms.TextBox textbox_sp_n4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_sp_p4;
        private System.Windows.Forms.Label label_sp_n6;
        private System.Windows.Forms.TextBox textbox_sp_p6;
        private System.Windows.Forms.Label label_sp_p6;
        private System.Windows.Forms.Label label_sp_p4;
        private System.Windows.Forms.Label label_sp_p2;
        private System.Windows.Forms.Label label_sp_n2;
        private System.Windows.Forms.Label label_sp_n4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textbox_inte;
        private System.Windows.Forms.GroupBox hardware_group;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textbox_mapping_ram_mode;
        private System.Windows.Forms.TextBox textbox_crt_x;
        private System.Windows.Forms.TextBox textbox_cc;
        private System.Windows.Forms.TextBox textbox_last_run;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox mapping_group;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textbox_crt_y;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textbox_mapping_stack_page;
        private System.Windows.Forms.TextBox textbox_mapping_stack_mode;
        private System.Windows.Forms.TextBox textbox_mapping_ram_page;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel middle_panel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView watch_datagrid;
        private System.Windows.Forms.DataGridView bp_datagrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn br_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_access;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn watch_column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_column_name;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_iff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_hlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_disasm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}