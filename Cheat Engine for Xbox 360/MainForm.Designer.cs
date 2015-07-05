namespace Cheat_Engine_for_Xbox_360
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.strip = new System.Windows.Forms.MenuStrip();
            this.strip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_about = new System.Windows.Forms.ToolStripMenuItem();
            this.found_list = new System.Windows.Forms.ListView();
            this.found_list_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.found_list_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.found_list_previous = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.found_list_context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.found_list_context_add = new System.Windows.Forms.ToolStripMenuItem();
            this.found_list_context_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.found_list_context_change = new System.Windows.Forms.ToolStripMenuItem();
            this.found_list_context_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.connect = new System.Windows.Forms.Button();
            this.connect_ip = new System.Windows.Forms.TextBox();
            this.saved_list = new System.Windows.Forms.ListView();
            this.saved_list_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saved_list_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saved_list_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saved_list_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saved_list_context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saved_list_context_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.saved_list_context_change = new System.Windows.Forms.ToolStripMenuItem();
            this.saved_list_context_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.saved_list_context_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.scan_first = new System.Windows.Forms.Button();
            this.scan_next = new System.Windows.Forms.Button();
            this.scan_value_ishex = new System.Windows.Forms.CheckBox();
            this.scan_value_lbl = new System.Windows.Forms.Label();
            this.scan_value = new System.Windows.Forms.TextBox();
            this.scan_range_from_lbl = new System.Windows.Forms.Label();
            this.scan_range_from = new System.Windows.Forms.TextBox();
            this.scan_range_to_lbl = new System.Windows.Forms.Label();
            this.scan_range_to = new System.Windows.Forms.TextBox();
            this.scan_type = new System.Windows.Forms.ComboBox();
            this.scan_type_lbl = new System.Windows.Forms.Label();
            this.scan_stopwhilescanning = new System.Windows.Forms.CheckBox();
            this.memview = new System.Windows.Forms.Button();
            this.saved_add = new System.Windows.Forms.Button();
            this.scan_progress = new System.Windows.Forms.ProgressBar();
            this.scan_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refresh_interval_lbl = new System.Windows.Forms.Label();
            this.refresh_interval = new System.Windows.Forms.NumericUpDown();
            this.refresh_do = new System.Windows.Forms.CheckBox();
            this.strip.SuspendLayout();
            this.found_list_context.SuspendLayout();
            this.saved_list_context.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // strip
            // 
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_file,
            this.strip_about});
            this.strip.Location = new System.Drawing.Point(0, 0);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(577, 24);
            this.strip.TabIndex = 0;
            this.strip.Text = "menuStrip1";
            // 
            // strip_file
            // 
            this.strip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_file_open,
            this.strip_file_save});
            this.strip_file.Name = "strip_file";
            this.strip_file.Size = new System.Drawing.Size(37, 20);
            this.strip_file.Text = "File";
            // 
            // strip_file_open
            // 
            this.strip_file_open.Name = "strip_file_open";
            this.strip_file_open.Size = new System.Drawing.Size(124, 22);
            this.strip_file_open.Text = "Open File";
            this.strip_file_open.Click += new System.EventHandler(this.strip_file_open_Click);
            // 
            // strip_file_save
            // 
            this.strip_file_save.Name = "strip_file_save";
            this.strip_file_save.Size = new System.Drawing.Size(124, 22);
            this.strip_file_save.Text = "Save File";
            this.strip_file_save.Click += new System.EventHandler(this.strip_file_save_Click);
            // 
            // strip_about
            // 
            this.strip_about.Name = "strip_about";
            this.strip_about.Size = new System.Drawing.Size(52, 20);
            this.strip_about.Text = "About";
            this.strip_about.Click += new System.EventHandler(this.strip_about_Click);
            // 
            // found_list
            // 
            this.found_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.found_list_address,
            this.found_list_value,
            this.found_list_previous});
            this.found_list.ContextMenuStrip = this.found_list_context;
            this.found_list.Enabled = false;
            this.found_list.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.found_list.FullRowSelect = true;
            this.found_list.GridLines = true;
            this.found_list.Location = new System.Drawing.Point(12, 56);
            this.found_list.MultiSelect = false;
            this.found_list.Name = "found_list";
            this.found_list.Size = new System.Drawing.Size(258, 263);
            this.found_list.TabIndex = 1;
            this.found_list.UseCompatibleStateImageBehavior = false;
            this.found_list.View = System.Windows.Forms.View.Details;
            // 
            // found_list_address
            // 
            this.found_list_address.Text = "Address";
            this.found_list_address.Width = 81;
            // 
            // found_list_value
            // 
            this.found_list_value.Text = "Value";
            this.found_list_value.Width = 78;
            // 
            // found_list_previous
            // 
            this.found_list_previous.Text = "Previous";
            this.found_list_previous.Width = 77;
            // 
            // found_list_context
            // 
            this.found_list_context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.found_list_context_add,
            this.found_list_context_browse,
            this.found_list_context_change,
            this.found_list_context_remove});
            this.found_list_context.Name = "found_list_context";
            this.found_list_context.Size = new System.Drawing.Size(257, 92);
            // 
            // found_list_context_add
            // 
            this.found_list_context_add.Name = "found_list_context_add";
            this.found_list_context_add.Size = new System.Drawing.Size(256, 22);
            this.found_list_context_add.Text = "Add this address to the address list";
            this.found_list_context_add.Click += new System.EventHandler(this.found_list_context_add_Click);
            // 
            // found_list_context_browse
            // 
            this.found_list_context_browse.Name = "found_list_context_browse";
            this.found_list_context_browse.Size = new System.Drawing.Size(256, 22);
            this.found_list_context_browse.Text = "Browse this region of memory";
            this.found_list_context_browse.Click += new System.EventHandler(this.found_list_context_browse_Click);
            // 
            // found_list_context_change
            // 
            this.found_list_context_change.Name = "found_list_context_change";
            this.found_list_context_change.Size = new System.Drawing.Size(256, 22);
            this.found_list_context_change.Text = "Change the value of this address";
            this.found_list_context_change.Click += new System.EventHandler(this.found_list_context_change_Click);
            // 
            // found_list_context_remove
            // 
            this.found_list_context_remove.Name = "found_list_context_remove";
            this.found_list_context_remove.Size = new System.Drawing.Size(256, 22);
            this.found_list_context_remove.Text = "Remove this address";
            this.found_list_context_remove.Click += new System.EventHandler(this.found_list_context_remove_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(110, 27);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(160, 23);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect to Xbox 360";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // connect_ip
            // 
            this.connect_ip.Location = new System.Drawing.Point(12, 27);
            this.connect_ip.MaxLength = 15;
            this.connect_ip.Name = "connect_ip";
            this.connect_ip.Size = new System.Drawing.Size(92, 22);
            this.connect_ip.TabIndex = 3;
            // 
            // saved_list
            // 
            this.saved_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.saved_list_address,
            this.saved_list_description,
            this.saved_list_type,
            this.saved_list_value});
            this.saved_list.ContextMenuStrip = this.saved_list_context;
            this.saved_list.Enabled = false;
            this.saved_list.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved_list.FullRowSelect = true;
            this.saved_list.GridLines = true;
            this.saved_list.Location = new System.Drawing.Point(12, 354);
            this.saved_list.MultiSelect = false;
            this.saved_list.Name = "saved_list";
            this.saved_list.Size = new System.Drawing.Size(553, 172);
            this.saved_list.TabIndex = 4;
            this.saved_list.UseCompatibleStateImageBehavior = false;
            this.saved_list.View = System.Windows.Forms.View.Details;
            // 
            // saved_list_address
            // 
            this.saved_list_address.Text = "Address";
            this.saved_list_address.Width = 80;
            // 
            // saved_list_description
            // 
            this.saved_list_description.Text = "Description";
            this.saved_list_description.Width = 245;
            // 
            // saved_list_type
            // 
            this.saved_list_type.Text = "Data Type";
            this.saved_list_type.Width = 88;
            // 
            // saved_list_value
            // 
            this.saved_list_value.Text = "Value";
            this.saved_list_value.Width = 115;
            // 
            // saved_list_context
            // 
            this.saved_list_context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saved_list_context_browse,
            this.saved_list_context_change,
            this.saved_list_context_edit,
            this.saved_list_context_remove});
            this.saved_list_context.Name = "saved_list_context";
            this.saved_list_context.Size = new System.Drawing.Size(234, 92);
            // 
            // saved_list_context_browse
            // 
            this.saved_list_context_browse.Name = "saved_list_context_browse";
            this.saved_list_context_browse.Size = new System.Drawing.Size(233, 22);
            this.saved_list_context_browse.Text = "Browse this region of memory";
            this.saved_list_context_browse.Click += new System.EventHandler(this.saved_list_context_browse_Click);
            // 
            // saved_list_context_change
            // 
            this.saved_list_context_change.Name = "saved_list_context_change";
            this.saved_list_context_change.Size = new System.Drawing.Size(233, 22);
            this.saved_list_context_change.Text = "Change value of entry";
            this.saved_list_context_change.Click += new System.EventHandler(this.saved_list_context_change_Click);
            // 
            // saved_list_context_edit
            // 
            this.saved_list_context_edit.Name = "saved_list_context_edit";
            this.saved_list_context_edit.Size = new System.Drawing.Size(233, 22);
            this.saved_list_context_edit.Text = "Edit entry";
            this.saved_list_context_edit.Click += new System.EventHandler(this.saved_list_context_edit_Click);
            // 
            // saved_list_context_remove
            // 
            this.saved_list_context_remove.Name = "saved_list_context_remove";
            this.saved_list_context_remove.Size = new System.Drawing.Size(233, 22);
            this.saved_list_context_remove.Text = "Remove entry";
            this.saved_list_context_remove.Click += new System.EventHandler(this.saved_list_context_remove_Click);
            // 
            // scan_first
            // 
            this.scan_first.Enabled = false;
            this.scan_first.Location = new System.Drawing.Point(276, 56);
            this.scan_first.Name = "scan_first";
            this.scan_first.Size = new System.Drawing.Size(95, 23);
            this.scan_first.TabIndex = 5;
            this.scan_first.Text = "First Scan";
            this.scan_first.UseVisualStyleBackColor = true;
            this.scan_first.Click += new System.EventHandler(this.scan_first_Click);
            // 
            // scan_next
            // 
            this.scan_next.Enabled = false;
            this.scan_next.Location = new System.Drawing.Point(373, 56);
            this.scan_next.Name = "scan_next";
            this.scan_next.Size = new System.Drawing.Size(95, 23);
            this.scan_next.TabIndex = 6;
            this.scan_next.Text = "Second Scan";
            this.scan_next.UseVisualStyleBackColor = true;
            this.scan_next.Click += new System.EventHandler(this.scan_next_Click);
            // 
            // scan_value_ishex
            // 
            this.scan_value_ishex.AutoSize = true;
            this.scan_value_ishex.Enabled = false;
            this.scan_value_ishex.Location = new System.Drawing.Point(523, 119);
            this.scan_value_ishex.Name = "scan_value_ishex";
            this.scan_value_ishex.Size = new System.Drawing.Size(45, 17);
            this.scan_value_ishex.TabIndex = 7;
            this.scan_value_ishex.Text = "Hex";
            this.scan_value_ishex.UseVisualStyleBackColor = true;
            // 
            // scan_value_lbl
            // 
            this.scan_value_lbl.AutoSize = true;
            this.scan_value_lbl.Location = new System.Drawing.Point(288, 117);
            this.scan_value_lbl.Name = "scan_value_lbl";
            this.scan_value_lbl.Size = new System.Drawing.Size(36, 13);
            this.scan_value_lbl.TabIndex = 9;
            this.scan_value_lbl.Text = "Value";
            // 
            // scan_value
            // 
            this.scan_value.Enabled = false;
            this.scan_value.Location = new System.Drawing.Point(330, 114);
            this.scan_value.Name = "scan_value";
            this.scan_value.Size = new System.Drawing.Size(187, 22);
            this.scan_value.TabIndex = 10;
            // 
            // scan_range_from_lbl
            // 
            this.scan_range_from_lbl.AutoSize = true;
            this.scan_range_from_lbl.Location = new System.Drawing.Point(276, 91);
            this.scan_range_from_lbl.Name = "scan_range_from_lbl";
            this.scan_range_from_lbl.Size = new System.Drawing.Size(48, 13);
            this.scan_range_from_lbl.TabIndex = 11;
            this.scan_range_from_lbl.Text = "Address";
            // 
            // scan_range_from
            // 
            this.scan_range_from.Enabled = false;
            this.scan_range_from.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.scan_range_from.Location = new System.Drawing.Point(330, 88);
            this.scan_range_from.MaxLength = 10;
            this.scan_range_from.Name = "scan_range_from";
            this.scan_range_from.Size = new System.Drawing.Size(79, 20);
            this.scan_range_from.TabIndex = 12;
            this.scan_range_from.Text = "0x82000000";
            // 
            // scan_range_to_lbl
            // 
            this.scan_range_to_lbl.AutoSize = true;
            this.scan_range_to_lbl.Location = new System.Drawing.Point(422, 91);
            this.scan_range_to_lbl.Name = "scan_range_to_lbl";
            this.scan_range_to_lbl.Size = new System.Drawing.Size(43, 13);
            this.scan_range_to_lbl.TabIndex = 13;
            this.scan_range_to_lbl.Text = "Length";
            // 
            // scan_range_to
            // 
            this.scan_range_to.Enabled = false;
            this.scan_range_to.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.scan_range_to.Location = new System.Drawing.Point(471, 88);
            this.scan_range_to.MaxLength = 10;
            this.scan_range_to.Name = "scan_range_to";
            this.scan_range_to.Size = new System.Drawing.Size(79, 20);
            this.scan_range_to.TabIndex = 14;
            this.scan_range_to.Text = "0xFFFF";
            // 
            // scan_type
            // 
            this.scan_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scan_type.Enabled = false;
            this.scan_type.FormattingEnabled = true;
            this.scan_type.Items.AddRange(new object[] {
            "BYTE",
            "BYTE*",
            "WORD",
            "DWORD",
            "QWORD",
            "FLOAT",
            "DOUBLE",
            "STRING"});
            this.scan_type.Location = new System.Drawing.Point(330, 142);
            this.scan_type.Name = "scan_type";
            this.scan_type.Size = new System.Drawing.Size(187, 21);
            this.scan_type.TabIndex = 15;
            this.scan_type.SelectedIndexChanged += new System.EventHandler(this.scan_type_SelectedIndexChanged);
            // 
            // scan_type_lbl
            // 
            this.scan_type_lbl.AutoSize = true;
            this.scan_type_lbl.Location = new System.Drawing.Point(294, 145);
            this.scan_type_lbl.Name = "scan_type_lbl";
            this.scan_type_lbl.Size = new System.Drawing.Size(30, 13);
            this.scan_type_lbl.TabIndex = 16;
            this.scan_type_lbl.Text = "Type";
            // 
            // scan_stopwhilescanning
            // 
            this.scan_stopwhilescanning.AutoSize = true;
            this.scan_stopwhilescanning.Checked = true;
            this.scan_stopwhilescanning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scan_stopwhilescanning.Enabled = false;
            this.scan_stopwhilescanning.Location = new System.Drawing.Point(330, 169);
            this.scan_stopwhilescanning.Name = "scan_stopwhilescanning";
            this.scan_stopwhilescanning.Size = new System.Drawing.Size(137, 17);
            this.scan_stopwhilescanning.TabIndex = 17;
            this.scan_stopwhilescanning.Text = "Pause while scanning";
            this.scan_stopwhilescanning.UseVisualStyleBackColor = true;
            // 
            // memview
            // 
            this.memview.Enabled = false;
            this.memview.Location = new System.Drawing.Point(12, 325);
            this.memview.Name = "memview";
            this.memview.Size = new System.Drawing.Size(258, 23);
            this.memview.TabIndex = 18;
            this.memview.Text = "Memory View";
            this.memview.UseVisualStyleBackColor = true;
            this.memview.Click += new System.EventHandler(this.memview_Click);
            // 
            // saved_add
            // 
            this.saved_add.Enabled = false;
            this.saved_add.Location = new System.Drawing.Point(436, 532);
            this.saved_add.Name = "saved_add";
            this.saved_add.Size = new System.Drawing.Size(129, 23);
            this.saved_add.TabIndex = 19;
            this.saved_add.Text = "Add Entry Manually";
            this.saved_add.UseVisualStyleBackColor = true;
            this.saved_add.Click += new System.EventHandler(this.saved_add_Click);
            // 
            // scan_progress
            // 
            this.scan_progress.Location = new System.Drawing.Point(276, 27);
            this.scan_progress.Name = "scan_progress";
            this.scan_progress.Size = new System.Drawing.Size(289, 23);
            this.scan_progress.TabIndex = 20;
            // 
            // scan_new
            // 
            this.scan_new.Enabled = false;
            this.scan_new.Location = new System.Drawing.Point(470, 56);
            this.scan_new.Name = "scan_new";
            this.scan_new.Size = new System.Drawing.Size(95, 23);
            this.scan_new.TabIndex = 21;
            this.scan_new.Text = "New Scan";
            this.scan_new.UseVisualStyleBackColor = true;
            this.scan_new.Click += new System.EventHandler(this.scan_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refresh_interval_lbl);
            this.groupBox1.Controls.Add(this.refresh_interval);
            this.groupBox1.Controls.Add(this.refresh_do);
            this.groupBox1.Location = new System.Drawing.Point(311, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 74);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refresh";
            // 
            // refresh_interval_lbl
            // 
            this.refresh_interval_lbl.AutoSize = true;
            this.refresh_interval_lbl.Location = new System.Drawing.Point(6, 46);
            this.refresh_interval_lbl.Name = "refresh_interval_lbl";
            this.refresh_interval_lbl.Size = new System.Drawing.Size(113, 13);
            this.refresh_interval_lbl.TabIndex = 2;
            this.refresh_interval_lbl.Text = "Refresh interval (ms):";
            // 
            // refresh_interval
            // 
            this.refresh_interval.Location = new System.Drawing.Point(125, 44);
            this.refresh_interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.refresh_interval.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.refresh_interval.Name = "refresh_interval";
            this.refresh_interval.Size = new System.Drawing.Size(120, 22);
            this.refresh_interval.TabIndex = 1;
            this.refresh_interval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // refresh_do
            // 
            this.refresh_do.AutoSize = true;
            this.refresh_do.Location = new System.Drawing.Point(9, 21);
            this.refresh_do.Name = "refresh_do";
            this.refresh_do.Size = new System.Drawing.Size(100, 17);
            this.refresh_do.TabIndex = 0;
            this.refresh_do.Text = "Refresh values";
            this.refresh_do.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scan_new);
            this.Controls.Add(this.scan_progress);
            this.Controls.Add(this.saved_add);
            this.Controls.Add(this.memview);
            this.Controls.Add(this.scan_stopwhilescanning);
            this.Controls.Add(this.scan_type_lbl);
            this.Controls.Add(this.scan_type);
            this.Controls.Add(this.scan_range_to);
            this.Controls.Add(this.scan_range_to_lbl);
            this.Controls.Add(this.scan_range_from);
            this.Controls.Add(this.scan_range_from_lbl);
            this.Controls.Add(this.scan_value);
            this.Controls.Add(this.scan_value_lbl);
            this.Controls.Add(this.scan_value_ishex);
            this.Controls.Add(this.scan_next);
            this.Controls.Add(this.scan_first);
            this.Controls.Add(this.saved_list);
            this.Controls.Add(this.connect_ip);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.found_list);
            this.Controls.Add(this.strip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.strip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheat Engine for Xbox 360";
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.found_list_context.ResumeLayout(false);
            this.saved_list_context.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip strip;
        private System.Windows.Forms.ToolStripMenuItem strip_file;
        private System.Windows.Forms.ToolStripMenuItem strip_about;
        private System.Windows.Forms.ListView found_list;
        private System.Windows.Forms.ColumnHeader found_list_address;
        private System.Windows.Forms.ColumnHeader found_list_value;
        private System.Windows.Forms.ColumnHeader found_list_previous;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox connect_ip;
        private System.Windows.Forms.ListView saved_list;
        private System.Windows.Forms.ColumnHeader saved_list_address;
        private System.Windows.Forms.ColumnHeader saved_list_description;
        private System.Windows.Forms.ColumnHeader saved_list_type;
        private System.Windows.Forms.ColumnHeader saved_list_value;
        private System.Windows.Forms.Button scan_first;
        private System.Windows.Forms.Button scan_next;
        private System.Windows.Forms.ToolStripMenuItem strip_file_open;
        private System.Windows.Forms.ToolStripMenuItem strip_file_save;
        private System.Windows.Forms.CheckBox scan_value_ishex;
        private System.Windows.Forms.Label scan_value_lbl;
        private System.Windows.Forms.TextBox scan_value;
        private System.Windows.Forms.Label scan_range_from_lbl;
        private System.Windows.Forms.TextBox scan_range_from;
        private System.Windows.Forms.Label scan_range_to_lbl;
        private System.Windows.Forms.TextBox scan_range_to;
        private System.Windows.Forms.ComboBox scan_type;
        private System.Windows.Forms.Label scan_type_lbl;
        private System.Windows.Forms.CheckBox scan_stopwhilescanning;
        private System.Windows.Forms.Button memview;
        private System.Windows.Forms.Button saved_add;
        private System.Windows.Forms.ContextMenuStrip found_list_context;
        private System.Windows.Forms.ContextMenuStrip saved_list_context;
        private System.Windows.Forms.ToolStripMenuItem found_list_context_add;
        private System.Windows.Forms.ToolStripMenuItem found_list_context_browse;
        private System.Windows.Forms.ToolStripMenuItem found_list_context_change;
        private System.Windows.Forms.ToolStripMenuItem found_list_context_remove;
        private System.Windows.Forms.ToolStripMenuItem saved_list_context_edit;
        private System.Windows.Forms.ToolStripMenuItem saved_list_context_remove;
        private System.Windows.Forms.ProgressBar scan_progress;
        private System.Windows.Forms.Button scan_new;
        private System.Windows.Forms.ToolStripMenuItem saved_list_context_change;
        private System.Windows.Forms.ToolStripMenuItem saved_list_context_browse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label refresh_interval_lbl;
        private System.Windows.Forms.NumericUpDown refresh_interval;
        private System.Windows.Forms.CheckBox refresh_do;
    }
}

