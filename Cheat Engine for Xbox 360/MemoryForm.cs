using Be.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XeClutch;

namespace Cheat_Engine_for_Xbox_360
{
    public partial class MemoryForm : Form
    {
        // Constructor
        public MemoryForm(string addr = "")
        {
            InitializeComponent();
            conversions_float.Maximum = Convert.ToDecimal(decimal.MaxValue);
            conversions_float.Minimum = Convert.ToDecimal(decimal.MinValue);
            conversions_double.Maximum = Convert.ToDecimal(decimal.MaxValue);
            conversions_double.Minimum = Convert.ToDecimal(decimal.MinValue);

            memory.KeyDown += memory_KeyDown;
            memory.SelectionStartChanged += memory_SelectionStartChanged;

            if (addr != "")
            {
                peekpoke_address.Text = addr;
                peekpoke_peek_Click(0, new EventArgs());
            }
        }

        // Methods
        private void peekpoke_peek_Click(object sender, EventArgs e)
        {
            uint addr = uint.Parse(peekpoke_address.Text.Replace("0x", ""), NumberStyles.HexNumber);
            uint len = peekpoke_len.Text.StartsWith("0x") ? uint.Parse(peekpoke_len.Text.Replace("0x", ""), NumberStyles.HexNumber) : uint.Parse(peekpoke_len.Text);
            byte[] bytes = MainForm.console.Read_Byte(addr, len + 1);

            memory.ByteProvider = new DynamicByteProvider(bytes);
            memory.Refresh();

            peekpoke_poke.Enabled = true;
            peekpoke_new.Enabled = true;
        }
        private void peekpoke_poke_Click(object sender, EventArgs e)
        {
            uint addr = uint.Parse(peekpoke_address.Text.Replace("0x", ""), NumberStyles.HexNumber);
            DynamicByteProvider provider = (DynamicByteProvider)memory.ByteProvider;
            byte[] bytes = provider.Bytes.ToArray();

            MainForm.console.Write_Byte(addr, bytes);
        }
        private void peekpoke_new_Click(object sender, EventArgs e)
        {
            conversions_word.Value = 0;
            conversions_dword.Value = 0;
            conversions_qword.Value = 0;
            conversions_float.Value = 0;
            conversions_double.Value = 0;
            memory.ByteProvider = null;
            memory.Refresh();
            peekpoke_address.Text = "0x82000000";
            peekpoke_len.Text = "0xFF";
            peekpoke_poke.Enabled = false;
            peekpoke_new.Enabled = false;
            selectedaddress.Text = "Selected Address: 0x82000000";
        }
        private void memory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                memory.CopyHex();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                memory.PasteHex();
                e.SuppressKeyPress = true;
            }
        }
        private void memory_SelectionStartChanged(object sender, EventArgs e)
        {
            selectedaddress.Text = "Selected Address: 0x" + (uint.Parse(peekpoke_address.Text.Replace("0x", ""), NumberStyles.HexNumber) + memory.SelectionStart).ToString("X8");

            DynamicByteProvider provider = (DynamicByteProvider)memory.ByteProvider;
            byte[] bytes = provider.Bytes.ToArray();

            if ((bytes.Length - memory.SelectionStart) > 1)
            {
                try
                {
                    byte[] buffer = new byte[2];
                    Array.Copy(bytes, memory.SelectionStart, buffer, 0, 2);
                    if (BitConverter.IsLittleEndian) Array.Reverse(buffer);
                    conversions_word.Value = (decimal)BitConverter.ToUInt16(buffer, 0);
                }
                catch
                {
                    conversions_word.Value = 0;
                }
            }
            if ((bytes.Length - memory.SelectionStart) > 3)
            {
                try
                {
                    byte[] buffer = new byte[4];
                    Array.Copy(bytes, memory.SelectionStart, buffer, 0, 4);
                    if (BitConverter.IsLittleEndian) Array.Reverse(buffer);
                    conversions_dword.Value = (decimal)BitConverter.ToUInt32(buffer, 0);
                }
                catch
                {
                    conversions_dword.Value = 0;
                }
            }
            if ((bytes.Length - memory.SelectionStart) > 7)
            {
                try
                {
                    byte[] buffer = new byte[8];
                    Array.Copy(bytes, memory.SelectionStart, buffer, 0, 8);
                    if (BitConverter.IsLittleEndian) Array.Reverse(buffer);
                    conversions_qword.Value = (decimal)BitConverter.ToUInt64(buffer, 0);
                }
                catch
                {
                    conversions_qword.Value = 0;
                }
            }
            if ((bytes.Length - memory.SelectionStart) > 3)
            {
                try
                {
                    byte[] buffer = new byte[4];
                    Array.Copy(bytes, memory.SelectionStart, buffer, 0, 4);
                    if (BitConverter.IsLittleEndian) Array.Reverse(buffer);
                    conversions_float.Value = (decimal)BitConverter.ToSingle(buffer, 0);
                }
                catch
                {
                    conversions_float.Value = 0;
                }
            }
            if ((bytes.Length - memory.SelectionStart) > 7)
            {
                try
                {
                    byte[] buffer = new byte[8];
                    Array.Copy(bytes, memory.SelectionStart, buffer, 0, 8);
                    if (BitConverter.IsLittleEndian) Array.Reverse(buffer);
                    conversions_double.Value = (decimal)BitConverter.ToDouble(buffer, 0);
                }
                catch
                {
                    conversions_double.Value = 0;
                }
            }
        }
    }
}
