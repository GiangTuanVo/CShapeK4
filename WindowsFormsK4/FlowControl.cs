using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsK4.Model;

namespace WindowsFormsK4
{
    public partial class FlowControl : Form
    {
        int index = 1;
        public FlowControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++index;
            Button button = new Button();
            button.Width = 100;
            button.Height = 50;
            button.Text = $"#{index}";
            button.Click += Button_Click;
            flowLayoutPanel1.Controls.Add(button);
        }

        private void FlowControl_Load(object sender, EventArgs e)
        {
            List<MenuDrink> menu = new List<MenuDrink>();
            MenuDrink menu1 = new MenuDrink("Cafe", 15000);
            menu.Add(menu1);
            MenuDrink menu2 = new MenuDrink("Milk Cafe", 20000);
            menu.Add(menu2);
            MenuDrink menu3 = new MenuDrink("Cream", 17000);
            menu.Add(menu3);
            MenuDrink menu4 = new MenuDrink("CaCao", 25000);
            menu.Add(menu4);
            MenuDrink menu5 = new MenuDrink("Smooth", 35000);
            menu.Add(menu5);

            for (int i = 0; i <5; i++)
            {
                index = i;
                Button button = new Button();
                button.Width = 100;
                button.Height = 50;
                button.Text = $"#{i+1}";
                button.Tag = menu[i];//Gan
                button.Click += Button_Click;
                flowLayoutPanel1.Controls.Add(button);
            }

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"; 

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            but.BackColor = Color.Green;
            if(but.Tag is MenuDrink)
            {
                MenuDrink menu = but.Tag as MenuDrink;
                listBox1.Items.Add(menu);
            }
            //MessageBox.Show(but.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                if (item.BackColor == Color.Green)
                {
                    text += $"{item.Text}\r\n";
                }
            }
            MessageBox.Show(text);
        }

        private void radRedColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radRedColor.Checked == true)
                txtName.ForeColor = Color.Red;
        }

        private void radBlueColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlueColor.Checked == true)
                txtName.ForeColor = Color.Blue;
        }

        private void radGreenColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreenColor.Checked == true)
                txtName.ForeColor = Color.Green;
        }

        private void radBlackColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlackColor.Checked == true)
                txtName.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBold.Checked)
            txtName.Font = new Font(txtName.Font.Name, txtName.Font.Size, txtName.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
                txtName.Font = new Font(txtName.Font.Name, txtName.Font.Size, txtName.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderline.Checked)
                txtName.Font = new Font(txtName.Font.Name, txtName.Font.Size, txtName.Font.Style ^ FontStyle.Underline);
        }

        private void chkRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegular.Checked)
                txtName.Font = new Font(txtName.Font.Name, txtName.Font.Size, txtName.Font.Style ^ FontStyle.Regular);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Light On";
                pictureBox1.Image = Properties.Resources.Light_On;
            }
            else
            {
                checkBox1.Text = "Light Off";
                pictureBox1.Image = Properties.Resources.Light_Off;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if(listBox1.SelectedItem is MenuDrink)
                {
                    MenuDrink drink = listBox1.SelectedItem as MenuDrink;
                    Modify modify = new Modify(drink.Name, drink.Price);
                    modify.ShowDialog();
                    if (modify.IsCheck == true)
                    {
                        MenuDrink menu = new MenuDrink(modify.Name, modify.Price);
                        listBox1.Items[listBox1.SelectedIndex] = menu;

                    }
                }

            }
        }
    }
}
