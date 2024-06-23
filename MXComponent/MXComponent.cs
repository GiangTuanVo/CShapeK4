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

namespace MXComponent
{
    public partial class MXComponent : Form
    {
        private MelsecComponent melsecComponent;
        public MXComponent()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            melsecComponent = new MelsecComponent();
            OperateResult ret = melsecComponent.Connection(int.Parse(txtStation.Text));
            if (ret.IsSuccess)
            {
                lblStatus.Text = ret.Message;
                lblStatus.ForeColor = Color.Blue;
                Timer.Start();
            }
            else
            {
                lblStatus.Text = ret.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool bitX0 = melsecComponent.ReadBool("X0").Content;
            if (bitX0)
                picLampX0.Image = Properties.Resources.Light_On;
            else
                picLampX0.Image = Properties.Resources.Light_Off;

            bool bitX1 = melsecComponent.ReadBool("X1").Content;
            if (bitX1)
                picLampX1.Image = Properties.Resources.Light_On;
            else
                picLampX1.Image = Properties.Resources.Light_Off;
            txtReal.Text = melsecComponent.ReadInt16("D0").Content.ToString();

        }

        private void chkBitM0_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBitM0.Checked)
            {
                OperateResult check = melsecComponent.WriteBool("M0", true);
                if (check.IsSuccess)
                {
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            else
            {
                OperateResult check = melsecComponent.WriteBool("M0", false);
                if (check.IsSuccess)
                {
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string[] text = txtValue.Text.Split(',');
            int num = int.Parse(txtAddress.Text.Substring(1, txtAddress.Text.Length - 1));
            for (int i = 0; i < text.Length; i++)
            {
                melsecComponent.WriteBool($"M{num + i}", bool.Parse(text[i]));
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtAddress.Text.Substring(1, txtAddress.Text.Length-1));
            string text = "";
            for (int i = 0; i < int.Parse(txtLenth.Text); i++)
            {
                text += melsecComponent.ReadBool($"M{num + i}").Content.ToString();
                text += ",";
            }
            txtValue.Text = text;
        }

        private void btnRW_Click(object sender, EventArgs e)
        {
            if (cmbRW.Text == "Read")
            {
                switch (cmbDataType.Text)
                {
                    case "Int16":
                        Int16[] val= melsecComponent.ReadInt16(txtAddr.Text, int.Parse(txtLen.Text)).Content;
                        string text ="";
                        for (int i = 0; i < val.Length; i++)
                        {
                            text += $"{val[i].ToString()}\r\n";
                        }
                        txtVal.Text = text;
                        break;
                    case "Int32":
                        Int32[] val32 = melsecComponent.ReadInt32(txtAddr.Text, int.Parse(txtLen.Text)).Content;
                        string text32= "";
                        for (int i = 0; i < val32.Length; i++)
                        {
                            text32 += $"{val32[i].ToString()}\r\n";
                        }
                        txtVal.Text = text32;
                        break;
                    case "Float":
                        float[] valf = melsecComponent.ReadFloat(txtAddr.Text, int.Parse(txtLen.Text)).Content;
                        string textf = "";
                        for (int i = 0; i < valf.Length; i++)
                        {
                            textf += $"{valf[i].ToString()}\r\n";
                        }
                        txtVal.Text = textf;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (cmbDataType.Text)
                {
                    case "Int16":
                        string[] text = txtVal.Text.Split(',');
                        Int16[] val = new Int16[text.Length];
                        for (int i = 0; i < text.Length; i++)
                        {
                            val[i] = Int16.Parse(text[i]);
                        }
                        melsecComponent.WriteInt16(txtAddr.Text, val);
                        break;
                    case "Int32":
                        string[] text32 = txtVal.Text.Split(',');
                        Int32[] val32 = new Int32[text32.Length];
                        for (int i = 0; i < text32.Length; i++)
                        {
                            val32[i] = Int32.Parse(text32[i]);
                        }
                        melsecComponent.WriteInt32(txtAddr.Text, val32);
                        break;
                    case "Float":
                        string[] textf = txtVal.Text.Split(',');
                        float[] valf = new float[textf.Length];
                        for (int i = 0; i < textf.Length; i++)
                        {
                            valf[i] = float.Parse(textf[i]);
                        }
                        melsecComponent.WriteFloat(txtAddr.Text, valf);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
