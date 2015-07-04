using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_Engine_for_Xbox_360
{
    public partial class EntryForm : Form
    {
        // Constructor
        public EntryForm(string addr = "", string type = "", string description = "")
        {
            InitializeComponent();
            if (description != "")
                Text = "Edit an entry";
            if (type != "")
                entry_type.Enabled = false;
            entry_address.Text = addr;
            entry_description.Text = description;
            entry_type.Text = type;
        }

        // Methods
        private void ok_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(entry_address.Text);
            lvi.SubItems.Add(entry_description.Text);
            lvi.SubItems.Add(entry_type.Text);
            lvi.SubItems.Add("");
            MainForm.extlvi = lvi;
            Close();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}