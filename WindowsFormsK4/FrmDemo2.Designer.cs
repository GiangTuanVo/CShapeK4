
namespace WindowsFormsK4
{
    partial class FrmDemo2
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
            this.chklbLeft = new System.Windows.Forms.CheckedListBox();
            this.btnCheckSelect = new System.Windows.Forms.Button();
            this.btnSelectItems = new System.Windows.Forms.Button();
            this.chklbRight = new System.Windows.Forms.CheckedListBox();
            this.btbLeftoRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRighttoLeft = new System.Windows.Forms.Button();
            this.light1 = new WindowsFormsK4.Control.Light();
            this.SuspendLayout();
            // 
            // chklbLeft
            // 
            this.chklbLeft.FormattingEnabled = true;
            this.chklbLeft.Location = new System.Drawing.Point(12, 35);
            this.chklbLeft.Name = "chklbLeft";
            this.chklbLeft.Size = new System.Drawing.Size(236, 186);
            this.chklbLeft.TabIndex = 0;
            // 
            // btnCheckSelect
            // 
            this.btnCheckSelect.Location = new System.Drawing.Point(12, 227);
            this.btnCheckSelect.Name = "btnCheckSelect";
            this.btnCheckSelect.Size = new System.Drawing.Size(115, 47);
            this.btnCheckSelect.TabIndex = 1;
            this.btnCheckSelect.Text = "Select Index";
            this.btnCheckSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCheckSelect.UseVisualStyleBackColor = true;
            this.btnCheckSelect.Click += new System.EventHandler(this.btnCheckSelect_Click);
            // 
            // btnSelectItems
            // 
            this.btnSelectItems.Location = new System.Drawing.Point(133, 227);
            this.btnSelectItems.Name = "btnSelectItems";
            this.btnSelectItems.Size = new System.Drawing.Size(115, 47);
            this.btnSelectItems.TabIndex = 1;
            this.btnSelectItems.Text = "Select Items";
            this.btnSelectItems.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSelectItems.UseVisualStyleBackColor = true;
            this.btnSelectItems.Click += new System.EventHandler(this.btnSelectItems_Click);
            // 
            // chklbRight
            // 
            this.chklbRight.FormattingEnabled = true;
            this.chklbRight.Location = new System.Drawing.Point(335, 35);
            this.chklbRight.Name = "chklbRight";
            this.chklbRight.Size = new System.Drawing.Size(243, 186);
            this.chklbRight.TabIndex = 0;
            // 
            // btbLeftoRight
            // 
            this.btbLeftoRight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbLeftoRight.Location = new System.Drawing.Point(254, 27);
            this.btbLeftoRight.Name = "btbLeftoRight";
            this.btbLeftoRight.Size = new System.Drawing.Size(75, 43);
            this.btbLeftoRight.TabIndex = 2;
            this.btbLeftoRight.Text = ">>";
            this.btbLeftoRight.UseVisualStyleBackColor = true;
            this.btbLeftoRight.Click += new System.EventHandler(this.btbLeftoRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(254, 78);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 43);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = ">";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(254, 129);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 43);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "<";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRighttoLeft
            // 
            this.btnRighttoLeft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRighttoLeft.Location = new System.Drawing.Point(254, 180);
            this.btnRighttoLeft.Name = "btnRighttoLeft";
            this.btnRighttoLeft.Size = new System.Drawing.Size(75, 43);
            this.btnRighttoLeft.TabIndex = 2;
            this.btnRighttoLeft.Text = "<<";
            this.btnRighttoLeft.UseVisualStyleBackColor = true;
            this.btnRighttoLeft.Click += new System.EventHandler(this.btnRighttoLeft_Click);
            // 
            // light1
            // 
            this.light1.ItemONOFF = "OFF";
            this.light1.ItemsImage = global::WindowsFormsK4.Properties.Resources.Light_Off;
            this.light1.Location = new System.Drawing.Point(292, 308);
            this.light1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.light1.Name = "light1";
            this.light1.Size = new System.Drawing.Size(55, 75);
            this.light1.TabIndex = 3;
            // 
            // FrmDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 505);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.btnRighttoLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btbLeftoRight);
            this.Controls.Add(this.btnSelectItems);
            this.Controls.Add(this.btnCheckSelect);
            this.Controls.Add(this.chklbRight);
            this.Controls.Add(this.chklbLeft);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDemo2";
            this.Text = "FrmDemo2";
            this.Load += new System.EventHandler(this.FrmDemo2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbLeft;
        private System.Windows.Forms.Button btnCheckSelect;
        private System.Windows.Forms.Button btnSelectItems;
        private System.Windows.Forms.CheckedListBox chklbRight;
        private System.Windows.Forms.Button btbLeftoRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRighttoLeft;
        private Control.Light light1;
    }
}