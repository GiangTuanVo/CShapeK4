using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibConnection;
using LibConnection.Profinet.Melsec;

namespace MelsecTcp
{
    public partial class MelsecTcp : Form
    {
        MelsecMcNet mcNet = null;
        public MelsecTcp()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            mcNet = new MelsecMcNet(txtIp.Text, int.Parse(txtPort.Text));
            mcNet.ConnectTimeOut = int.Parse(txtTime.Text);
            OperateResult ret = mcNet.ConnectServer();
            if (ret.IsSuccess)
            {
                btnOpen.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            mcNet.ConnectClose();
            btnOpen.Enabled = true;
        }

        private void BIT_M0_CheckedChanged(object sender, System.EventArgs e)
        {
            if (BIT_M0.Checked)
            {
                OperateResult ret = mcNet.Write("M0", true);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
            else
            {
                OperateResult ret = mcNet.Write("M0", false);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
        }

        private void btnWriteBit_Click(object sender, System.EventArgs e)
        {
            //Not Support
            bool[] data = new bool[] { true, false, true, false, true };
            OperateResult ret = mcNet.Write("M0", data);
            if (ret.IsSuccess) MessageBox.Show("Successful!");

        }

        private void btnReadBit_Click(object sender, System.EventArgs e)
        {
            bool ret = mcNet.ReadBool("M0").Content;

            //Support
            //bool[] ret1 = FxSerial.ReadBool("M0", 5).Content;
            OperateResult<bool[]> ret2 = mcNet.ReadBool("M0", 5);
            if (ret2.IsSuccess)
            {
                bool[] val = ret2.Content;
            }
        }

        private void btnRead_Click(object sender, System.EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Bool":
                    bool[] _bool = mcNet.ReadBool(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num_bool = int.Parse(txtAddr.Text.Substring(1, txtAddr.Text.Length - 1));
                    string text_bool = txtAddr.Text.Substring(0, 1);
                    for (int i = 0; i < _bool.Length; i++)
                    {
                        txtResult.AppendText($"[{text_bool}{num_bool}] = {_bool[i]}\r\n");
                        ++num_bool;
                    }
                    break;
                case "Int16":
                    Int16[] int16 = mcNet.ReadInt16(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    int num16 = int.Parse(txtAddr.Text.Substring(1, txtAddr.Text.Length - 1));
                    string text16 = txtAddr.Text.Substring(0, 1);
                    for (int i = 0; i < int16.Length; i++)
                    {
                        txtResult.AppendText($"[{text16}{num16}] = {int16[i]}\r\n");
                        ++num16;
                    }
                    break;
                case "Int32":
                    Int32[] int32 = mcNet.ReadInt32(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    mcNet.ReadInt16Async(txtAddr.Text, ushort.Parse(txtLength.Text));
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
                    float[] f_val = mcNet.ReadFloat(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
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
                case "Bool":
                    string[] val_bool = txtResult.Text.Split(',');
                    bool[] ret_bool = new bool[val_bool.Length];
                    for (int i = 0; i < val_bool.Length; i++)
                    {
                        ret_bool[i] = bool.Parse(val_bool[i]);
                    }
                    mcNet.Write(txtAddr.Text, ret_bool);
                    break;
                case "Int16":
                    string[] val_int16 = txtResult.Text.Split(',');
                    Int16[] ret_int16 = new Int16[val_int16.Length];
                    for (int i = 0; i < val_int16.Length; i++)
                    {
                        ret_int16[i] = Int16.Parse(val_int16[i]);
                    }
                    mcNet.Write(txtAddr.Text, ret_int16);
                    break;
                case "Int32":

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
                    mcNet.Write(txtAddr.Text, ret_f);
                    break;
                case "Double":
                    break;
                default:
                    break;
            }
        }
    }
}
