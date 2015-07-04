#define TESTING

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XeClutch;

namespace Cheat_Engine_for_Xbox_360
{
    public partial class MainForm : Form
    {
        // Variables
        public static PhantomRTM console = new PhantomRTM();
        public static ListViewItem extlvi = null;
        public bool scan_scanning = false;
        public Thread updater;

        // Threads
        private void ValueUpdater()
        {
            while (true)
            {
                if (console.Connected && !scan_scanning && refresh_do.Checked)
                {
                    if (found_list.Items.Count != 0)
                    {
                        string type = scan_type.Text;
                        string val = "";
                        for (int i = 0; i < found_list.Items.Count; i++)
                        {
                            uint addr = uint.Parse(found_list.Items[i].Text.Replace("0x", ""), NumberStyles.HexNumber);
                            if (type == "BYTE") val = console.Read_Byte(addr).ToString("X2");
                            else if (type == "BYTE*") val = ByteArrayToString(console.Read_Byte(addr, (uint)found_list.Items[i].SubItems[2].Text.Length));
                            else if (type == "WORD") val = (scan_value_ishex.Checked ? "0x" + console.Read_UInt16(addr).ToString("X4") : console.Read_UInt16(addr).ToString());
                            else if (type == "DWORD") val = (scan_value_ishex.Checked ? "0x" + console.Read_UInt32(addr).ToString("X8") : console.Read_UInt32(addr).ToString());
                            else if (type == "QWORD") val = (scan_value_ishex.Checked ? "0x" + console.Read_UInt64(addr).ToString("X16") : console.Read_UInt64(addr).ToString());
                            else if (type == "FLOAT") val = console.Read_Float(addr).ToString();
                            else if (type == "DOUBLE") val = console.Read_Double(addr).ToString();
                            else if (type == "STRING") val = console.Read_String(addr, (uint)found_list.Items[i].SubItems[2].Text.Length);
                            found_list.Items[i].SubItems[1].Text = val;
                        }
                    }
                    if (saved_list.Items.Count != 0)
                    {
                        for (int i = 0; i < saved_list.Items.Count; i++)
                        {
                            string type = saved_list.Items[i].SubItems[2].Text;
                            string val = "";
                            uint addr = uint.Parse(saved_list.Items[i].Text.Replace("0x", ""), NumberStyles.HexNumber);
                            if (type == "BYTE") val = console.Read_Byte(addr).ToString("X2");
                            else if (type == "BYTE*") val = ByteArrayToString(console.Read_Byte(addr, uint.Parse(type.Replace("STRING (", "").Replace(")", "")) / 2));
                            else if (type == "WORD") val = (scan_value_ishex.Checked ? "0x" + console.Read_UInt16(addr).ToString("X4") : console.Read_UInt16(addr).ToString());
                            else if (type == "DWORD") val = (scan_value_ishex.Checked ? "0x" + console.Read_UInt32(addr).ToString("X8") : console.Read_UInt32(addr).ToString());
                            else if (type == "QWORD") val = (scan_value_ishex.Checked ? "0x" + console.Read_UInt64(addr).ToString("X16") : console.Read_UInt64(addr).ToString());
                            else if (type == "FLOAT") val = console.Read_Float(addr).ToString();
                            else if (type == "DOUBLE") val = console.Read_Double(addr).ToString();
                            else if (type.StartsWith("STRING")) val = console.Read_String(addr, uint.Parse(type.Replace("STRING (", "").Replace(")", "")));
                            saved_list.Items[i].SubItems[3].Text = val;
                        }
                    }
                }
                Thread.Sleep((int)refresh_interval.Value);
            }
        }

        // Constructor
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            scan_type.SelectedIndex = 1;
            scan_value_ishex.Checked = true;

#if (TESTING)
            found_list.Enabled = true;
            memview.Enabled = true;
            scan_first.Enabled = true;
            scan_range_from.Enabled = true;
            scan_range_to.Enabled = true;
            scan_stopwhilescanning.Enabled = true;
            scan_type.Enabled = true;
            scan_value.Enabled = true;
            saved_add.Enabled = true;
            saved_list.Enabled = true;
#endif

            updater = new Thread(ValueUpdater);
            updater.Start();

            FormClosing += MainForm_FormClosing;
        }

        // Methods
        private string ByteArrayToString(byte[] bytes)
        {
            string str = "";
            foreach (byte b in bytes)
                str += b.ToString("X2");
            return str;
        }
        private byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new StringReader(hex))
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] = Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
            return bytes;
        }
        private void strip_file_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a CT360 file..";
            ofd.Filter = "Cheat Engine 360 Tables (.ct360)|*.ct360";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (saved_list.Items.Count != 0)
                    if (MessageBox.Show("Are you sure? Doing this will clear the current list of saved addresses.", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                saved_list.Items.Clear();
                string[] entries = File.ReadAllLines(ofd.FileName);
                foreach (string entry in entries)
                {
                    string[] columns = entry.Split("|".ToCharArray());
                    uint addr = uint.Parse(columns[0].Replace("0x", ""), NumberStyles.HexNumber);
                    ListViewItem lvi = new ListViewItem(columns[0]);
                    lvi.SubItems.Add(columns[1]);
                    lvi.SubItems.Add(columns[2]);
                    string type = columns[2];
                    string val = "";
                    if (type == "BYTE") val = console.Read_Byte(addr).ToString("X2");
                    else if (type.StartsWith("BYTE*")) val = ByteArrayToString(console.Read_Byte(addr, uint.Parse(type.Replace("BYTE* (", "").Replace(")", ""), NumberStyles.HexNumber)));
                    else if (type == "WORD") val = console.Read_UInt16(addr).ToString();
                    else if (type == "DWORD") val = console.Read_UInt32(addr).ToString();
                    else if (type == "QWORD") val = console.Read_UInt64(addr).ToString();
                    else if (type == "FLOAT") val = console.Read_Float(addr).ToString();
                    else if (type == "DOUBLE") val = console.Read_Double(addr).ToString();
                    else if (type.StartsWith("STRING")) val = console.Read_String(addr, uint.Parse(type.Replace("STRING (", "").Replace(")", ""), NumberStyles.HexNumber));
                    lvi.SubItems.Add(val);
                    saved_list.Items.Add(lvi);
                }
            }
        }
        private void strip_file_save_Click(object sender, EventArgs e)
        {
            if (saved_list.Items.Count == 0)
            {
                MessageBox.Show("You don't have any addresses to save.");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save a CT360 file..";
            sfd.Filter = "Cheat Engine 360 Tables (.ct360)|*.ct360";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string str = "";
                foreach (ListViewItem lvi in saved_list.Items)
                {
                    str += lvi.Text + "|";
                    str += lvi.SubItems[1].Text + "|";
                    str += lvi.SubItems[2].Text + "\n";
                }
                File.WriteAllText(sfd.FileName, str.Replace("\n", Environment.NewLine));
            }
        }
        private void strip_about_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        private void connect_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (IPAddress.TryParse(connect_ip.Text, out ip))
            {
                if (console.Connect(connect_ip.Text))
                {
                    found_list.Enabled = true;
                    memview.Enabled = true;
                    scan_first.Enabled = true;
                    scan_range_from.Enabled = true;
                    scan_range_to.Enabled = true;
                    scan_stopwhilescanning.Enabled = true;
                    scan_type.Enabled = true;
                    scan_value.Enabled = true;
                    scan_value_ishex.Enabled = true;
                    saved_add.Enabled = true;
                    saved_list.Enabled = true;
                }
                else
                {
                    found_list.Enabled = false;
                    memview.Enabled = false;
                    scan_first.Enabled = false;
                    scan_range_from.Enabled = false;
                    scan_range_to.Enabled = false;
                    scan_stopwhilescanning.Enabled = false;
                    scan_type.Enabled = false;
                    scan_value.Enabled = false;
                    scan_value_ishex.Enabled = false;
                    saved_add.Enabled = false;
                    saved_list.Enabled = false;
                }
            }
        }
        private void scan_first_Click(object sender, EventArgs e)
        {
            found_list.Items.Clear();
            scan_progress.Value = 0;
            scan_scanning = true;

            if (scan_stopwhilescanning.Checked)
                console.Debug_Freeze();

            uint addr;
            if (scan_range_from.Text.StartsWith("0x")) addr = uint.Parse(scan_range_from.Text.Replace("0x", ""), NumberStyles.HexNumber);
            else addr = uint.Parse(scan_range_from.Text);

            uint len;
            if (scan_range_to.Text.StartsWith("0x")) len = uint.Parse(scan_range_to.Text.Replace("0x", ""), NumberStyles.HexNumber);
            else len = uint.Parse(scan_range_to.Text);
            scan_progress.Maximum = (int)(len + 1);

            int search_size = 0;
            string search_type = scan_type.Text;
            byte[] search_value = null;
            if (search_type == "BYTE")
            {
                search_size = 1;
                search_value = new byte[] { byte.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber) };
            }
            else if (search_type == "BYTE*")
            {
                if (scan_value.TextLength % 2 != 0)
                    return;
                search_size = scan_value.TextLength / 2;
                search_value = StringToByteArray(scan_value.Text.Replace(" ", ""));
            }
            else if (search_type == "WORD")
            {
                search_size = 2;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(ushort.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(ushort.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "DWORD")
            {
                search_size = 4;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(uint.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(uint.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "QWORD")
            {
                search_size = 8;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(ulong.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(ulong.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "FLOAT")
            {
                search_size = 4;
                search_value = BitConverter.GetBytes(float.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "DOUBLE")
            {
                search_size = 8;
                BitConverter.GetBytes(double.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "STRING")
            {
                search_size = scan_value.TextLength;
                search_value = Encoding.ASCII.GetBytes(scan_value.Text);
            }

            byte[] bytes = console.Read_Byte(addr, len);
            scan_progress.Increment(1);

            int found = 0;
            for (int i = 0; i < (len - search_size); i++)
            {
                byte[] buffer = new byte[search_size];
                Array.Copy(bytes, i, buffer, 0, search_size);
                if (buffer.SequenceEqual(search_value))
                {
                    ListViewItem lvi = new ListViewItem("0x" + (addr + i).ToString("X8"));
                    lvi.SubItems.Add(scan_value.Text);
                    lvi.SubItems.Add(scan_value.Text);
                    found_list.Items.Add(lvi);
                    found++;
                }
                scan_progress.Increment(1);
            }

            if (scan_stopwhilescanning.Checked)
                console.Debug_UnFreeze();

            scan_first.Enabled = false;
            scan_new.Enabled = true;
            scan_next.Enabled = true;
            scan_range_from.Enabled = false;
            scan_range_to.Enabled = false;
            scan_scanning = false;
            scan_type.Enabled = false;

            MessageBox.Show("Successfully found " + found + " matches.");
        }
        private void scan_next_Click(object sender, EventArgs e)
        {
            scan_progress.Value = 0;
            scan_progress.Maximum = (found_list.Items.Count * 2);
            scan_scanning = true;

            if (scan_stopwhilescanning.Checked)
                console.Debug_Freeze();

            ListView.ListViewItemCollection list = found_list.Items;
            found_list.Items.Clear();

            int search_size = 0;
            string search_type = scan_type.Text;
            byte[] search_value = null;
            if (search_type == "BYTE")
            {
                search_size = 1;
                if (scan_value_ishex.Checked) search_value = new byte[] { byte.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber) };
                else search_value = new byte[] { byte.Parse(scan_value.Text) };
            }
            else if (search_type == "BYTE*")
            {
                search_size = scan_value.TextLength / 2;
                search_value = StringToByteArray(scan_value.Text);
            }
            else if (search_type == "WORD")
            {
                search_size = 2;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(ushort.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(ushort.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "DWORD")
            {
                search_size = 4;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(uint.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(uint.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "QWORD")
            {
                search_size = 8;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(ulong.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(ulong.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "FLOAT")
            {
                search_size = 4;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(float.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(float.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "DOUBLE")
            {
                search_size = 8;
                if (scan_value_ishex.Checked) search_value = BitConverter.GetBytes(double.Parse(scan_value.Text.Replace("0x", ""), NumberStyles.HexNumber));
                else search_value = BitConverter.GetBytes(double.Parse(scan_value.Text));
                if (BitConverter.IsLittleEndian) Array.Reverse(search_value);
            }
            else if (search_type == "STRING")
            {
                search_size = scan_value.TextLength;
                search_value = Encoding.ASCII.GetBytes(scan_value.Text);
            }

            int found = 0;
            for (int i = 0; i < list.Count; i++)
            {
                byte[] buffer = console.Read_Byte(uint.Parse(list[i].Text.Replace("0x", ""), NumberStyles.HexNumber), (uint)search_size);
                scan_progress.Increment(1);
                if (buffer.SequenceEqual(search_value))
                {
                    ListViewItem lvi = new ListViewItem(list[i].Text);
                    lvi.SubItems.Add(list[i].SubItems[0].Text);
                    lvi.SubItems.Add(list[i].SubItems[0].Text);
                    found_list.Items.Add(lvi);
                    found++;
                }
                scan_progress.Increment(1);
            }

            if (scan_stopwhilescanning.Checked)
                console.Debug_UnFreeze();

            scan_scanning = false;
            MessageBox.Show("Successfully found " + found + "matches.");
        }
        private void scan_new_Click(object sender, EventArgs e)
        {
            found_list.Items.Clear();
            scan_first.Enabled = true;
            scan_new.Enabled = false;
            scan_next.Enabled = false;
            scan_progress.Value = 0;
            scan_range_from.Enabled = true;
            scan_range_to.Enabled = true;
            scan_type.Enabled = true;
        }
        private void scan_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scan_type.Text.StartsWith("BYTE"))
            {
                scan_value_ishex.Checked = true;
                scan_value_ishex.Enabled = false;
            }
            else if (scan_type.Text == "FLOAT" || scan_type.Text == "DOUBLE")
            {
                scan_value_ishex.Checked = false;
                scan_value_ishex.Enabled = false;
            }
            else
                scan_value_ishex.Enabled = true;
        }
        private void found_list_context_add_Click(object sender, EventArgs e)
        {
            if (found_list.SelectedItems.Count != 1) return;
            if (scan_type.Text == "BYTE*") new EntryForm(found_list.SelectedItems[0].Text, "BYTE* (" + scan_value.TextLength / 2 + ")").ShowDialog();
            else if (scan_type.Text == "STRING") new EntryForm(found_list.SelectedItems[0].Text, "STRING (" + scan_value.TextLength + ")").ShowDialog();
            else new EntryForm(found_list.SelectedItems[0].Text).ShowDialog();
            if (extlvi != null)
            {
                saved_list.Items.Add(extlvi);
                extlvi = null;
            }
        }
        private void found_list_context_browse_Click(object sender, EventArgs e)
        {
            if (found_list.SelectedItems.Count != 1) return;
            new MemoryForm(found_list.SelectedItems[0].Text).ShowDialog();
        }
        private void found_list_context_change_Click(object sender, EventArgs e)
        {
            if (found_list.SelectedItems.Count != 1) return;
            new ChangeValueForm(found_list.SelectedItems[0].Text, scan_type.Text, found_list.SelectedItems[0].SubItems[2].Text, scan_value_ishex.Checked).ShowDialog();
        }
        private void found_list_context_remove_Click(object sender, EventArgs e)
        {
            if (found_list.SelectedItems.Count != 1) return;

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            updater.Abort();
            if (console.Connected) console.Disconnect();
        }
        private void memview_Click(object sender, EventArgs e)
        {
            new MemoryForm().ShowDialog();
        }
        private void saved_list_context_browse_Click(object sender, EventArgs e)
        {
            if (saved_list.SelectedItems.Count != 1) return;
            new MemoryForm(saved_list.SelectedItems[0].Text).ShowDialog();
        }
        private void saved_list_context_change_Click(object sender, EventArgs e)
        {
            if (saved_list.SelectedItems.Count != 1) return;
            new ChangeValueForm(saved_list.SelectedItems[0].Text, saved_list.SelectedItems[0].SubItems[3].Text, saved_list.SelectedItems[0].SubItems[4].Text, (saved_list.SelectedItems[0].SubItems[3].Text.StartsWith("BYTE"))).ShowDialog();
        }
        private void saved_list_context_edit_Click(object sender, EventArgs e)
        {
            if (saved_list.SelectedItems.Count != 1) return;
            new EntryForm(saved_list.SelectedItems[0].Text, saved_list.SelectedItems[0].SubItems[2].Text, saved_list.SelectedItems[0].SubItems[1].Text).ShowDialog();
            if (extlvi != null)
            {
                saved_list.SelectedItems[0].Text = extlvi.Text;
                saved_list.SelectedItems[0].SubItems[1] = extlvi.SubItems[1];
                saved_list.SelectedItems[0].SubItems[2] = extlvi.SubItems[2];
                extlvi = null;
            }
        }
        private void saved_list_context_remove_Click(object sender, EventArgs e)
        {
            if (saved_list.SelectedItems.Count != 1) return;
            if (MessageBox.Show("Are you sure you want to remove this item?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                saved_list.SelectedItems[0].Remove();
        }
        private void saved_add_Click(object sender, EventArgs e)
        {
            new EntryForm().ShowDialog();
            if (extlvi != null)
            {
                saved_list.Items.Add(extlvi);
                extlvi = null;
            }
        }
    }
}

// Chr0m3, stop acting like hot shit you're fucking pathetic.