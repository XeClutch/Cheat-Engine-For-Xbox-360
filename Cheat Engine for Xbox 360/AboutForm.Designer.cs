namespace Cheat_Engine_for_Xbox_360
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.neighborhood = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link_se7ensins = new System.Windows.Forms.LinkLabel();
            this.link_pastebin = new System.Windows.Forms.LinkLabel();
            this.link_donate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.neighborhood);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.link_se7ensins);
            this.groupBox1.Controls.Add(this.link_pastebin);
            this.groupBox1.Controls.Add(this.link_donate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheat Engine for Xbox 360 1.0";
            // 
            // neighborhood
            // 
            this.neighborhood.AutoSize = true;
            this.neighborhood.ForeColor = System.Drawing.Color.Green;
            this.neighborhood.Location = new System.Drawing.Point(12, 227);
            this.neighborhood.Name = "neighborhood";
            this.neighborhood.Size = new System.Drawing.Size(248, 13);
            this.neighborhood.TabIndex = 1;
            this.neighborhood.Text = "Your system supports Xbox 360 Neighborhood.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 72);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thanks to:\r\n\r\nCraigChrist8239, Godly, Xx jAmes t xX, XBLToothpik, Hybrii, Cakes\r\n" +
    "\r\nAnd all the other people that pushed me to do better.";
            // 
            // link_se7ensins
            // 
            this.link_se7ensins.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link_se7ensins.AutoSize = true;
            this.link_se7ensins.LinkColor = System.Drawing.Color.Blue;
            this.link_se7ensins.Location = new System.Drawing.Point(139, 76);
            this.link_se7ensins.Name = "link_se7ensins";
            this.link_se7ensins.Size = new System.Drawing.Size(59, 13);
            this.link_se7ensins.TabIndex = 4;
            this.link_se7ensins.TabStop = true;
            this.link_se7ensins.Text = "Se7enSins";
            this.link_se7ensins.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_se7ensins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_se7ensins_LinkClicked);
            // 
            // link_pastebin
            // 
            this.link_pastebin.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link_pastebin.AutoSize = true;
            this.link_pastebin.LinkColor = System.Drawing.Color.Blue;
            this.link_pastebin.Location = new System.Drawing.Point(139, 54);
            this.link_pastebin.Name = "link_pastebin";
            this.link_pastebin.Size = new System.Drawing.Size(51, 13);
            this.link_pastebin.TabIndex = 3;
            this.link_pastebin.TabStop = true;
            this.link_pastebin.Text = "Pastebin";
            this.link_pastebin.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_pastebin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pastebin_LinkClicked);
            // 
            // link_donate
            // 
            this.link_donate.Location = new System.Drawing.Point(275, 21);
            this.link_donate.Name = "link_donate";
            this.link_donate.Size = new System.Drawing.Size(87, 23);
            this.link_donate.TabIndex = 2;
            this.link_donate.Text = "Donate";
            this.link_donate.UseVisualStyleBackColor = true;
            this.link_donate.Click += new System.EventHandler(this.link_donate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Made by: XeClutch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 246);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Cheat Engine for Xbox 360";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_se7ensins;
        private System.Windows.Forms.LinkLabel link_pastebin;
        private System.Windows.Forms.Button link_donate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label neighborhood;
    }
}