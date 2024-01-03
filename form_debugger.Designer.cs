namespace devector
{
    partial class form_debugger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_debugger));
            this.main_panel = new System.Windows.Forms.SplitContainer();
            this.disasm_group = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.img_arrow_pc = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.execution_stats_list = new System.Windows.Forms.ListBox();
            this.arg_labels_list = new System.Windows.Forms.ListBox();
            this.disasm_list = new System.Windows.Forms.ListBox();
            this.breakpoints_list = new System.Windows.Forms.ListBox();
            this.addr_list = new System.Windows.Forms.ListBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flags_group = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textbox_iff = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.main_panel)).BeginInit();
            this.main_panel.Panel1.SuspendLayout();
            this.main_panel.Panel2.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.disasm_group.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow_pc)).BeginInit();
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
            this.main_panel.Location = new System.Drawing.Point(0, 49);
            this.main_panel.Name = "main_panel";
            // 
            // main_panel.Panel1
            // 
            this.main_panel.Panel1.Controls.Add(this.disasm_group);
            // 
            // main_panel.Panel2
            // 
            this.main_panel.Panel2.Controls.Add(this.middle_panel);
            this.main_panel.Size = new System.Drawing.Size(1177, 712);
            this.main_panel.SplitterDistance = 531;
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
            this.disasm_group.Size = new System.Drawing.Size(531, 712);
            this.disasm_group.TabIndex = 1;
            this.disasm_group.TabStop = false;
            this.disasm_group.Text = "Disasm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.img_arrow_pc);
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 673);
            this.panel2.TabIndex = 0;
            // 
            // img_arrow_pc
            // 
            this.img_arrow_pc.Image = global::devector.Properties.Resources.green_arrow_icon_small;
            this.img_arrow_pc.InitialImage = ((System.Drawing.Image)(resources.GetObject("img_arrow_pc.InitialImage")));
            this.img_arrow_pc.Location = new System.Drawing.Point(0, 20);
            this.img_arrow_pc.Name = "img_arrow_pc";
            this.img_arrow_pc.Size = new System.Drawing.Size(24, 27);
            this.img_arrow_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_arrow_pc.TabIndex = 1;
            this.img_arrow_pc.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(506, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 673);
            this.vScrollBar1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.execution_stats_list, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.arg_labels_list, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.disasm_list, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.breakpoints_list, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addr_list, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 673);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // execution_stats_list
            // 
            this.execution_stats_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.execution_stats_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.execution_stats_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.execution_stats_list.FormattingEnabled = true;
            this.execution_stats_list.Location = new System.Drawing.Point(326, 3);
            this.execution_stats_list.Name = "execution_stats_list";
            this.execution_stats_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.execution_stats_list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.execution_stats_list.Size = new System.Drawing.Size(74, 667);
            this.execution_stats_list.TabIndex = 5;
            // 
            // arg_labels_list
            // 
            this.arg_labels_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.arg_labels_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arg_labels_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arg_labels_list.FormattingEnabled = true;
            this.arg_labels_list.Location = new System.Drawing.Point(406, 3);
            this.arg_labels_list.Name = "arg_labels_list";
            this.arg_labels_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.arg_labels_list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.arg_labels_list.Size = new System.Drawing.Size(116, 667);
            this.arg_labels_list.TabIndex = 6;
            // 
            // disasm_list
            // 
            this.disasm_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disasm_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disasm_list.FormattingEnabled = true;
            this.disasm_list.Location = new System.Drawing.Point(83, 3);
            this.disasm_list.Name = "disasm_list";
            this.disasm_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.disasm_list.Size = new System.Drawing.Size(237, 667);
            this.disasm_list.TabIndex = 1;
            // 
            // breakpoints_list
            // 
            this.breakpoints_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.breakpoints_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.breakpoints_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breakpoints_list.FormattingEnabled = true;
            this.breakpoints_list.Location = new System.Drawing.Point(3, 3);
            this.breakpoints_list.Name = "breakpoints_list";
            this.breakpoints_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.breakpoints_list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.breakpoints_list.Size = new System.Drawing.Size(14, 667);
            this.breakpoints_list.TabIndex = 4;
            // 
            // addr_list
            // 
            this.addr_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addr_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addr_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addr_list.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addr_list.FormattingEnabled = true;
            this.addr_list.Location = new System.Drawing.Point(23, 3);
            this.addr_list.Name = "addr_list";
            this.addr_list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.addr_list.Size = new System.Drawing.Size(54, 667);
            this.addr_list.TabIndex = 2;
            // 
            // search_box
            // 
            this.search_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_box.Location = new System.Drawing.Point(3, 16);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(525, 20);
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
            this.middle_panel.Size = new System.Drawing.Size(405, 712);
            this.middle_panel.TabIndex = 0;
            // 
            // breakpoints_watch
            // 
            this.breakpoints_watch.Controls.Add(this.splitContainer2);
            this.breakpoints_watch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breakpoints_watch.Location = new System.Drawing.Point(0, 181);
            this.breakpoints_watch.Name = "breakpoints_watch";
            this.breakpoints_watch.Size = new System.Drawing.Size(405, 531);
            this.breakpoints_watch.TabIndex = 0;
            this.breakpoints_watch.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
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
            this.splitContainer2.Size = new System.Drawing.Size(399, 512);
            this.splitContainer2.SplitterDistance = 251;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bp_datagrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 251);
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
            this.bp_datagrid.Location = new System.Drawing.Point(3, 16);
            this.bp_datagrid.Name = "bp_datagrid";
            this.bp_datagrid.Size = new System.Drawing.Size(393, 232);
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
            this.br_access.Width = 67;
            // 
            // br_address
            // 
            this.br_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.br_address.HeaderText = "Address";
            this.br_address.Name = "br_address";
            this.br_address.ReadOnly = true;
            this.br_address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.br_address.Width = 70;
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
            this.groupBox2.Size = new System.Drawing.Size(399, 257);
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
            this.watch_datagrid.Location = new System.Drawing.Point(3, 16);
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
            this.stack_group.Controls.Add(this.label11);
            this.stack_group.Controls.Add(this.label10);
            this.stack_group.Controls.Add(this.label9);
            this.stack_group.Controls.Add(this.label8);
            this.stack_group.Controls.Add(this.label7);
            this.stack_group.Controls.Add(this.label6);
            this.stack_group.Controls.Add(this.textBox16);
            this.stack_group.Controls.Add(this.textBox15);
            this.stack_group.Controls.Add(this.textBox5);
            this.stack_group.Controls.Add(this.textBox11);
            this.stack_group.Controls.Add(this.textBox12);
            this.stack_group.Controls.Add(this.textBox13);
            this.stack_group.Controls.Add(this.textBox14);
            this.stack_group.Controls.Add(this.label1);
            this.stack_group.Dock = System.Windows.Forms.DockStyle.Left;
            this.stack_group.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stack_group.Location = new System.Drawing.Point(130, 0);
            this.stack_group.Name = "stack_group";
            this.stack_group.Size = new System.Drawing.Size(98, 181);
            this.stack_group.TabIndex = 13;
            this.stack_group.TabStop = false;
            this.stack_group.Text = "Stack";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 135);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "EFAD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 116);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "EFAD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "EFAD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "EFAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "EFAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "EFAD";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.LightGray;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(39, 135);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(38, 13);
            this.textBox16.TabIndex = 12;
            this.textBox16.Text = "ABCD";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.LightGray;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(39, 116);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(38, 13);
            this.textBox15.TabIndex = 11;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(39, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(38, 13);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.LightGray;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(39, 78);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(38, 13);
            this.textBox11.TabIndex = 9;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.LightGray;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(39, 59);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(38, 13);
            this.textBox12.TabIndex = 8;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.LightGray;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(39, 21);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(38, 13);
            this.textBox13.TabIndex = 6;
            this.textBox13.Text = "DDFF";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.LightGray;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(39, 40);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(38, 13);
            this.textBox14.TabIndex = 7;
            this.textBox14.Text = "1010";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SP:";
            // 
            // flags_group
            // 
            this.flags_group.Controls.Add(this.label12);
            this.flags_group.Controls.Add(this.textbox_iff);
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
            this.flags_group.Size = new System.Drawing.Size(53, 181);
            this.flags_group.TabIndex = 12;
            this.flags_group.TabStop = false;
            this.flags_group.Text = "Flags";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(3, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "IFF";
            // 
            // textbox_iff
            // 
            this.textbox_iff.BackColor = System.Drawing.Color.LightGray;
            this.textbox_iff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_iff.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_iff.Location = new System.Drawing.Point(27, 135);
            this.textbox_iff.Name = "textbox_iff";
            this.textbox_iff.ReadOnly = true;
            this.textbox_iff.Size = new System.Drawing.Size(13, 13);
            this.textbox_iff.TabIndex = 11;
            this.textbox_iff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_acf
            // 
            this.textbox_acf.BackColor = System.Drawing.Color.LightGray;
            this.textbox_acf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_acf.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_acf.Location = new System.Drawing.Point(27, 97);
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
            this.textbox_sf.Location = new System.Drawing.Point(27, 78);
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
            this.textbox_pf.Location = new System.Drawing.Point(27, 59);
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
            this.textbox_cf.Location = new System.Drawing.Point(27, 21);
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
            this.textbox_zf.Location = new System.Drawing.Point(27, 40);
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
            this.label_flag_c.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_c.Location = new System.Drawing.Point(10, 21);
            this.label_flag_c.Name = "label_flag_c";
            this.label_flag_c.Size = new System.Drawing.Size(14, 13);
            this.label_flag_c.TabIndex = 0;
            this.label_flag_c.Text = "C";
            // 
            // label_flag_z
            // 
            this.label_flag_z.AutoSize = true;
            this.label_flag_z.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_z.Location = new System.Drawing.Point(10, 40);
            this.label_flag_z.Name = "label_flag_z";
            this.label_flag_z.Size = new System.Drawing.Size(14, 13);
            this.label_flag_z.TabIndex = 1;
            this.label_flag_z.Text = "Z";
            // 
            // label_flag_p
            // 
            this.label_flag_p.AutoSize = true;
            this.label_flag_p.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_p.Location = new System.Drawing.Point(10, 59);
            this.label_flag_p.Name = "label_flag_p";
            this.label_flag_p.Size = new System.Drawing.Size(14, 13);
            this.label_flag_p.TabIndex = 2;
            this.label_flag_p.Text = "P";
            // 
            // label_flag_s
            // 
            this.label_flag_s.AutoSize = true;
            this.label_flag_s.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_s.Location = new System.Drawing.Point(10, 78);
            this.label_flag_s.Name = "label_flag_s";
            this.label_flag_s.Size = new System.Drawing.Size(14, 13);
            this.label_flag_s.TabIndex = 3;
            this.label_flag_s.Text = "S";
            // 
            // label_flag_ac
            // 
            this.label_flag_ac.AutoSize = true;
            this.label_flag_ac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_flag_ac.Location = new System.Drawing.Point(5, 97);
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
            this.label_reg_bc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_bc.Location = new System.Drawing.Point(3, 37);
            this.label_reg_bc.Name = "label_reg_bc";
            this.label_reg_bc.Size = new System.Drawing.Size(20, 13);
            this.label_reg_bc.TabIndex = 1;
            this.label_reg_bc.Text = "BF";
            // 
            // label_reg_de
            // 
            this.label_reg_de.AutoSize = true;
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
            this.label_reg_pc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_reg_pc.Location = new System.Drawing.Point(3, 113);
            this.label_reg_pc.Name = "label_reg_pc";
            this.label_reg_pc.Size = new System.Drawing.Size(21, 13);
            this.label_reg_pc.TabIndex = 5;
            this.label_reg_pc.Text = "PC";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1177, 24);
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
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.tools.Location = new System.Drawing.Point(0, 24);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1177, 25);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // form_debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 761);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.menu);
            this.Name = "form_debugger";
            this.Text = "Debugger";
            this.main_panel.Panel1.ResumeLayout(false);
            this.main_panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_panel)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.disasm_group.ResumeLayout(false);
            this.disasm_group.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow_pc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textbox_iff;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox execution_stats_list;
        private System.Windows.Forms.ListBox arg_labels_list;
        private System.Windows.Forms.ListBox disasm_list;
        private System.Windows.Forms.ListBox addr_list;
        private System.Windows.Forms.ListBox breakpoints_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView watch_datagrid;
        private System.Windows.Forms.DataGridView bp_datagrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn br_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_access;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn watch_column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_column_name;
        private System.Windows.Forms.PictureBox img_arrow_pc;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}