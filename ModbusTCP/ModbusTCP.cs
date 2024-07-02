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
using LibConnection.ModBus;

namespace ModbusTCP
{
    public partial class ModbusTCP : Form
    {
        private ModbusTcpNet Modbus;
        public ModbusTCP()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            Modbus = new ModbusTcpNet(txtIp.Text, int.Parse(txtPort.Text), byte.Parse(txtStation.Text));
            Modbus.DataFormat = LibConnection.Core.DataFormat.CDAB;
            OperateResult ret = Modbus.ConnectServer();
            if (ret.IsSuccess)
            {
                btnOpen.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Modbus.ConnectClose();
            btnOpen.Enabled = true;
        }

        private void BIT_M0_CheckedChanged(object sender, System.EventArgs e)
        {
            if (BIT_M0.Checked)
            {
                OperateResult ret = Modbus.Write("8192", true);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
            else
            {
                OperateResult ret = Modbus.Write("8192", false);
                if (ret.IsSuccess) MessageBox.Show("Successful!");
            }
        }

        private void btnWriteBit_Click(object sender, System.EventArgs e)
        {
            //Not Support
            bool[] data = new bool[] { true, false, true, false, true };
            OperateResult ret = Modbus.Write("8192", data);
            if (ret.IsSuccess) MessageBox.Show("Successful!");

        }

        private void btnReadBit_Click(object sender, System.EventArgs e)
        {
            bool ret = Modbus.ReadBool("8192").Content;

            //Support
            //bool[] ret1 = FxSerial.ReadBool("M0", 5).Content;
            OperateResult<bool[]> ret2 = Modbus.ReadBool("8192", 5);
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
                    bool[] _bool = Modbus.ReadBool(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    for (int i = 0; i < _bool.Length; i++)
                    {
                        txtResult.AppendText($"[{int.Parse(txtAddr.Text) + i}] = {_bool[i]}\r\n");
                    }
                    break;
                case "Int16":
                    Int16[] int16 = Modbus.ReadInt16(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    for (int i = 0; i < int16.Length; i++)
                    {
                        txtResult.AppendText($"[{int.Parse(txtAddr.Text) + i}] = {int16[i]}\r\n");
                    }
                    break;
                case "Int32":
                    Int32[] int32 = Modbus.ReadInt32(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    for (int i = 0; i < int32.Length; i++)
                    {
                        txtResult.AppendText($"[{int.Parse(txtAddr.Text) + i * 2}] = {int32[i]}\r\n");
                    }
                    break;
                case "Int64":
                    break;
                case "Float":
                    float[] f_val = Modbus.ReadFloat(txtAddr.Text, ushort.Parse(txtLength.Text)).Content;
                    for (int i = 0; i < f_val.Length; i++)
                    {
                        txtResult.AppendText($"[{int.Parse(txtAddr.Text) + i * 2}] = {f_val[i]}\r\n");
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
                    Int16[] ret_int16 = new Int16[val_int16.Length];
                    for (int i = 0; i < val_int16.Length; i++)
                    {
                        ret_int16[i] = Int16.Parse(val_int16[i]);
                    }
                    Modbus.Write(txtAddr.Text, ret_int16);
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
                    Modbus.Write(txtAddr.Text, ret_f);
                    break;
                case "Double":
                    break;
                default:
                    break;
            }
        }
    }
}
