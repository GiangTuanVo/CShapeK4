
namespace WindowsFormsK4
{
    partial class FrmMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHo = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 248);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtNum
            // 
            this.txtNum.AcceptsReturn = true;
            this.txtNum.Location = new System.Drawing.Point(12, 58);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(120, 56);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            this.txtNum.MouseLeave += new System.EventHandler(this.txtNum_MouseLeave);
            this.txtNum.MouseHover += new System.EventHandler(this.txtNum_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 156);
            this.panel1.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(12, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(143, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Hom nay la thu 6";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::WindowsFormsK4.Properties.Resources.Natural_User_Interface_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click Me!";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightGray;
            this.splitter1.Location = new System.Drawing.Point(296, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 248);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.btnHoTen);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnTen);
            this.panel2.Controls.Add(this.btnHo);
            this.panel2.Controls.Add(this.lblHoTen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(301, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 248);
            this.panel2.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(20, 96);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(372, 26);
            this.txtTen.TabIndex = 5;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(20, 64);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(372, 26);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHoTen
            // 
            this.btnHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.btnHoTen.Image = global::WindowsFormsK4.Properties.Resources.Natural_User_Interface_2;
            this.btnHoTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoTen.Location = new System.Drawing.Point(272, 139);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(120, 44);
            this.btnHoTen.TabIndex = 1;
            this.btnHoTen.Text = "Họ Tên";
            this.btnHoTen.UseVisualStyleBackColor = false;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = global::WindowsFormsK4.Properties.Resources.Close_Window;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(103, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.SystemColors.Control;
            this.btnTen.Image = global::WindowsFormsK4.Properties.Resources.Natural_User_Interface_2;
            this.btnTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTen.Location = new System.Drawing.Point(146, 139);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(120, 44);
            this.btnTen.TabIndex = 1;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHo
            // 
            this.btnHo.BackColor = System.Drawing.SystemColors.Control;
            this.btnHo.Image = global::WindowsFormsK4.Properties.Resources.Natural_User_Interface_2;
            this.btnHo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHo.Location = new System.Drawing.Point(20, 139);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(120, 44);
            this.btnHo.TabIndex = 1;
            this.btnHo.Text = "  Họ_Lót";
            this.btnHo.UseVisualStyleBackColor = false;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(151, 31);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(86, 30);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "label1";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Label lblHoTen;
    }
}

