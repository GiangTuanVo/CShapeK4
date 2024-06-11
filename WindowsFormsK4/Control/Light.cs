using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsK4.Control
{
    public partial class Light : UserControl
    {
        public Image ItemsImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string ItemONOFF
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public Light()
        {
            InitializeComponent();
        }
    }
}
