namespace Cheat_Engine_for_Xbox_360
{
    partial class ChangeValueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeValueForm));
            this.newvalue = new System.Windows.Forms.TextBox();
            this.newvalue_lbl = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.newvalue_ishex = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // newvalue
            // 
            this.newvalue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.newvalue.Location = new System.Drawing.Point(54, 12);
            this.newvalue.Name = "newvalue";
            this.newvalue.Size = new System.Drawing.Size(246, 20);
            this.newvalue.TabIndex = 0;
            // 
            // newvalue_lbl
            // 
            this.newvalue_lbl.AutoSize = true;
            this.newvalue_lbl.Location = new System.Drawing.Point(12, 15);
            this.newvalue_lbl.Name = "newvalue_lbl";
            this.newvalue_lbl.Size = new System.Drawing.Size(36, 13);
            this.newvalue_lbl.TabIndex = 1;
            this.newvalue_lbl.Text = "Value";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(222, 55);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(57, 23);
            this.ok.TabIndex = 9;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(285, 55);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(57, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // newvalue_ishex
            // 
            this.newvalue_ishex.AutoSize = true;
            this.newvalue_ishex.Location = new System.Drawing.Point(306, 14);
            this.newvalue_ishex.Name = "newvalue_ishex";
            this.newvalue_ishex.Size = new System.Drawing.Size(45, 17);
            this.newvalue_ishex.TabIndex = 10;
            this.newvalue_ishex.Text = "Hex";
            this.newvalue_ishex.UseVisualStyleBackColor = true;
            // 
            // ChangeValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 90);
            this.Controls.Add(this.newvalue_ishex);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.newvalue_lbl);
            this.Controls.Add(this.newvalue);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeValueForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change value of ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newvalue;
        private System.Windows.Forms.Label newvalue_lbl;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.CheckBox newvalue_ishex;
    }
}