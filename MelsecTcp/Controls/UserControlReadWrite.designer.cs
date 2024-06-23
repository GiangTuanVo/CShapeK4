﻿namespace MelsecTcp
{
	partial class UserControlReadWrite
	{
        /// <summary>
        /// Required designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up all resources in use.
        /// </summary>
        /// <param name="disposing">true if the managed resource should be released; false otherwise. </param>
        protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

        #region Component Designer generated code

        /// <summary>
        /// Designer supports required methods - do not modify
        /// Use the code editor to modify the contents of this method.
        /// </summary>
        private void InitializeComponent( )
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_read_string = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button_write_bool = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_read_encoding = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_read_float = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_write_byte = new System.Windows.Forms.Button();
            this.button_write_short = new System.Windows.Forms.Button();
            this.button_write_ushort = new System.Windows.Forms.Button();
            this.button_write_int = new System.Windows.Forms.Button();
            this.button_write_uint = new System.Windows.Forms.Button();
            this.button_write_long = new System.Windows.Forms.Button();
            this.button_read_double = new System.Windows.Forms.Button();
            this.button_write_ulong = new System.Windows.Forms.Button();
            this.button_read_byte = new System.Windows.Forms.Button();
            this.button_read_ulong = new System.Windows.Forms.Button();
            this.button_write_float = new System.Windows.Forms.Button();
            this.button_write_double = new System.Windows.Forms.Button();
            this.button_write_string = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button_read_ushort = new System.Windows.Forms.Button();
            this.button_read_int = new System.Windows.Forms.Button();
            this.button_read_uint = new System.Windows.Forms.Button();
            this.button_read_long = new System.Windows.Forms.Button();
            this.button_write_hex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_write_Encoding = new System.Windows.Forms.ComboBox();
            this.button_read_bool = new System.Windows.Forms.Button();
            this.button_read_short = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBox_read_encoding);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.button_read_string);
            this.groupBox1.Controls.Add(this.button_read_double);
            this.groupBox1.Controls.Add(this.button_read_float);
            this.groupBox1.Controls.Add(this.button_read_ulong);
            this.groupBox1.Controls.Add(this.button_read_long);
            this.groupBox1.Controls.Add(this.button_read_uint);
            this.groupBox1.Controls.Add(this.button_read_int);
            this.groupBox1.Controls.Add(this.button_read_ushort);
            this.groupBox1.Controls.Add(this.button_read_short);
            this.groupBox1.Controls.Add(this.button_read_byte);
            this.groupBox1.Controls.Add(this.button_read_bool);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single Data Read test";
            // 
            // button_read_string
            // 
            this.button_read_string.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_string.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_string.Location = new System.Drawing.Point(460, 174);
            this.button_read_string.Name = "button_read_string";
            this.button_read_string.Size = new System.Drawing.Size(84, 28);
            this.button_read_string.TabIndex = 16;
            this.button_read_string.Text = "r-string";
            this.button_read_string.UseVisualStyleBackColor = true;
            this.button_read_string.Click += new System.EventHandler(this.button_read_string_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox_write_Encoding);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_write_hex);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.button_write_string);
            this.groupBox2.Controls.Add(this.button_write_double);
            this.groupBox2.Controls.Add(this.button_write_float);
            this.groupBox2.Controls.Add(this.button_write_ulong);
            this.groupBox2.Controls.Add(this.button_write_long);
            this.groupBox2.Controls.Add(this.button_write_uint);
            this.groupBox2.Controls.Add(this.button_write_int);
            this.groupBox2.Controls.Add(this.button_write_ushort);
            this.groupBox2.Controls.Add(this.button_write_short);
            this.groupBox2.Controls.Add(this.button_write_byte);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button_write_bool);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(559, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Single Data Write test";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(70, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(73, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 23);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(73, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(156, 23);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "False";
            // 
            // button_write_bool
            // 
            this.button_write_bool.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_bool.Location = new System.Drawing.Point(238, 18);
            this.button_write_bool.Name = "button_write_bool";
            this.button_write_bool.Size = new System.Drawing.Size(84, 28);
            this.button_write_bool.TabIndex = 6;
            this.button_write_bool.Text = "Write Bool";
            this.button_write_bool.UseVisualStyleBackColor = true;
            this.button_write_bool.Click += new System.EventHandler(this.button_write_bool_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(299, 23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(64, 23);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "1";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Length：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(421, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 23);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(366, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Encording：";
            // 
            // comboBox_read_encoding
            // 
            this.comboBox_read_encoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_read_encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_read_encoding.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_read_encoding.FormattingEnabled = true;
            this.comboBox_read_encoding.Location = new System.Drawing.Point(460, 205);
            this.comboBox_read_encoding.Name = "comboBox_read_encoding";
            this.comboBox_read_encoding.Size = new System.Drawing.Size(84, 25);
            this.comboBox_read_encoding.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(236, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Length :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Results :";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(70, 50);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(293, 181);
            this.textBox4.TabIndex = 5;
            // 
            // button_read_float
            // 
            this.button_read_float.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_float.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_float.Location = new System.Drawing.Point(369, 144);
            this.button_read_float.Name = "button_read_float";
            this.button_read_float.Size = new System.Drawing.Size(84, 28);
            this.button_read_float.TabIndex = 14;
            this.button_read_float.Text = "r-float";
            this.button_read_float.UseVisualStyleBackColor = true;
            this.button_read_float.Click += new System.EventHandler(this.button_read_float_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Values :";
            // 
            // button_write_byte
            // 
            this.button_write_byte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_byte.Location = new System.Drawing.Point(329, 18);
            this.button_write_byte.Name = "button_write_byte";
            this.button_write_byte.Size = new System.Drawing.Size(84, 28);
            this.button_write_byte.TabIndex = 7;
            this.button_write_byte.Text = "Write Byte";
            this.button_write_byte.UseVisualStyleBackColor = true;
            this.button_write_byte.Click += new System.EventHandler(this.button_write_byte_Click);
            // 
            // button_write_short
            // 
            this.button_write_short.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_short.Location = new System.Drawing.Point(238, 49);
            this.button_write_short.Name = "button_write_short";
            this.button_write_short.Size = new System.Drawing.Size(84, 28);
            this.button_write_short.TabIndex = 8;
            this.button_write_short.Text = "w-short";
            this.button_write_short.UseVisualStyleBackColor = true;
            this.button_write_short.Click += new System.EventHandler(this.button_write_short_Click);
            // 
            // button_write_ushort
            // 
            this.button_write_ushort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_ushort.Location = new System.Drawing.Point(329, 49);
            this.button_write_ushort.Name = "button_write_ushort";
            this.button_write_ushort.Size = new System.Drawing.Size(84, 28);
            this.button_write_ushort.TabIndex = 9;
            this.button_write_ushort.Text = "w-ushort";
            this.button_write_ushort.UseVisualStyleBackColor = true;
            this.button_write_ushort.Click += new System.EventHandler(this.button_write_ushort_Click);
            // 
            // button_write_int
            // 
            this.button_write_int.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_int.Location = new System.Drawing.Point(238, 80);
            this.button_write_int.Name = "button_write_int";
            this.button_write_int.Size = new System.Drawing.Size(84, 28);
            this.button_write_int.TabIndex = 10;
            this.button_write_int.Text = "w-int";
            this.button_write_int.UseVisualStyleBackColor = true;
            this.button_write_int.Click += new System.EventHandler(this.button_write_int_Click);
            // 
            // button_write_uint
            // 
            this.button_write_uint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_uint.Location = new System.Drawing.Point(329, 80);
            this.button_write_uint.Name = "button_write_uint";
            this.button_write_uint.Size = new System.Drawing.Size(84, 28);
            this.button_write_uint.TabIndex = 11;
            this.button_write_uint.Text = "w-uint";
            this.button_write_uint.UseVisualStyleBackColor = true;
            this.button_write_uint.Click += new System.EventHandler(this.button_write_uint_Click);
            // 
            // button_write_long
            // 
            this.button_write_long.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_long.Location = new System.Drawing.Point(238, 111);
            this.button_write_long.Name = "button_write_long";
            this.button_write_long.Size = new System.Drawing.Size(84, 28);
            this.button_write_long.TabIndex = 12;
            this.button_write_long.Text = "w-long";
            this.button_write_long.UseVisualStyleBackColor = true;
            this.button_write_long.Click += new System.EventHandler(this.button_write_long_Click);
            // 
            // button_read_double
            // 
            this.button_read_double.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_double.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_double.Location = new System.Drawing.Point(460, 144);
            this.button_read_double.Name = "button_read_double";
            this.button_read_double.Size = new System.Drawing.Size(84, 28);
            this.button_read_double.TabIndex = 15;
            this.button_read_double.Text = "r-double";
            this.button_read_double.UseVisualStyleBackColor = true;
            this.button_read_double.Click += new System.EventHandler(this.button_read_double_Click);
            // 
            // button_write_ulong
            // 
            this.button_write_ulong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_ulong.Location = new System.Drawing.Point(329, 111);
            this.button_write_ulong.Name = "button_write_ulong";
            this.button_write_ulong.Size = new System.Drawing.Size(84, 28);
            this.button_write_ulong.TabIndex = 13;
            this.button_write_ulong.Text = "w-ulong";
            this.button_write_ulong.UseVisualStyleBackColor = true;
            this.button_write_ulong.Click += new System.EventHandler(this.button_write_ulong_Click);
            // 
            // button_read_byte
            // 
            this.button_read_byte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_byte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_byte.Location = new System.Drawing.Point(460, 20);
            this.button_read_byte.Name = "button_read_byte";
            this.button_read_byte.Size = new System.Drawing.Size(84, 28);
            this.button_read_byte.TabIndex = 7;
            this.button_read_byte.Text = "Read Byte";
            this.button_read_byte.UseVisualStyleBackColor = true;
            this.button_read_byte.Click += new System.EventHandler(this.button_read_byte_Click);
            // 
            // button_read_ulong
            // 
            this.button_read_ulong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_ulong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_ulong.Location = new System.Drawing.Point(460, 113);
            this.button_read_ulong.Name = "button_read_ulong";
            this.button_read_ulong.Size = new System.Drawing.Size(84, 28);
            this.button_read_ulong.TabIndex = 13;
            this.button_read_ulong.Text = "r-ulong";
            this.button_read_ulong.UseVisualStyleBackColor = true;
            this.button_read_ulong.Click += new System.EventHandler(this.button_read_ulong_Click);
            // 
            // button_write_float
            // 
            this.button_write_float.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_float.Location = new System.Drawing.Point(238, 142);
            this.button_write_float.Name = "button_write_float";
            this.button_write_float.Size = new System.Drawing.Size(84, 28);
            this.button_write_float.TabIndex = 14;
            this.button_write_float.Text = "w-float";
            this.button_write_float.UseVisualStyleBackColor = true;
            this.button_write_float.Click += new System.EventHandler(this.button_write_float_Click);
            // 
            // button_write_double
            // 
            this.button_write_double.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_double.Location = new System.Drawing.Point(329, 142);
            this.button_write_double.Name = "button_write_double";
            this.button_write_double.Size = new System.Drawing.Size(84, 28);
            this.button_write_double.TabIndex = 15;
            this.button_write_double.Text = "w-double";
            this.button_write_double.UseVisualStyleBackColor = true;
            this.button_write_double.Click += new System.EventHandler(this.button_write_double_Click);
            // 
            // button_write_string
            // 
            this.button_write_string.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_string.Location = new System.Drawing.Point(329, 173);
            this.button_write_string.Name = "button_write_string";
            this.button_write_string.Size = new System.Drawing.Size(84, 28);
            this.button_write_string.TabIndex = 16;
            this.button_write_string.Text = "w-string";
            this.button_write_string.UseVisualStyleBackColor = true;
            this.button_write_string.Click += new System.EventHandler(this.button_write_string_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(61, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 85);
            this.label19.TabIndex = 17;
            this.label19.Text = "Note: The value of the string needs to be converted\r\nif array：[1,2,3]\"";
            // 
            // button_read_ushort
            // 
            this.button_read_ushort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_ushort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_ushort.Location = new System.Drawing.Point(460, 51);
            this.button_read_ushort.Name = "button_read_ushort";
            this.button_read_ushort.Size = new System.Drawing.Size(84, 28);
            this.button_read_ushort.TabIndex = 9;
            this.button_read_ushort.Text = "r-ushort";
            this.button_read_ushort.UseVisualStyleBackColor = true;
            this.button_read_ushort.Click += new System.EventHandler(this.button_read_ushort_Click);
            // 
            // button_read_int
            // 
            this.button_read_int.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_int.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_int.Location = new System.Drawing.Point(369, 82);
            this.button_read_int.Name = "button_read_int";
            this.button_read_int.Size = new System.Drawing.Size(84, 28);
            this.button_read_int.TabIndex = 10;
            this.button_read_int.Text = "r-int";
            this.button_read_int.UseVisualStyleBackColor = true;
            this.button_read_int.Click += new System.EventHandler(this.button_read_int_Click);
            // 
            // button_read_uint
            // 
            this.button_read_uint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_uint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_uint.Location = new System.Drawing.Point(460, 82);
            this.button_read_uint.Name = "button_read_uint";
            this.button_read_uint.Size = new System.Drawing.Size(84, 28);
            this.button_read_uint.TabIndex = 11;
            this.button_read_uint.Text = "r-uint";
            this.button_read_uint.UseVisualStyleBackColor = true;
            this.button_read_uint.Click += new System.EventHandler(this.button_read_uint_Click);
            // 
            // button_read_long
            // 
            this.button_read_long.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_long.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_long.Location = new System.Drawing.Point(369, 113);
            this.button_read_long.Name = "button_read_long";
            this.button_read_long.Size = new System.Drawing.Size(84, 28);
            this.button_read_long.TabIndex = 12;
            this.button_read_long.Text = "r-long";
            this.button_read_long.UseVisualStyleBackColor = true;
            this.button_read_long.Click += new System.EventHandler(this.button_read_long_Click);
            // 
            // button_write_hex
            // 
            this.button_write_hex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_write_hex.Location = new System.Drawing.Point(238, 173);
            this.button_write_hex.Name = "button_write_hex";
            this.button_write_hex.Size = new System.Drawing.Size(84, 28);
            this.button_write_hex.TabIndex = 19;
            this.button_write_hex.Text = "w-Hex";
            this.button_write_hex.UseVisualStyleBackColor = true;
            this.button_write_hex.Click += new System.EventHandler(this.button_write_hex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(9, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Time Cost：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(133, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "- ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(9, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Max：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(55, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "- ms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Location = new System.Drawing.Point(122, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Min：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(168, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "- ms";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(235, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Encording：";
            // 
            // comboBox_write_Encoding
            // 
            this.comboBox_write_Encoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_write_Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_write_Encoding.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_write_Encoding.FormattingEnabled = true;
            this.comboBox_write_Encoding.Location = new System.Drawing.Point(329, 205);
            this.comboBox_write_Encoding.Name = "comboBox_write_Encoding";
            this.comboBox_write_Encoding.Size = new System.Drawing.Size(84, 25);
            this.comboBox_write_Encoding.TabIndex = 27;
            // 
            // button_read_bool
            // 
            this.button_read_bool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_bool.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_bool.Location = new System.Drawing.Point(369, 20);
            this.button_read_bool.Name = "button_read_bool";
            this.button_read_bool.Size = new System.Drawing.Size(84, 28);
            this.button_read_bool.TabIndex = 6;
            this.button_read_bool.Text = "Read Bool";
            this.button_read_bool.UseVisualStyleBackColor = true;
            this.button_read_bool.Click += new System.EventHandler(this.button_read_bool_Click);
            // 
            // button_read_short
            // 
            this.button_read_short.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_short.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read_short.Location = new System.Drawing.Point(369, 51);
            this.button_read_short.Name = "button_read_short";
            this.button_read_short.Size = new System.Drawing.Size(84, 28);
            this.button_read_short.TabIndex = 8;
            this.button_read_short.Text = "r-short";
            this.button_read_short.UseVisualStyleBackColor = true;
            this.button_read_short.Click += new System.EventHandler(this.button_read_short_Click);
            // 
            // UserControlReadWrite
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlReadWrite";
            this.Size = new System.Drawing.Size(978, 240);
            this.Load += new System.EventHandler(this.UserControlReadWriteOp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_read_encoding;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button_read_string;
        private System.Windows.Forms.Button button_read_double;
        private System.Windows.Forms.Button button_read_float;
        private System.Windows.Forms.Button button_read_ulong;
        private System.Windows.Forms.Button button_read_long;
        private System.Windows.Forms.Button button_read_uint;
        private System.Windows.Forms.Button button_read_int;
        private System.Windows.Forms.Button button_read_ushort;
        private System.Windows.Forms.Button button_read_short;
        private System.Windows.Forms.Button button_read_byte;
        private System.Windows.Forms.Button button_read_bool;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_write_Encoding;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_write_hex;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_write_string;
        private System.Windows.Forms.Button button_write_double;
        private System.Windows.Forms.Button button_write_float;
        private System.Windows.Forms.Button button_write_ulong;
        private System.Windows.Forms.Button button_write_long;
        private System.Windows.Forms.Button button_write_uint;
        private System.Windows.Forms.Button button_write_int;
        private System.Windows.Forms.Button button_write_ushort;
        private System.Windows.Forms.Button button_write_short;
        private System.Windows.Forms.Button button_write_byte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_write_bool;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}
