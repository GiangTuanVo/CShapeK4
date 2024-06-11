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
    public partial class Modify : Form
    {
        public bool IsCheck = false;
        public string Name { get; set; }
        public int Price { get; set; }
        public Modify( string name, int price)
        {
            InitializeComponent();
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsCheck = true;
            Name = txtName.Text;
            Price = int.Parse(txtPrice.Text);
            this.Close();
        }
    }
}
