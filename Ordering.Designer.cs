namespace WinFormsApp1
{
    partial class Ordering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordering));
            label1 = new Label();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Olarge = new NumericUpDown();
            Omedium = new NumericUpDown();
            Osmall = new NumericUpDown();
            panel3 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Blarge = new NumericUpDown();
            Bmedium = new NumericUpDown();
            Bsmall = new NumericUpDown();
            panel4 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            Alarge = new NumericUpDown();
            Amedium = new NumericUpDown();
            Asmall = new NumericUpDown();
            panel5 = new Panel();
            PreviewBox = new TextBox();
            totalbx = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cashbx = new TextBox();
            label4 = new Label();
            changebx = new TextBox();
            warningLabel = new Label();
            printbtn = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            receiptbx = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Olarge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Omedium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Osmall).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Blarge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bmedium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bsmall).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Alarge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Amedium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asmall).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(473, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 65);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(12, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 334);
            panel1.TabIndex = 1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(77, 201);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(85, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Apple Juice";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(77, 132);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Buko Juice";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(77, 73);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Orange Juice";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Olarge);
            panel2.Controls.Add(Omedium);
            panel2.Controls.Add(Osmall);
            panel2.Location = new Point(396, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 334);
            panel2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 219);
            label7.Name = "label7";
            label7.Size = new Size(132, 21);
            label7.TabIndex = 8;
            label7.Text = "Large              P59";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 142);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 7;
            label6.Text = " Medium        P39";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 60);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 6;
            label5.Text = "Small             P29";
            // 
            // Olarge
            // 
            Olarge.Location = new Point(206, 217);
            Olarge.Name = "Olarge";
            Olarge.Size = new Size(56, 23);
            Olarge.TabIndex = 5;
            Olarge.TextAlign = HorizontalAlignment.Center;
            // 
            // Omedium
            // 
            Omedium.Location = new Point(206, 141);
            Omedium.Name = "Omedium";
            Omedium.Size = new Size(56, 23);
            Omedium.TabIndex = 4;
            Omedium.TextAlign = HorizontalAlignment.Center;
            // 
            // Osmall
            // 
            Osmall.Location = new Point(206, 58);
            Osmall.Name = "Osmall";
            Osmall.Size = new Size(56, 23);
            Osmall.TabIndex = 3;
            Osmall.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(Blarge);
            panel3.Controls.Add(Bmedium);
            panel3.Controls.Add(Bsmall);
            panel3.Location = new Point(396, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(287, 334);
            panel3.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(66, 219);
            label8.Name = "label8";
            label8.Size = new Size(132, 21);
            label8.TabIndex = 14;
            label8.Text = "Large              P20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(66, 142);
            label9.Name = "label9";
            label9.Size = new Size(131, 21);
            label9.TabIndex = 13;
            label9.Text = " Medium        P15";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(66, 60);
            label10.Name = "label10";
            label10.Size = new Size(128, 21);
            label10.TabIndex = 12;
            label10.Text = "Small             P10";
            // 
            // Blarge
            // 
            Blarge.Location = new Point(206, 217);
            Blarge.Name = "Blarge";
            Blarge.Size = new Size(56, 23);
            Blarge.TabIndex = 11;
            Blarge.TextAlign = HorizontalAlignment.Center;
            // 
            // Bmedium
            // 
            Bmedium.Location = new Point(206, 141);
            Bmedium.Name = "Bmedium";
            Bmedium.Size = new Size(56, 23);
            Bmedium.TabIndex = 10;
            Bmedium.TextAlign = HorizontalAlignment.Center;
            // 
            // Bsmall
            // 
            Bsmall.Location = new Point(206, 58);
            Bsmall.Name = "Bsmall";
            Bsmall.Size = new Size(56, 23);
            Bsmall.TabIndex = 9;
            Bsmall.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(Alarge);
            panel4.Controls.Add(Amedium);
            panel4.Controls.Add(Asmall);
            panel4.Location = new Point(396, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(287, 334);
            panel4.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(66, 219);
            label11.Name = "label11";
            label11.Size = new Size(132, 21);
            label11.TabIndex = 14;
            label11.Text = "Large              P60";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(66, 142);
            label12.Name = "label12";
            label12.Size = new Size(131, 21);
            label12.TabIndex = 13;
            label12.Text = " Medium        P50";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(66, 60);
            label13.Name = "label13";
            label13.Size = new Size(128, 21);
            label13.TabIndex = 12;
            label13.Text = "Small             P30";
            // 
            // Alarge
            // 
            Alarge.Location = new Point(206, 217);
            Alarge.Name = "Alarge";
            Alarge.Size = new Size(56, 23);
            Alarge.TabIndex = 11;
            Alarge.TextAlign = HorizontalAlignment.Center;
            // 
            // Amedium
            // 
            Amedium.Location = new Point(206, 141);
            Amedium.Name = "Amedium";
            Amedium.Size = new Size(56, 23);
            Amedium.TabIndex = 10;
            Amedium.TextAlign = HorizontalAlignment.Center;
            // 
            // Asmall
            // 
            Asmall.Location = new Point(206, 58);
            Asmall.Name = "Asmall";
            Asmall.Size = new Size(56, 23);
            Asmall.TabIndex = 9;
            Asmall.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MistyRose;
            panel5.Controls.Add(PreviewBox);
            panel5.Location = new Point(773, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 334);
            panel5.TabIndex = 5;
            // 
            // PreviewBox
            // 
            PreviewBox.Location = new Point(10, 18);
            PreviewBox.Multiline = true;
            PreviewBox.Name = "PreviewBox";
            PreviewBox.ReadOnly = true;
            PreviewBox.Size = new Size(265, 302);
            PreviewBox.TabIndex = 0;
            // 
            // totalbx
            // 
            totalbx.Location = new Point(108, 506);
            totalbx.Name = "totalbx";
            totalbx.ReadOnly = true;
            totalbx.Size = new Size(100, 23);
            totalbx.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 509);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 550);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Cash:";
            // 
            // cashbx
            // 
            cashbx.Location = new Point(108, 547);
            cashbx.Name = "cashbx";
            cashbx.Size = new Size(100, 23);
            cashbx.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 596);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Change:";
            // 
            // changebx
            // 
            changebx.Location = new Point(108, 593);
            changebx.Name = "changebx";
            changebx.Size = new Size(100, 23);
            changebx.TabIndex = 10;
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.ForeColor = Color.Red;
            warningLabel.Location = new Point(214, 596);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(110, 15);
            warningLabel.TabIndex = 12;
            warningLabel.Text = "Insufficient Balance";
            warningLabel.Visible = false;
            // 
            // printbtn
            // 
            printbtn.Location = new Point(108, 622);
            printbtn.Name = "printbtn";
            printbtn.Size = new Size(86, 23);
            printbtn.TabIndex = 13;
            printbtn.Text = "Print Receipt";
            printbtn.UseVisualStyleBackColor = true;
            printbtn.Click += print_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // receiptbx
            // 
            receiptbx.Location = new Point(385, 506);
            receiptbx.Multiline = true;
            receiptbx.Name = "receiptbx";
            receiptbx.ScrollBars = ScrollBars.Vertical;
            receiptbx.Size = new Size(549, 183);
            receiptbx.TabIndex = 14;
            // 
            // Ordering
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1111, 701);
            Controls.Add(receiptbx);
            Controls.Add(printbtn);
            Controls.Add(warningLabel);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(changebx);
            Controls.Add(label3);
            Controls.Add(cashbx);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(totalbx);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Ordering";
            Text = "Ordering";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Olarge).EndInit();
            ((System.ComponentModel.ISupportInitialize)Omedium).EndInit();
            ((System.ComponentModel.ISupportInitialize)Osmall).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Blarge).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bmedium).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bsmall).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Alarge).EndInit();
            ((System.ComponentModel.ISupportInitialize)Amedium).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asmall).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown Olarge;
        private NumericUpDown Omedium;
        private NumericUpDown Osmall;
        private Panel panel5;
        private TextBox PreviewBox;
        private TextBox totalbx;
        private Label label2;
        private Label label3;
        private TextBox cashbx;
        private Label label4;
        private TextBox changebx;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown Blarge;
        private NumericUpDown Bmedium;
        private NumericUpDown Bsmall;
        private Label label11;
        private Label label12;
        private Label label13;
        private NumericUpDown Alarge;
        private NumericUpDown Amedium;
        private NumericUpDown Asmall;
        private Label warningLabel;
        private Button printbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private TextBox receiptbx;
    }
}