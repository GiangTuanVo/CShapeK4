using System.Windows.Forms;
using System.IO.Ports;

using LibConnection;
using LibConnection.Profinet.Melsec;
using System;
using System.Threading.Tasks;

namespace MelsecFXSerial
{
    public partial class MelsecFXSerial : Form
    {
        private MelsecFxSerial FxSerial = null;
        public MelsecFXSerial()
        {
            InitializeComponent();
        }

        private void MelsecFXSerial_Load(object sender, System.EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPort.DataSource = ports;
            cmbBaudrate.SelectedIndex = 0;
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            FxSerial = new MelsecFxSerial();
            FxSerial.SerialPortInni(sp =>
            {
                sp.PortName = cmbPort.Text;
                sp.BaudRate = int.Parse(cmbBaudrate.Text);
                sp.DataBits = 7;
                sp.StopBits = StopBits.One;
                sp.Parity = Parity.Even;
            });
            OperateResult ret = FxSerial.Open();
            if (ret.IsSuccess)
            {
                btnOpen.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            FxSerial.Close();
            btnOpen.Enabled = true;
        }

        private void BIT_M0_CheckedChanged(object sender, System.EventArgs e)
        {
            if (BIT_M0.Checked)
            {
                OperateResult ret = FxSerial.Write("M0", true);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
            else
            {
                OperateResult ret = FxSerial.Write("M0", false);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
        }

        private void btnWriteBit_Click(object sender, System.EventArgs e)
        {
            // Not Support
            bool[] data = new bool[] { true, false, true, false, true };
            OperateResult ret = FxSerial.Write("M0", data);
            if (ret.IsSuccess) MessageBox.Show("Successful!");
        }

        private void btnReadBit_Click(object sender, System.EventArgs e)
        {
            bool ret = FxSerial.ReadBool("M1").Content;

            //Support
            //bool[] ret1 = FxSerial.ReadBool("M0", 5).Content;
            OperateResult<bool[]> ret2 = FxSerial.ReadBool("M0", 5);
            if (ret2.IsSuccess)
            {
                bool[] val = ret2.Content;
            }
        }

        private void btnRead_Click(object sender, System.EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Int16":
                    Int16[] int16 = FxSerial.ReadInt16(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num16 = int.Parse(txtAddr.Text.Substring(1, txtAddr.Text.Length - 1));
                    string text16 = txtAddr.Text.Substring(0, 1);
                    for (int i = 0; i < int16.Length; i++)
                    {
                        txtResult.AppendText($"[{text16}{num16}] = {int16[i]}\r\n");
                        ++num16;
                    }
                    break;
                case "Int32":
                    Int32[] int32 = FxSerial.ReadInt32(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num32 = int.Parse(txtAddr.Text.Substring(1, txtAddr.Text.Length - 1));
                    string text32 = txtAddr.Text.Substring(0, 1);
                    for (int i = 0; i < int32.Length; i++)
                    {
                        txtResult.AppendText($"[{text32}{num32}] = {int32[i]}\r\n");
                        num32 += 2;
                    }
                    break;
                case "Int64":
                    break;
                case "Float":
                    float[] f_val = FxSerial.ReadFloat(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num_f = int.Parse(txtAddr.Text.Substring(1, txtAddr.Text.Length - 1));
                    string text_f = txtAddr.Text.Substring(0, 1);
                    for (int i = 0; i < f_val.Length; i++)
                    {
                        txtResult.AppendText($"[{text_f}{num_f}] = {f_val[i]}\r\n");
                        num_f += 2;
                    }
                    break;
                case "Double":
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
                    //foreach (var item in val_int16)
                    //{
                    //    FxSerial.Write(txtAddr.Text, Int16.Parse(item));
                    //}
                    Int16[] ret_int16 = new Int16[val_int16.Length];
                    for (int i = 0; i < val_int16.Length; i++)
                    {
                        ret_int16[i] = Int16.Parse(val_int16[i]);
                    }
                    FxSerial.Write(txtAddr.Text, ret_int16);
                    break;
                case "Int32":

                    break;
                case "Int64":
                    break;
                case "Float":
                    string[] val_f = txtResult.Text.Split(',');
                    //foreach (var item in val_int16)
                    //{
                    //    FxSerial.Write(txtAddr.Text, Int16.Parse(item));
                    //}
                    float[] ret_f = new float[val_f.Length];
                    for (int i = 0; i < val_f.Length; i++)
                    {
                        ret_f[i] = float.Parse(val_f[i]);
                    }
                    FxSerial.Write(txtAddr.Text, ret_f);
                    break;
                case "Double":
                    break;
                default:
                    break;
            }
        }

        private async void writeAsync_ClickAsync(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await FxSerial.WriteAsync("D0", 12.5f);
            });
        }

        private async void readAsync_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                OperateResult<float> val = await FxSerial.ReadFloatAsync("D0");
                MessageBox.Show($"Value = {val.Content}");
            });
        }
    }
}
