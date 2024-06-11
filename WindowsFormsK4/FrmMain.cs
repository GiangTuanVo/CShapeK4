using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsK4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtNum.Text = "Thông báo\r\nHôm nay là cuối tuần";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn đã click tôi", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                MessageBox.Show("Cảm ơn đã chọn tôi");
            }
            else if (dialog == DialogResult.Cancel)
            {
                MessageBox.Show("Tại sao bạn lại huỷ tôi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= int.Parse(txtNum.Text); i++)
            {
                Button button = new Button();
                button.Text = $"#{i}";
                button.Width = 100;
                button.Height = 50;
                flowLayoutPanel1.Controls.Add(button);
            }
            lblStatus.Text = "Bạn đã click tôi";
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum.Text = lblStatus.Text;
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.Text.Length > 10)
            {
                txtNum.PasswordChar = '*';
            }
            else
            {
                txtNum.PasswordChar = '\0';
            }
        }

        private void txtNum_MouseHover(object sender, EventArgs e)
        {
            txtNum.BackColor = SystemColors.Highlight;
        }

        private void txtNum_MouseLeave(object sender, EventArgs e)
        {
            txtNum.BackColor = SystemColors.Control;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoTen.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = $"{txtHoTen.Text} {txtTen.Text}";
        }
    }
}
