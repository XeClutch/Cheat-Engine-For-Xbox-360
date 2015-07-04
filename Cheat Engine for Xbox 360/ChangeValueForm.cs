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
    public partial class ChangeValueForm : Form
    {
        // Variables
        uint address;
        string datatype;

        // Constructor
        public ChangeValueForm(string addr, string type, string value, bool hex = false)
        {
            InitializeComponent();
            Text += addr;
            newvalue.Text = value;
            newvalue_ishex.Checked = hex;

            address = uint.Parse(addr.Replace("0x", ""), NumberStyles.HexNumber);
            datatype = type;
        }

        // Methods
        private byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new StringReader(hex))
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] = Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
            return bytes;
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (datatype == "BYTE") MainForm.console.Write_Byte(address, newvalue_ishex.Checked ? byte.Parse(newvalue.Text, NumberStyles.HexNumber) : byte.Parse(newvalue.Text));
            else if (datatype == "BYTE*") MainForm.console.Write_Byte(address, StringToByteArray(newvalue.Text));
            else if (datatype == "WORD") MainForm.console.Write_UInt16(address, newvalue_ishex.Checked ? ushort.Parse(newvalue.Text, NumberStyles.HexNumber) : ushort.Parse(newvalue.Text));
            else if (datatype == "DWORD") MainForm.console.Write_UInt32(address, newvalue_ishex.Checked ? uint.Parse(newvalue.Text, NumberStyles.HexNumber) : uint.Parse(newvalue.Text));
            else if (datatype == "QWORD") MainForm.console.Write_UInt64(address, newvalue_ishex.Checked ? ulong.Parse(newvalue.Text, NumberStyles.HexNumber) : ulong.Parse(newvalue.Text));
            else if (datatype == "FLOAT") MainForm.console.Write_Float(address, float.Parse(newvalue.Text));
            else if (datatype == "DOUBLE") MainForm.console.Write_Double(address, double.Parse(newvalue.Text));
            else if (datatype == "STRING") MainForm.console.Write_String(address, newvalue.Text);
            Close();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}