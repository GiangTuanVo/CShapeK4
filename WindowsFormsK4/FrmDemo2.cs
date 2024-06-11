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
    public partial class FrmDemo2 : Form
    {
        public FrmDemo2()
        {
            InitializeComponent();
        }

        private void FrmDemo2_Load(object sender, EventArgs e)
        {
            chklbLeft.Items.AddRange(new string[] { "Tèo", "Tí", "Bin", "Bo" });
        }

        private void btnCheckSelect_Click(object sender, EventArgs e)
        {
            var indexCollection = chklbLeft.CheckedIndices;
            string strChecked = "";
            foreach (int i in indexCollection)
            {
                strChecked += i + ";";
            }
            MessageBox.Show(strChecked);
        }

        private void btnSelectItems_Click(object sender, EventArgs e)
        {
            var indexCollection = chklbLeft.CheckedItems;
            string strChecked = "";
            foreach (var i in indexCollection)
            {
                strChecked += i + ";";
            }
            MessageBox.Show(strChecked);
        }

        private void btbLeftoRight_Click(object sender, EventArgs e)
        {
            if (chklbLeft.Items.Count == 0) return;
            foreach (var item in chklbLeft.Items)
            {
                chklbRight.Items.Add(item);
            }
            chklbLeft.Items.Clear();
        }

        private void btnRighttoLeft_Click(object sender, EventArgs e)
        {
            if (chklbRight.Items.Count == 0) return;
            foreach (var item in chklbRight.Items)
            {
                chklbLeft.Items.Add(item);
            }
            chklbRight.Items.Clear();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (int i in chklbLeft.CheckedIndices)
            {
                chklbRight.Items.Add(chklbLeft.Items[i]);
            }
            foreach (string s in chklbRight.Items)
            { chklbLeft.Items.Remove(s); }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            foreach (int i in chklbRight.CheckedIndices)
            {
                chklbLeft.Items.Add(chklbRight.Items[i]);
            }
            foreach (string s in chklbLeft.Items)
            { chklbRight.Items.Remove(s); }
        }
    }
}
