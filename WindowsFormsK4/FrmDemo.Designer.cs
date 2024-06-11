
namespace WindowsFormsK4
{
    partial class FrmDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDM = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPTTT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ritBill = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKH
            // 
            this.txtKH.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.Location = new System.Drawing.Point(104, 49);
            this.txtKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(148, 31);
            this.txtKH.TabIndex = 0;
            this.txtKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM ORDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên KH :";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(104, 85);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(148, 31);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số ĐT :";
            // 
            // lstDM
            // 
            this.lstDM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDM.FormattingEnabled = true;
            this.lstDM.ItemHeight = 23;
            this.lstDM.Items.AddRange(new object[] {
            "Cafe",
            "Đường",
            "Nắm",
            "Nước Tương",
            "Bánh Tráng"});
            this.lstDM.Location = new System.Drawing.Point(28, 162);
            this.lstDM.Name = "lstDM";
            this.lstDM.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDM.Size = new System.Drawing.Size(224, 142);
            this.lstDM.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh Mục SP";
            // 
            // cboPTTT
            // 
            this.cboPTTT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPTTT.FormattingEnabled = true;
            this.cboPTTT.Location = new System.Drawing.Point(28, 335);
            this.cboPTTT.Name = "cboPTTT";
            this.cboPTTT.Size = new System.Drawing.Size(224, 31);
            this.cboPTTT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phương Thức Thanh Toán";
            // 
            // ritBill
            // 
            this.ritBill.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritBill.Location = new System.Drawing.Point(282, 85);
            this.ritBill.Name = "ritBill";
            this.ritBill.Size = new System.Drawing.Size(295, 281);
            this.ritBill.TabIndex = 6;
            this.ritBill.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bill Thanh Toán";
            // 
            // btnDH
            // 
            this.btnDH.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDH.Location = new System.Drawing.Point(71, 383);
            this.btnDH.Name = "btnDH";
            this.btnDH.Size = new System.Drawing.Size(115, 45);
            this.btnDH.TabIndex = 7;
            this.btnDH.Text = "ĐẶT HÀNG";
            this.btnDH.UseVisualStyleBackColor = true;
            this.btnDH.Click += new System.EventHandler(this.btnDH_Click);
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 440);
            this.Controls.Add(this.btnDH);
            this.Controls.Add(this.ritBill);
            this.Controls.Add(this.cboPTTT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtKH);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDemo";
            this.Text = "FrmDemo";
            this.Load += new System.EventHandler(this.FrmDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPTTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ritBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDH;
    }
}