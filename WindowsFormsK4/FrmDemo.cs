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
    public partial class FrmDemo : Form
    {
        public FrmDemo()
        {
            InitializeComponent();
        }

        private void FrmDemo_Load(object sender, EventArgs e)
        {
            string[] lstpttt = new string[] { "ATM","App", "Tiền mặt", "Chuyển khoản" };
            //cboPTTT.Items.Add("ATM");
            cboPTTT.Items.AddRange(lstpttt);
            //cboPTTT.DataSource = lstpttt;
            //cboPTTT.Items.Remove("ATM");
            //cboPTTT.Items.Clear();
            //cboPTTT.Items.Insert(1, "App");
            cboPTTT.SelectedIndex = 0;
            txtKH.Focus();
        }

        private void btnDH_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Tên khách hàng : {txtKH.Text}");
            builder.Append(Environment.NewLine);
            builder.Append($"Số điện thoại : {txtSDT.Text}");
            builder.Append(Environment.NewLine);
            builder.Append("Danh mục sản phẩm:\r\n");
            
            var text = lstDM.SelectedItems;
            foreach (var item in text)
            {
                builder.Append(item);
                builder.Append(Environment.NewLine);
            }

            builder.Append("Phương thức thanh toán:\r\n");
            builder.Append(cboPTTT.Text);
            ritBill.Text = builder.ToString();
        }
    }
}
