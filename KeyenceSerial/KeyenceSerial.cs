using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using LibConnection;
using LibConnection.Profinet.Keyence;

namespace KeyenceSerial
{
    public partial class KeyenceSerial : Form
    {
        private KeyenceNanoSerial NanoSerial;
        public KeyenceSerial()
        {
            InitializeComponent();
        }

        private void KeyenceSerial_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPort.DataSource = ports;
            cmbBaudrate.SelectedIndex = 0;
        }
        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            NanoSerial = new KeyenceNanoSerial();
            NanoSerial.SerialPortInni(sp =>
            {
                sp.PortName = cmbPort.Text;
                sp.BaudRate = int.Parse(cmbBaudrate.Text);
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.Parity = Parity.Even;
            });
            OperateResult ret = NanoSerial.Open();
            if (ret.IsSuccess)
            {
                btnOpen.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            NanoSerial.Close();
            btnOpen.Enabled = true;
        }

        private void BIT_M0_CheckedChanged(object sender, System.EventArgs e)
        {
            if (BIT_M0.Checked)
            {
                OperateResult ret = NanoSerial.Write("MR0", true);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
            else
            {
                OperateResult ret = NanoSerial.Write("MR0", false);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
        }

        private void btnWriteBit_Click(object sender, System.EventArgs e)
        {
            // Not Support
            bool[] data = new bool[] { true, false, true, false, true };
            OperateResult ret = NanoSerial.Write("MR0", data);
            if (ret.IsSuccess) MessageBox.Show("Successful!");
        }

        private void btnReadBit_Click(object sender, System.EventArgs e)
        {
            bool ret = NanoSerial.ReadBool("MR0").Content;
            MessageBox.Show($"{ret}");
        }

        private void btnRead_Click(object sender, System.EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Int16":
                    Int16[] int16 = NanoSerial.ReadInt16(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num16 = int.Parse(txtAddr.Text.Substring(2, txtAddr.Text.Length - 2));
                    string text16 = txtAddr.Text.Substring(0, 2);
                    for (int i = 0; i < int16.Length; i++)
                    {
                        txtResult.AppendText($"[{text16}{num16}] = {int16[i]}\r\n");
                        ++num16;
                    }
                    break;
                case "Int32":
                    Int32[] int32 = NanoSerial.ReadInt32(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num32 = int.Parse(txtAddr.Text.Substring(2, txtAddr.Text.Length - 2));
                    string text32 = txtAddr.Text.Substring(0, 2);
                    for (int i = 0; i < int32.Length; i++)
                    {
                        txtResult.AppendText($"[{text32}{num32}] = {int32[i]}\r\n");
                        num32 += 2;
                    }
                    break;
                case "Int64":
                    Int64[] int64 = NanoSerial.ReadInt64(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num64 = int.Parse(txtAddr.Text.Substring(2, txtAddr.Text.Length - 2));
                    string text64 = txtAddr.Text.Substring(0, 2);
                    for (int i = 0; i < int64.Length; i++)
                    {
                        txtResult.AppendText($"[{text64}{num64}] = {int64[i]}\r\n");
                        num64 += 4;
                    }
                    break;
                case "Float":
                    float[] f_val = NanoSerial.ReadFloat(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num_f = int.Parse(txtAddr.Text.Substring(2, txtAddr.Text.Length - 2));
                    string text_f = txtAddr.Text.Substring(0, 2);
                    for (int i = 0; i < f_val.Length; i++)
                    {
                        txtResult.AppendText($"[{text_f}{num_f}] = {f_val[i]}\r\n");
                        num_f += 2;
                    }
                    break;
                case "Double":
                    double[] d_val = NanoSerial.ReadDouble(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num_d = int.Parse(txtAddr.Text.Substring(2, txtAddr.Text.Length - 2));
                    string text_d = txtAddr.Text.Substring(0, 2);
                    for (int i = 0; i < d_val.Length; i++)
                    {
                        txtResult.AppendText($"[{text_d}{num_d}] = {d_val[i]}\r\n");
                        num_d += 4;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Int16":
                    string[] val_int16 = txtResult.Text.Split(',');
                    Int16[] ret_int16 = new Int16[val_int16.Length];
                    for (int i = 0; i < val_int16.Length; i++)
                    {
                        ret_int16[i] = Int16.Parse(val_int16[i]);
                    }
                    NanoSerial.Write(txtAddr.Text, ret_int16);
                    break;
                case "Int32":
                    string[] val_int32 = txtResult.Text.Split(',');
                    Int32[] ret_int32 = new Int32[val_int32.Length];
                    for (int i = 0; i < val_int32.Length; i++)
                    {
                        ret_int32[i] = Int32.Parse(val_int32[i]);
                    }
                    NanoSerial.Write(txtAddr.Text, ret_int32);
                    break;
                case "Int64":
                    break;
                case "Float":
                    string[] val_f = txtResult.Text.Split(',');
                    float[] ret_f = new float[val_f.Length];
                    for (int i = 0; i < val_f.Length; i++)
                    {
                        ret_f[i] = float.Parse(val_f[i]);
                    }
                    NanoSerial.Write(txtAddr.Text, ret_f);
                    break;
                case "Double":
                    break;
                default:
                    break;
            }
        }
    }
}
