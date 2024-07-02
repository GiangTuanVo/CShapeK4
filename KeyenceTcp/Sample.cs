using KeyenceTcp.Model;
using LibConnection;
using LibConnection.Profinet.Keyence;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyenceTcp
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private KeyenceNanoSerialOverTcp keyence_net;
        private void Sample_Load(object sender, EventArgs e)
        {
            //Khoi tao
            keyence_net = new KeyenceNanoSerialOverTcp();
            panel2.Enabled = false;
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            if (!int.TryParse(textBox2.Text, out int port))
            {
                MessageBox.Show(DemoUtils.PortInputWrong);
                return;
            }
            //Setting
            keyence_net.IpAddress = textBox1.Text;
            keyence_net.Port = port;
            keyence_net.ConnectTimeOut = 3000;

            //Đóng kết nối
            keyence_net.ConnectClose();
            //Kết nối
            OperateResult connect = await keyence_net.ConnectServerAsync();
            if (connect.IsSuccess)
            {
                MessageBox.Show(StringResources.Language.ConnectedSuccess);
                button2.Enabled = true;
                btnConnect.Enabled = false;
                panel2.Enabled = true;
                userControlReadWrite.SetReadWriteNet(keyence_net, "DM0", true);
            }
            else
            {
                MessageBox.Show(connect.Message + Environment.NewLine + "ErrorCode: " + connect.ErrorCode);
                btnConnect.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keyence_net.ConnectClose();
            button2.Enabled = false;
            btnConnect.Enabled = true;
            panel2.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DemoUtils.BulkReadRenderResult(keyence_net, textBox6, textBox9, textBox10);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OperateResult<byte[]> read = keyence_net.ReadFromCoreServer(LibConnection.BasicFramework.SoftBasic.HexStringToBytes(textBox13.Text));
            if (read.IsSuccess)
            {
                textBox11.Text = "Result：" + LibConnection.BasicFramework.SoftBasic.ByteToHexString(read.Content);
            }
            else
            {
                MessageBox.Show("Read Failed：" + read.ToMessageShowString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private async void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            OperateResult<TimeSpan> wait = await keyence_net.WaitAsync("MR100", true, 100, 30_000);
            if (wait.IsSuccess)
            {
                MessageBox.Show("Wait Success, Takes " + wait.Content.TotalSeconds.ToString("F1") + " Seconds");
            }
            else
            {
                MessageBox.Show("Wait Failed:" + wait.Message);
            }
            button10.Enabled = true;
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            OperateResult<TimeSpan> wait = await keyence_net.WaitAsync("DM100", (short)123, 100, 30_000);
            if (wait.IsSuccess)
            {
                MessageBox.Show("Wait Success, Takes " + wait.Content.TotalSeconds.ToString("F1") + " Seconds");
            }
            else
            {
                MessageBox.Show("Wait Failed:" + wait.Message);
            }
            button11.Enabled = true;
        }
    }
}