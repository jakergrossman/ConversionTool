using System.Numerics;

namespace ConversionTool
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
            binaryEntries = new TextBox[8] {
                binaryByte1Entry,
                binaryByte2Entry,
                binaryByte3Entry,
                binaryByte4Entry,
                binaryByte5Entry,
                binaryByte6Entry,
                binaryByte7Entry,
                binaryByte8Entry
            };
            bitWidthBox.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void OnBitWidthSelect(object sender, EventArgs e)
        {
            byte width = Convert.ToByte(bitWidthBox.Text);
            byte numBytes = (byte)(width / 8);

            for (int i = 0; i < binaryEntries.Length; i++)
            {
                bool enabled = i < numBytes;
                if (!enabled)
                {
                    binaryEntries[i].Text = "";
                }
            }

            ValueChanged(this.Controls.Find(lastModified, false)[0], null);
        }

        private void OnReset(object sender, EventArgs e)
        {
            signedIntEntry.Text = "";
            unsignedIntEntry.Text = "";
            hexEntry.Text = "";
            FillBinary(0);
        }

        private void FillBinary(UInt64 value)
        {
            byte width = Convert.ToByte(bitWidthBox.Text);
            byte numBytes = (byte)(width / 8);
            for (int i = 0; i < numBytes; i++)
            {
                byte b = (byte)value;
                char[] cs = new char[8];
                for (int j = 0; j < 8; j++)
                {
                    if ((b & (1 << j)) != 0)
                    {
                        cs[7 - j] = '1';
                    }
                    else
                    {
                        cs[7 - j] = '0';
                    }
                }

                binaryEntries[i].Text = new string(cs);
                value >>= 8;
            }
        }

        private void ValueChanged(object sender, EventArgs? e)
        {
            if (lockChange) return;
            lockChange = true;
            Control c = (Control)sender;
            byte bitWidth = Convert.ToByte(bitWidthBox.Text);
            UInt64 mask = bitWidth == 64 ? 0xFFFFFFFFFFFFFFFF : ((ulong)1 << bitWidth) - (ulong)1;
            string name = c.Name;

            if (c.Text == "")
            {
                signedIntEntry.Text = "";
                unsignedIntEntry.Text = "";
                hexEntry.Text = "";
                FillBinary(0);
                c.BackColor = Color.White;
                lockChange = false;
                return;
            }

            try
            {
                if (name == "signedIntEntry")
                {
                    Int64 sValue = Convert.ToInt64(c.Text);
                    if (sValue > (Math.Pow(2, bitWidth - 1) - 1))
                    {
                        throw new Exception();
                    }
                    UInt64 uValue = unchecked((UInt64)sValue) & mask;
                    string hex = "0x" + uValue.ToString("X");

                    unsignedIntEntry.Text = uValue.ToString("d");
                    hexEntry.Text = hex;
                    FillBinary(uValue);
                }
                else
                {
                    UInt64 uValue = Convert.ToUInt64(c.Text, name == "unsignedIntEntry" ? 10 : 16);
                    if (uValue > (Math.Pow(2, bitWidth) - 1))
                    {
                        throw new Exception();
                    }

                    uValue &= mask;

                    Int64 sValue = 0;
                    switch (bitWidth)
                    {
                        case 8:
                            sValue = unchecked((sbyte)(uValue & 0xFF));
                            break;
                        case 16:
                            sValue = unchecked((Int16)(uValue & 0xFFFF));
                            break;
                        case 32:
                            sValue = unchecked((Int32)(uValue & 0xFFFFFFFF));
                            break;
                        case 64:
                            sValue = unchecked((Int64)uValue);
                            break;
                    }

                    if (name == "hexEntry")
                    {
                        unsignedIntEntry.Text = uValue.ToString("d");
                    } else
                    {
                        string hex = "0x" + uValue.ToString("X");
                        hexEntry.Text = hex;
                    }

                    signedIntEntry.Text = sValue.ToString("d");
                    FillBinary(uValue);
                }

                c.BackColor = Color.White;
            }
            catch { 
                c.BackColor = Color.LightPink;
            }
            lastModified = name;
            lockChange = false;
        }

        private void Copy(object sender, EventArgs e)
        {
            string? text = null;
            switch (((Control) sender).Name)
            {
                case "copySignedBtn":
                    text = signedIntEntry.Text;
                    break;
                case "copyUnsignedBtn":
                    text = unsignedIntEntry.Text;
                    break;
                case "copyHexBtn":
                    text = hexEntry.Text;
                    break;
            }

            if (text != null && text.Length > 0)
            {
                Clipboard.SetText(text);
            }
        }

        private void OnCheckChange(object sender, EventArgs e)
        {
            if (pinCheckBox.Checked)
            {
                Form.ActiveForm.TopMost = true;
            }
            else
            {

                Form.ActiveForm.TopMost = false;
            }
        }
    }
}