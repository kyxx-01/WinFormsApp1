namespace WinFormsApp1
{
    partial class calcu
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
            NUM7 = new Button();
            NUM8 = new Button();
            NUM9 = new Button();
            BUTTONDIV = new Button();
            BUTTONCLEAR = new Button();
            NUM4 = new Button();
            NUM5 = new Button();
            NUM6 = new Button();
            BUTTONMULT = new Button();
            BUTTONDEL = new Button();
            BUTTONEQUAL = new Button();
            BUTTONADD = new Button();
            BUTTONDEC = new Button();
            NUM0 = new Button();
            BUTTONSUBT = new Button();
            NUM3 = new Button();
            NUM2 = new Button();
            NUM1 = new Button();
            textBox_Result = new TextBox();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // NUM7
            // 
            NUM7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM7.Location = new Point(12, 160);
            NUM7.Name = "NUM7";
            NUM7.Size = new Size(77, 77);
            NUM7.TabIndex = 0;
            NUM7.Text = "7";
            NUM7.UseVisualStyleBackColor = true;
            NUM7.Click += button_click;
            // 
            // NUM8
            // 
            NUM8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM8.Location = new Point(95, 160);
            NUM8.Name = "NUM8";
            NUM8.Size = new Size(77, 77);
            NUM8.TabIndex = 1;
            NUM8.Text = "8";
            NUM8.UseVisualStyleBackColor = true;
            NUM8.Click += button_click;
            // 
            // NUM9
            // 
            NUM9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM9.Location = new Point(178, 160);
            NUM9.Name = "NUM9";
            NUM9.Size = new Size(77, 77);
            NUM9.TabIndex = 2;
            NUM9.Text = "9";
            NUM9.UseVisualStyleBackColor = true;
            NUM9.Click += button_click;
            // 
            // BUTTONDIV
            // 
            BUTTONDIV.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONDIV.Location = new Point(261, 160);
            BUTTONDIV.Name = "BUTTONDIV";
            BUTTONDIV.Size = new Size(77, 77);
            BUTTONDIV.TabIndex = 3;
            BUTTONDIV.Text = "/";
            BUTTONDIV.UseVisualStyleBackColor = true;
            BUTTONDIV.Click += operator_click;
            // 
            // BUTTONCLEAR
            // 
            BUTTONCLEAR.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONCLEAR.Location = new Point(344, 160);
            BUTTONCLEAR.Name = "BUTTONCLEAR";
            BUTTONCLEAR.Size = new Size(77, 77);
            BUTTONCLEAR.TabIndex = 4;
            BUTTONCLEAR.Text = "CE";
            BUTTONCLEAR.UseVisualStyleBackColor = true;
            BUTTONCLEAR.Click += BUTTONCLEAR_Click;
            // 
            // NUM4
            // 
            NUM4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM4.Location = new Point(12, 243);
            NUM4.Name = "NUM4";
            NUM4.Size = new Size(77, 77);
            NUM4.TabIndex = 5;
            NUM4.Text = "4";
            NUM4.UseVisualStyleBackColor = true;
            NUM4.Click += button_click;
            // 
            // NUM5
            // 
            NUM5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM5.Location = new Point(95, 243);
            NUM5.Name = "NUM5";
            NUM5.Size = new Size(77, 77);
            NUM5.TabIndex = 6;
            NUM5.Text = "5";
            NUM5.UseVisualStyleBackColor = true;
            NUM5.Click += button_click;
            // 
            // NUM6
            // 
            NUM6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM6.Location = new Point(178, 243);
            NUM6.Name = "NUM6";
            NUM6.Size = new Size(77, 77);
            NUM6.TabIndex = 7;
            NUM6.Text = "6";
            NUM6.UseVisualStyleBackColor = true;
            NUM6.Click += button_click;
            // 
            // BUTTONMULT
            // 
            BUTTONMULT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONMULT.Location = new Point(261, 243);
            BUTTONMULT.Name = "BUTTONMULT";
            BUTTONMULT.Size = new Size(77, 77);
            BUTTONMULT.TabIndex = 8;
            BUTTONMULT.Text = "*";
            BUTTONMULT.UseVisualStyleBackColor = true;
            BUTTONMULT.Click += operator_click;
            // 
            // BUTTONDEL
            // 
            BUTTONDEL.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONDEL.Location = new Point(344, 243);
            BUTTONDEL.Name = "BUTTONDEL";
            BUTTONDEL.Size = new Size(77, 77);
            BUTTONDEL.TabIndex = 9;
            BUTTONDEL.Text = "DEL";
            BUTTONDEL.UseVisualStyleBackColor = true;
            BUTTONDEL.Click += BUTTONDEL_Click;
            // 
            // BUTTONEQUAL
            // 
            BUTTONEQUAL.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONEQUAL.Location = new Point(344, 326);
            BUTTONEQUAL.Name = "BUTTONEQUAL";
            BUTTONEQUAL.Size = new Size(77, 160);
            BUTTONEQUAL.TabIndex = 19;
            BUTTONEQUAL.Text = "=";
            BUTTONEQUAL.UseVisualStyleBackColor = true;
            BUTTONEQUAL.Click += BUTTONEQUAL_Click;
            // 
            // BUTTONADD
            // 
            BUTTONADD.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONADD.Location = new Point(261, 409);
            BUTTONADD.Name = "BUTTONADD";
            BUTTONADD.Size = new Size(77, 77);
            BUTTONADD.TabIndex = 18;
            BUTTONADD.Text = "+";
            BUTTONADD.UseVisualStyleBackColor = true;
            BUTTONADD.Click += operator_click;
            // 
            // BUTTONDEC
            // 
            BUTTONDEC.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONDEC.Location = new Point(178, 409);
            BUTTONDEC.Name = "BUTTONDEC";
            BUTTONDEC.Size = new Size(77, 77);
            BUTTONDEC.TabIndex = 17;
            BUTTONDEC.Text = ".";
            BUTTONDEC.UseVisualStyleBackColor = true;
            BUTTONDEC.Click += button_click;
            // 
            // NUM0
            // 
            NUM0.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM0.Location = new Point(12, 409);
            NUM0.Name = "NUM0";
            NUM0.Size = new Size(160, 77);
            NUM0.TabIndex = 15;
            NUM0.Text = "0";
            NUM0.UseVisualStyleBackColor = true;
            NUM0.Click += button_click;
            // 
            // BUTTONSUBT
            // 
            BUTTONSUBT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONSUBT.Location = new Point(261, 326);
            BUTTONSUBT.Name = "BUTTONSUBT";
            BUTTONSUBT.Size = new Size(77, 77);
            BUTTONSUBT.TabIndex = 13;
            BUTTONSUBT.Text = "-";
            BUTTONSUBT.UseVisualStyleBackColor = true;
            BUTTONSUBT.Click += operator_click;
            // 
            // NUM3
            // 
            NUM3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM3.Location = new Point(178, 326);
            NUM3.Name = "NUM3";
            NUM3.Size = new Size(77, 77);
            NUM3.TabIndex = 12;
            NUM3.Text = "3";
            NUM3.UseVisualStyleBackColor = true;
            NUM3.Click += button_click;
            // 
            // NUM2
            // 
            NUM2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM2.Location = new Point(95, 326);
            NUM2.Name = "NUM2";
            NUM2.Size = new Size(77, 77);
            NUM2.TabIndex = 11;
            NUM2.Text = "2";
            NUM2.UseVisualStyleBackColor = true;
            NUM2.Click += button_click;
            // 
            // NUM1
            // 
            NUM1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM1.Location = new Point(12, 326);
            NUM1.Name = "NUM1";
            NUM1.Size = new Size(77, 77);
            NUM1.TabIndex = 10;
            NUM1.Text = "1";
            NUM1.UseVisualStyleBackColor = true;
            NUM1.Click += button_click;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Result.Location = new Point(12, 79);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(411, 61);
            textBox_Result.TabIndex = 20;
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.BackColor = SystemColors.ButtonShadow;
            labelCurrentOperation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentOperation.Location = new Point(12, 48);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 28);
            labelCurrentOperation.TabIndex = 21;
            // 
            // calcu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 491);
            Controls.Add(labelCurrentOperation);
            Controls.Add(textBox_Result);
            Controls.Add(BUTTONEQUAL);
            Controls.Add(BUTTONADD);
            Controls.Add(BUTTONDEC);
            Controls.Add(NUM0);
            Controls.Add(BUTTONSUBT);
            Controls.Add(NUM3);
            Controls.Add(NUM2);
            Controls.Add(NUM1);
            Controls.Add(BUTTONDEL);
            Controls.Add(BUTTONMULT);
            Controls.Add(NUM6);
            Controls.Add(NUM5);
            Controls.Add(NUM4);
            Controls.Add(BUTTONCLEAR);
            Controls.Add(BUTTONDIV);
            Controls.Add(NUM9);
            Controls.Add(NUM8);
            Controls.Add(NUM7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "calcu";
            Text = "Calculator";
            Load += calcu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NUM7;
        private Button NUM8;
        private Button NUM9;
        private Button BUTTONDIV;
        private Button BUTTONCLEAR;
        private Button NUM4;
        private Button NUM5;
        private Button NUM6;
        private Button BUTTONMULT;
        private Button BUTTONDEL;
        private Button BUTTONEQUAL;
        private Button BUTTONADD;
        private Button BUTTONDEC;
        private Button NUM0;
        private Button BUTTONSUBT;
        private Button NUM3;
        private Button NUM2;
        private Button NUM1;
        private TextBox textBox_Result;
        private Label labelCurrentOperation;
    }
}