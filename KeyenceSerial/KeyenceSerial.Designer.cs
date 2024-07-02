
namespace KeyenceSerial
{
    partial class KeyenceSerial
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnReadBit = new System.Windows.Forms.Button();
            this.btnWriteBit = new System.Windows.Forms.Button();
            this.BIT_M0 = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(255, 400);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 44);
            this.btnWrite.TabIndex = 28;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(165, 400);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 44);
            this.btnRead.TabIndex = 27;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(163, 306);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(167, 88);
            this.txtResult.TabIndex = 26;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(163, 260);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(121, 26);
            this.txtLength.TabIndex = 25;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(163, 214);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(121, 26);
            this.txtAddr.TabIndex = 24;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Int16",
            "UInt16",
            "Int32",
            "UInt32",
            "Int64",
            "UInt64",
            "Float",
            "Double"});
            this.cmbType.Location = new System.Drawing.Point(163, 166);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 28);
            this.cmbType.TabIndex = 23;
            // 
            // btnReadBit
            // 
            this.btnReadBit.Location = new System.Drawing.Point(30, 228);
            this.btnReadBit.Name = "btnReadBit";
            this.btnReadBit.Size = new System.Drawing.Size(83, 34);
            this.btnReadBit.TabIndex = 21;
            this.btnReadBit.Text = "READ BIT";
            this.btnReadBit.UseVisualStyleBackColor = true;
            this.btnReadBit.Click += new System.EventHandler(this.btnReadBit_Click);
            // 
            // btnWriteBit
            // 
            this.btnWriteBit.Location = new System.Drawing.Point(30, 188);
            this.btnWriteBit.Name = "btnWriteBit";
            this.btnWriteBit.Size = new System.Drawing.Size(83, 34);
            this.btnWriteBit.TabIndex = 22;
            this.btnWriteBit.Text = "WRITE BIT";
            this.btnWriteBit.UseVisualStyleBackColor = true;
            this.btnWriteBit.Click += new System.EventHandler(this.btnWriteBit_Click);
            // 
            // BIT_M0
            // 
            this.BIT_M0.AutoSize = true;
            this.BIT_M0.Location = new System.Drawing.Point(28, 148);
            this.BIT_M0.Name = "BIT_M0";
            this.BIT_M0.Size = new System.Drawing.Size(60, 24);
            this.BIT_M0.TabIndex = 20;
            this.BIT_M0.Text = "MR0";
            this.BIT_M0.UseVisualStyleBackColor = true;
            this.BIT_M0.CheckedChanged += new System.EventHandler(this.BIT_M0_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(163, 95);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(28, 95);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(77, 37);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "TypeData";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "BaudRate :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ComPort :";
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400"});
            this.cmbBaudrate.Location = new System.Drawing.Point(119, 50);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(121, 28);
            this.cmbBaudrate.TabIndex = 11;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(119, 19);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 28);
            this.cmbPort.TabIndex = 10;
            // 
            // KeyenceSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 455);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnReadBit);
            this.Controls.Add(this.btnWriteBit);
            this.Controls.Add(this.BIT_M0);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBaudrate);
            this.Controls.Add(this.cmbPort);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KeyenceSerial";
            this.Text = "KeyenceSerial";
            this.Load += new System.EventHandler(this.KeyenceSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.ComboBox cmbType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnReadBit;
        private System.Windows.Forms.Button btnWriteBit;
        private System.Windows.Forms.CheckBox BIT_M0;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbPort;
    }
}

