namespace Cheat_Engine_for_Xbox_360
{
    partial class MemoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryForm));
            this.memory = new Be.Windows.Forms.HexBox();
            this.memory_lbl = new System.Windows.Forms.Label();
            this.conversions = new System.Windows.Forms.GroupBox();
            this.conversions_double_lbl = new System.Windows.Forms.Label();
            this.conversions_double = new System.Windows.Forms.NumericUpDown();
            this.conversions_float_lbl = new System.Windows.Forms.Label();
            this.conversions_float = new System.Windows.Forms.NumericUpDown();
            this.conversions_qword_lbl = new System.Windows.Forms.Label();
            this.conversions_qword = new System.Windows.Forms.NumericUpDown();
            this.conversions_dword_lbl = new System.Windows.Forms.Label();
            this.conversions_dword = new System.Windows.Forms.NumericUpDown();
            this.conversions_word_lbl = new System.Windows.Forms.Label();
            this.conversions_word = new System.Windows.Forms.NumericUpDown();
            this.peekpoke = new System.Windows.Forms.GroupBox();
            this.peekpoke_new = new System.Windows.Forms.Button();
            this.peekpoke_poke = new System.Windows.Forms.Button();
            this.peekpoke_peek = new System.Windows.Forms.Button();
            this.peekpoke_len = new System.Windows.Forms.TextBox();
            this.peekpoke_len_lbl = new System.Windows.Forms.Label();
            this.peekpoke_address = new System.Windows.Forms.TextBox();
            this.peekpoke_address_lbl = new System.Windows.Forms.Label();
            this.selectedaddress = new System.Windows.Forms.Label();
            this.conversions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_float)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_qword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_dword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_word)).BeginInit();
            this.peekpoke.SuspendLayout();
            this.SuspendLayout();
            // 
            // memory
            // 
            this.memory.Font = new System.Drawing.Font("Courier New", 9F);
            this.memory.InfoForeColor = System.Drawing.Color.Black;
            this.memory.LineInfoVisible = true;
            this.memory.Location = new System.Drawing.Point(17, 28);
            this.memory.Name = "memory";
            this.memory.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.memory.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.memory.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.memory.Size = new System.Drawing.Size(636, 302);
            this.memory.StringViewVisible = true;
            this.memory.TabIndex = 0;
            this.memory.UseFixedBytesPerLine = true;
            this.memory.VScrollBarVisible = true;
            // 
            // memory_lbl
            // 
            this.memory_lbl.AutoSize = true;
            this.memory_lbl.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.memory_lbl.Location = new System.Drawing.Point(12, 9);
            this.memory_lbl.Name = "memory_lbl";
            this.memory_lbl.Size = new System.Drawing.Size(472, 16);
            this.memory_lbl.TabIndex = 1;
            this.memory_lbl.Text = "           00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // conversions
            // 
            this.conversions.Controls.Add(this.conversions_double_lbl);
            this.conversions.Controls.Add(this.conversions_double);
            this.conversions.Controls.Add(this.conversions_float_lbl);
            this.conversions.Controls.Add(this.conversions_float);
            this.conversions.Controls.Add(this.conversions_qword_lbl);
            this.conversions.Controls.Add(this.conversions_qword);
            this.conversions.Controls.Add(this.conversions_dword_lbl);
            this.conversions.Controls.Add(this.conversions_dword);
            this.conversions.Controls.Add(this.conversions_word_lbl);
            this.conversions.Controls.Add(this.conversions_word);
            this.conversions.Location = new System.Drawing.Point(659, 159);
            this.conversions.Name = "conversions";
            this.conversions.Size = new System.Drawing.Size(202, 154);
            this.conversions.TabIndex = 2;
            this.conversions.TabStop = false;
            this.conversions.Text = "Conversions";
            // 
            // conversions_double_lbl
            // 
            this.conversions_double_lbl.AutoSize = true;
            this.conversions_double_lbl.Location = new System.Drawing.Point(6, 129);
            this.conversions_double_lbl.Name = "conversions_double_lbl";
            this.conversions_double_lbl.Size = new System.Drawing.Size(50, 13);
            this.conversions_double_lbl.TabIndex = 12;
            this.conversions_double_lbl.Text = "DOUBLE";
            // 
            // conversions_double
            // 
            this.conversions_double.DecimalPlaces = 16;
            this.conversions_double.Enabled = false;
            this.conversions_double.Location = new System.Drawing.Point(62, 127);
            this.conversions_double.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.conversions_double.Minimum = new decimal(new int[] {
            0,
            -2147483648,
            0,
            -2147483648});
            this.conversions_double.Name = "conversions_double";
            this.conversions_double.Size = new System.Drawing.Size(134, 22);
            this.conversions_double.TabIndex = 11;
            // 
            // conversions_float_lbl
            // 
            this.conversions_float_lbl.AutoSize = true;
            this.conversions_float_lbl.Location = new System.Drawing.Point(6, 101);
            this.conversions_float_lbl.Name = "conversions_float_lbl";
            this.conversions_float_lbl.Size = new System.Drawing.Size(39, 13);
            this.conversions_float_lbl.TabIndex = 10;
            this.conversions_float_lbl.Text = "FLOAT";
            // 
            // conversions_float
            // 
            this.conversions_float.DecimalPlaces = 8;
            this.conversions_float.Enabled = false;
            this.conversions_float.Location = new System.Drawing.Point(62, 99);
            this.conversions_float.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.conversions_float.Minimum = new decimal(new int[] {
            0,
            -2147483648,
            0,
            -2147483648});
            this.conversions_float.Name = "conversions_float";
            this.conversions_float.Size = new System.Drawing.Size(134, 22);
            this.conversions_float.TabIndex = 9;
            // 
            // conversions_qword_lbl
            // 
            this.conversions_qword_lbl.AutoSize = true;
            this.conversions_qword_lbl.Location = new System.Drawing.Point(6, 73);
            this.conversions_qword_lbl.Name = "conversions_qword_lbl";
            this.conversions_qword_lbl.Size = new System.Drawing.Size(50, 13);
            this.conversions_qword_lbl.TabIndex = 8;
            this.conversions_qword_lbl.Text = "QWORD";
            // 
            // conversions_qword
            // 
            this.conversions_qword.Enabled = false;
            this.conversions_qword.Location = new System.Drawing.Point(62, 71);
            this.conversions_qword.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.conversions_qword.Minimum = new decimal(new int[] {
            0,
            -2147483648,
            0,
            -2147483648});
            this.conversions_qword.Name = "conversions_qword";
            this.conversions_qword.Size = new System.Drawing.Size(134, 22);
            this.conversions_qword.TabIndex = 7;
            // 
            // conversions_dword_lbl
            // 
            this.conversions_dword_lbl.AutoSize = true;
            this.conversions_dword_lbl.Location = new System.Drawing.Point(6, 45);
            this.conversions_dword_lbl.Name = "conversions_dword_lbl";
            this.conversions_dword_lbl.Size = new System.Drawing.Size(50, 13);
            this.conversions_dword_lbl.TabIndex = 6;
            this.conversions_dword_lbl.Text = "DWORD";
            // 
            // conversions_dword
            // 
            this.conversions_dword.Enabled = false;
            this.conversions_dword.Location = new System.Drawing.Point(62, 43);
            this.conversions_dword.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.conversions_dword.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.conversions_dword.Name = "conversions_dword";
            this.conversions_dword.Size = new System.Drawing.Size(134, 22);
            this.conversions_dword.TabIndex = 5;
            // 
            // conversions_word_lbl
            // 
            this.conversions_word_lbl.AutoSize = true;
            this.conversions_word_lbl.Location = new System.Drawing.Point(6, 17);
            this.conversions_word_lbl.Name = "conversions_word_lbl";
            this.conversions_word_lbl.Size = new System.Drawing.Size(42, 13);
            this.conversions_word_lbl.TabIndex = 4;
            this.conversions_word_lbl.Text = "WORD";
            // 
            // conversions_word
            // 
            this.conversions_word.Enabled = false;
            this.conversions_word.Location = new System.Drawing.Point(62, 15);
            this.conversions_word.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.conversions_word.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.conversions_word.Name = "conversions_word";
            this.conversions_word.Size = new System.Drawing.Size(134, 22);
            this.conversions_word.TabIndex = 3;
            // 
            // peekpoke
            // 
            this.peekpoke.Controls.Add(this.peekpoke_new);
            this.peekpoke.Controls.Add(this.peekpoke_poke);
            this.peekpoke.Controls.Add(this.peekpoke_peek);
            this.peekpoke.Controls.Add(this.peekpoke_len);
            this.peekpoke.Controls.Add(this.peekpoke_len_lbl);
            this.peekpoke.Controls.Add(this.peekpoke_address);
            this.peekpoke.Controls.Add(this.peekpoke_address_lbl);
            this.peekpoke.Location = new System.Drawing.Point(659, 9);
            this.peekpoke.Name = "peekpoke";
            this.peekpoke.Size = new System.Drawing.Size(202, 144);
            this.peekpoke.TabIndex = 3;
            this.peekpoke.TabStop = false;
            this.peekpoke.Text = "Peek Poke";
            // 
            // peekpoke_new
            // 
            this.peekpoke_new.Enabled = false;
            this.peekpoke_new.Location = new System.Drawing.Point(6, 118);
            this.peekpoke_new.Name = "peekpoke_new";
            this.peekpoke_new.Size = new System.Drawing.Size(190, 20);
            this.peekpoke_new.TabIndex = 21;
            this.peekpoke_new.Text = "New";
            this.peekpoke_new.UseVisualStyleBackColor = true;
            this.peekpoke_new.Click += new System.EventHandler(this.peekpoke_new_Click);
            // 
            // peekpoke_poke
            // 
            this.peekpoke_poke.Enabled = false;
            this.peekpoke_poke.Location = new System.Drawing.Point(6, 97);
            this.peekpoke_poke.Name = "peekpoke_poke";
            this.peekpoke_poke.Size = new System.Drawing.Size(190, 20);
            this.peekpoke_poke.TabIndex = 20;
            this.peekpoke_poke.Text = "Poke";
            this.peekpoke_poke.UseVisualStyleBackColor = true;
            this.peekpoke_poke.Click += new System.EventHandler(this.peekpoke_poke_Click);
            // 
            // peekpoke_peek
            // 
            this.peekpoke_peek.Location = new System.Drawing.Point(6, 76);
            this.peekpoke_peek.Name = "peekpoke_peek";
            this.peekpoke_peek.Size = new System.Drawing.Size(190, 20);
            this.peekpoke_peek.TabIndex = 19;
            this.peekpoke_peek.Text = "Peek";
            this.peekpoke_peek.UseVisualStyleBackColor = true;
            this.peekpoke_peek.Click += new System.EventHandler(this.peekpoke_peek_Click);
            // 
            // peekpoke_len
            // 
            this.peekpoke_len.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.peekpoke_len.Location = new System.Drawing.Point(62, 50);
            this.peekpoke_len.MaxLength = 10;
            this.peekpoke_len.Name = "peekpoke_len";
            this.peekpoke_len.Size = new System.Drawing.Size(134, 20);
            this.peekpoke_len.TabIndex = 18;
            this.peekpoke_len.Text = "0xFF";
            // 
            // peekpoke_len_lbl
            // 
            this.peekpoke_len_lbl.AutoSize = true;
            this.peekpoke_len_lbl.Location = new System.Drawing.Point(11, 53);
            this.peekpoke_len_lbl.Name = "peekpoke_len_lbl";
            this.peekpoke_len_lbl.Size = new System.Drawing.Size(43, 13);
            this.peekpoke_len_lbl.TabIndex = 17;
            this.peekpoke_len_lbl.Text = "Length";
            // 
            // peekpoke_address
            // 
            this.peekpoke_address.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.peekpoke_address.Location = new System.Drawing.Point(62, 21);
            this.peekpoke_address.MaxLength = 10;
            this.peekpoke_address.Name = "peekpoke_address";
            this.peekpoke_address.Size = new System.Drawing.Size(134, 20);
            this.peekpoke_address.TabIndex = 16;
            this.peekpoke_address.Text = "0x82000000";
            // 
            // peekpoke_address_lbl
            // 
            this.peekpoke_address_lbl.AutoSize = true;
            this.peekpoke_address_lbl.Location = new System.Drawing.Point(6, 24);
            this.peekpoke_address_lbl.Name = "peekpoke_address_lbl";
            this.peekpoke_address_lbl.Size = new System.Drawing.Size(48, 13);
            this.peekpoke_address_lbl.TabIndex = 15;
            this.peekpoke_address_lbl.Text = "Address";
            // 
            // selectedaddress
            // 
            this.selectedaddress.AutoSize = true;
            this.selectedaddress.Location = new System.Drawing.Point(656, 316);
            this.selectedaddress.Name = "selectedaddress";
            this.selectedaddress.Size = new System.Drawing.Size(159, 13);
            this.selectedaddress.TabIndex = 14;
            this.selectedaddress.Text = "Selected Address: 0x82000000";
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 338);
            this.Controls.Add(this.selectedaddress);
            this.Controls.Add(this.peekpoke);
            this.Controls.Add(this.conversions);
            this.Controls.Add(this.memory_lbl);
            this.Controls.Add(this.memory);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory View";
            this.conversions.ResumeLayout(false);
            this.conversions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_float)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_qword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_dword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversions_word)).EndInit();
            this.peekpoke.ResumeLayout(false);
            this.peekpoke.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Be.Windows.Forms.HexBox memory;
        private System.Windows.Forms.Label memory_lbl;
        private System.Windows.Forms.GroupBox conversions;
        private System.Windows.Forms.Label conversions_double_lbl;
        private System.Windows.Forms.NumericUpDown conversions_double;
        private System.Windows.Forms.Label conversions_float_lbl;
        private System.Windows.Forms.NumericUpDown conversions_float;
        private System.Windows.Forms.Label conversions_qword_lbl;
        private System.Windows.Forms.NumericUpDown conversions_qword;
        private System.Windows.Forms.Label conversions_dword_lbl;
        private System.Windows.Forms.NumericUpDown conversions_dword;
        private System.Windows.Forms.Label conversions_word_lbl;
        private System.Windows.Forms.NumericUpDown conversions_word;
        private System.Windows.Forms.GroupBox peekpoke;
        private System.Windows.Forms.TextBox peekpoke_len;
        private System.Windows.Forms.Label peekpoke_len_lbl;
        private System.Windows.Forms.TextBox peekpoke_address;
        private System.Windows.Forms.Label peekpoke_address_lbl;
        private System.Windows.Forms.Button peekpoke_new;
        private System.Windows.Forms.Button peekpoke_poke;
        private System.Windows.Forms.Button peekpoke_peek;
        private System.Windows.Forms.Label selectedaddress;
    }
}