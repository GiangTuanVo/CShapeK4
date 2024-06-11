
namespace WindowsFormsK4
{
    partial class FlowControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radRedColor = new System.Windows.Forms.RadioButton();
            this.radBlueColor = new System.Windows.Forms.RadioButton();
            this.radGreenColor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBlackColor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 214);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(578, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 167);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 65);
            this.button3.TabIndex = 1;
            this.button3.Text = "SEARCH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radRedColor
            // 
            this.radRedColor.AutoSize = true;
            this.radRedColor.Checked = true;
            this.radRedColor.Location = new System.Drawing.Point(15, 24);
            this.radRedColor.Name = "radRedColor";
            this.radRedColor.Size = new System.Drawing.Size(56, 24);
            this.radRedColor.TabIndex = 3;
            this.radRedColor.TabStop = true;
            this.radRedColor.Text = "Red";
            this.radRedColor.UseVisualStyleBackColor = true;
            this.radRedColor.CheckedChanged += new System.EventHandler(this.radRedColor_CheckedChanged);
            // 
            // radBlueColor
            // 
            this.radBlueColor.AutoSize = true;
            this.radBlueColor.Location = new System.Drawing.Point(15, 54);
            this.radBlueColor.Name = "radBlueColor";
            this.radBlueColor.Size = new System.Drawing.Size(58, 24);
            this.radBlueColor.TabIndex = 4;
            this.radBlueColor.TabStop = true;
            this.radBlueColor.Text = "Blue";
            this.radBlueColor.UseVisualStyleBackColor = true;
            this.radBlueColor.CheckedChanged += new System.EventHandler(this.radBlueColor_CheckedChanged);
            // 
            // radGreenColor
            // 
            this.radGreenColor.AutoSize = true;
            this.radGreenColor.Location = new System.Drawing.Point(15, 84);
            this.radGreenColor.Name = "radGreenColor";
            this.radGreenColor.Size = new System.Drawing.Size(74, 24);
            this.radGreenColor.TabIndex = 5;
            this.radGreenColor.TabStop = true;
            this.radGreenColor.Text = "Green";
            this.radGreenColor.UseVisualStyleBackColor = true;
            this.radGreenColor.CheckedChanged += new System.EventHandler(this.radGreenColor_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBlueColor);
            this.groupBox1.Controls.Add(this.radBlackColor);
            this.groupBox1.Controls.Add(this.radGreenColor);
            this.groupBox1.Controls.Add(this.radRedColor);
            this.groupBox1.Location = new System.Drawing.Point(51, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // radBlackColor
            // 
            this.radBlackColor.AutoSize = true;
            this.radBlackColor.Location = new System.Drawing.Point(15, 114);
            this.radBlackColor.Name = "radBlackColor";
            this.radBlackColor.Size = new System.Drawing.Size(67, 24);
            this.radBlackColor.TabIndex = 5;
            this.radBlackColor.TabStop = true;
            this.radBlackColor.Text = "Black";
            this.radBlackColor.UseVisualStyleBackColor = true;
            this.radBlackColor.CheckedChanged += new System.EventHandler(this.radBlackColor_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkRegular);
            this.groupBox2.Controls.Add(this.chkUnderline);
            this.groupBox2.Controls.Add(this.chkItalic);
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Location = new System.Drawing.Point(218, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 147);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(17, 112);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(84, 24);
            this.chkRegular.TabIndex = 0;
            this.chkRegular.Text = "Regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            this.chkRegular.CheckedChanged += new System.EventHandler(this.chkRegular_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(17, 82);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(98, 24);
            this.chkUnderline.TabIndex = 0;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(17, 55);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(64, 22);
            this.chkItalic.TabIndex = 0;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(17, 25);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(60, 22);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 436);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 26);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Thich Chan Quang";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(381, 342);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Light Off";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 487);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 533);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 26);
            this.textBox1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(476, 286);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 224);
            this.listBox1.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 74);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Image = global::WindowsFormsK4.Properties.Resources.Edit;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::WindowsFormsK4.Properties.Resources.Close;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsK4.Properties.Resources.Light_Off;
            this.pictureBox1.Location = new System.Drawing.Point(400, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FlowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 571);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FlowControl";
            this.Text = "FlowControl";
            this.Load += new System.EventHandler(this.FlowControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radRedColor;
        private System.Windows.Forms.RadioButton radBlueColor;
        private System.Windows.Forms.RadioButton radGreenColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBlackColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
    }
}