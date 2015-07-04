using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_Engine_for_Xbox_360
{
    public partial class AboutForm : Form
    {
        // Constructor
        public AboutForm()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:\Program Files (x86)\Microsoft Xbox 360 SDK\"))
            {
                neighborhood.Text = "Your system does not support Xbox 360 Neighborhood";
                neighborhood.ForeColor = Color.Red;
            }
        }

        // Methods
        private void link_donate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Donations are not necessary by any means and by donating you agree that you're donating out of your own free-will.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Thank you very much for the generosity but please don't go over board and send me too much.\nIf you'd like to add a note to the payment with your Skype info I'll gladly add you on Skype.");
                Process.Start("https://www.paypal.com/xclick/business=team_phantom%40aol.com&no_note=0&tax=0&lc=US");
            }
        }
        private void link_pastebin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.pastebin.com/u/IAmXeClutch");
        }
        private void link_se7ensins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.se7ensins.com/members/xeclutch.502472/");
        }
    }
}