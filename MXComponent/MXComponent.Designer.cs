
namespace MXComponent
{
    partial class MXComponent
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
            this.components = new System.ComponentModel.Container();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.picLampX0 = new System.Windows.Forms.PictureBox();
            this.picLampX1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBitM0 = new System.Windows.Forms.CheckBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtLenth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRW = new System.Windows.Forms.ComboBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRW = new System.Windows.Forms.Button();
            this.txtLen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLampX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLampX1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(200, 20);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(69, 26);
            this.txtStation.TabIndex = 0;
            this.txtStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logical station number :";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 54);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 33);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(189, 54);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label2";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // picLampX0
            // 
            this.picLampX0.Location = new System.Drawing.Point(13, 106);
            this.picLampX0.Name = "picLampX0";
            this.picLampX0.Size = new System.Drawing.Size(50, 50);
            this.picLampX0.TabIndex = 4;
            this.picLampX0.TabStop = false;
            // 
            // picLampX1
            // 
            this.picLampX1.Location = new System.Drawing.Point(72, 106);
            this.picLampX1.Name = "picLampX1";
            this.picLampX1.Size = new System.Drawing.Size(50, 50);
            this.picLampX1.TabIndex = 4;
            this.picLampX1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "X1";
            // 
            // chkBitM0
            // 
            this.chkBitM0.AutoSize = true;
            this.chkBitM0.Location = new System.Drawing.Point(134, 121);
            this.chkBitM0.Name = "chkBitM0";
            this.chkBitM0.Size = new System.Drawing.Size(51, 24);
            this.chkBitM0.TabIndex = 6;
            this.chkBitM0.Text = "M0";
            this.chkBitM0.UseVisualStyleBackColor = true;
            this.chkBitM0.CheckedChanged += new System.EventHandler(this.chkBitM0_CheckedChanged);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(13, 263);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(195, 79);
            this.txtValue.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(13, 231);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(74, 26);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(13, 348);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(80, 33);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(128, 348);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(80, 33);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtLenth
            // 
            this.txtLenth.Location = new System.Drawing.Point(134, 231);
            this.txtLenth.Name = "txtLenth";
            this.txtLenth.Size = new System.Drawing.Size(74, 26);
            this.txtLenth.TabIndex = 8;
            this.txtLenth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Length";
            // 
            // cmbRW
            // 
            this.cmbRW.FormattingEnabled = true;
            this.cmbRW.Items.AddRange(new object[] {
            "Read",
            "Write"});
            this.cmbRW.Location = new System.Drawing.Point(310, 54);
            this.cmbRW.Name = "cmbRW";
            this.cmbRW.Size = new System.Drawing.Size(121, 28);
            this.cmbRW.TabIndex = 10;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(464, 54);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(73, 26);
            this.txtAddr.TabIndex = 8;
            this.txtAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(310, 140);
            this.txtVal.Multiline = true;
            this.txtVal.Name = "txtVal";
            this.txtVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVal.Size = new System.Drawing.Size(227, 202);
            this.txtVal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Read/Write";
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Items.AddRange(new object[] {
            "Int16",
            "Int32",
            "Int64",
            "Float",
            "Double",
            "UInt16"});
            this.cmbDataType.Location = new System.Drawing.Point(310, 106);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(121, 28);
            this.cmbDataType.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data Type";
            // 
            // btnRW
            // 
            this.btnRW.Location = new System.Drawing.Point(310, 348);
            this.btnRW.Name = "btnRW";
            this.btnRW.Size = new System.Drawing.Size(109, 33);
            this.btnRW.TabIndex = 2;
            this.btnRW.Text = "READ/WRITE";
            this.btnRW.UseVisualStyleBackColor = true;
            this.btnRW.Click += new System.EventHandler(this.btnRW_Click);
            // 
            // txtLen
            // 
            this.txtLen.Location = new System.Drawing.Point(464, 108);
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new System.Drawing.Size(73, 26);
            this.txtLen.TabIndex = 8;
            this.txtLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Length";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(189, 119);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(74, 26);
            this.txtReal.TabIndex = 8;
            this.txtReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MXComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 421);
            this.Controls.Add(this.cmbDataType);
            this.Controls.Add(this.cmbRW);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLen);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.txtLenth);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.chkBitM0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLampX1);
            this.Controls.Add(this.picLampX0);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnRW);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStation);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MXComponent";
            this.Text = "MXComponent";
            ((System.ComponentModel.ISupportInitialize)(this.picLampX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLampX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox picLampX0;
        private System.Windows.Forms.PictureBox picLampX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBitM0;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtLenth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRW;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRW;
        private System.Windows.Forms.TextBox txtLen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReal;
    }
}

