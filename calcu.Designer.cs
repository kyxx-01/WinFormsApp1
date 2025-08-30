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
            button1 = new Button();
            SuspendLayout();
            // 
            // NUM7
            // 
            NUM7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM7.Location = new Point(10, 120);
            NUM7.Margin = new Padding(3, 2, 3, 2);
            NUM7.Name = "NUM7";
            NUM7.Size = new Size(67, 58);
            NUM7.TabIndex = 0;
            NUM7.Text = "7";
            NUM7.UseVisualStyleBackColor = true;
            NUM7.Click += button_click;
            // 
            // NUM8
            // 
            NUM8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM8.Location = new Point(83, 120);
            NUM8.Margin = new Padding(3, 2, 3, 2);
            NUM8.Name = "NUM8";
            NUM8.Size = new Size(67, 58);
            NUM8.TabIndex = 1;
            NUM8.Text = "8";
            NUM8.UseVisualStyleBackColor = true;
            NUM8.Click += button_click;
            // 
            // NUM9
            // 
            NUM9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM9.Location = new Point(156, 120);
            NUM9.Margin = new Padding(3, 2, 3, 2);
            NUM9.Name = "NUM9";
            NUM9.Size = new Size(67, 58);
            NUM9.TabIndex = 2;
            NUM9.Text = "9";
            NUM9.UseVisualStyleBackColor = true;
            NUM9.Click += button_click;
            // 
            // BUTTONDIV
            // 
            BUTTONDIV.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONDIV.Location = new Point(228, 120);
            BUTTONDIV.Margin = new Padding(3, 2, 3, 2);
            BUTTONDIV.Name = "BUTTONDIV";
            BUTTONDIV.Size = new Size(67, 58);
            BUTTONDIV.TabIndex = 3;
            BUTTONDIV.Text = "/";
            BUTTONDIV.UseVisualStyleBackColor = true;
            BUTTONDIV.Click += operator_click;
            // 
            // BUTTONCLEAR
            // 
            BUTTONCLEAR.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONCLEAR.Location = new Point(301, 120);
            BUTTONCLEAR.Margin = new Padding(3, 2, 3, 2);
            BUTTONCLEAR.Name = "BUTTONCLEAR";
            BUTTONCLEAR.Size = new Size(67, 58);
            BUTTONCLEAR.TabIndex = 4;
            BUTTONCLEAR.Text = "CE";
            BUTTONCLEAR.UseVisualStyleBackColor = true;
            BUTTONCLEAR.Click += BUTTONCLEAR_Click;
            // 
            // NUM4
            // 
            NUM4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM4.Location = new Point(10, 182);
            NUM4.Margin = new Padding(3, 2, 3, 2);
            NUM4.Name = "NUM4";
            NUM4.Size = new Size(67, 58);
            NUM4.TabIndex = 5;
            NUM4.Text = "4";
            NUM4.UseVisualStyleBackColor = true;
            NUM4.Click += button_click;
            // 
            // NUM5
            // 
            NUM5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM5.Location = new Point(83, 182);
            NUM5.Margin = new Padding(3, 2, 3, 2);
            NUM5.Name = "NUM5";
            NUM5.Size = new Size(67, 58);
            NUM5.TabIndex = 6;
            NUM5.Text = "5";
            NUM5.UseVisualStyleBackColor = true;
            NUM5.Click += button_click;
            // 
            // NUM6
            // 
            NUM6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM6.Location = new Point(156, 182);
            NUM6.Margin = new Padding(3, 2, 3, 2);
            NUM6.Name = "NUM6";
            NUM6.Size = new Size(67, 58);
            NUM6.TabIndex = 7;
            NUM6.Text = "6";
            NUM6.UseVisualStyleBackColor = true;
            NUM6.Click += button_click;
            // 
            // BUTTONMULT
            // 
            BUTTONMULT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONMULT.Location = new Point(228, 182);
            BUTTONMULT.Margin = new Padding(3, 2, 3, 2);
            BUTTONMULT.Name = "BUTTONMULT";
            BUTTONMULT.Size = new Size(67, 58);
            BUTTONMULT.TabIndex = 8;
            BUTTONMULT.Text = "*";
            BUTTONMULT.UseVisualStyleBackColor = true;
            BUTTONMULT.Click += operator_click;
            // 
            // BUTTONDEL
            // 
            BUTTONDEL.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONDEL.Location = new Point(301, 182);
            BUTTONDEL.Margin = new Padding(3, 2, 3, 2);
            BUTTONDEL.Name = "BUTTONDEL";
            BUTTONDEL.Size = new Size(67, 58);
            BUTTONDEL.TabIndex = 9;
            BUTTONDEL.Text = "DEL";
            BUTTONDEL.UseVisualStyleBackColor = true;
            BUTTONDEL.Click += BUTTONDEL_Click;
            // 
            // BUTTONEQUAL
            // 
            BUTTONEQUAL.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONEQUAL.Location = new Point(301, 244);
            BUTTONEQUAL.Margin = new Padding(3, 2, 3, 2);
            BUTTONEQUAL.Name = "BUTTONEQUAL";
            BUTTONEQUAL.Size = new Size(67, 120);
            BUTTONEQUAL.TabIndex = 19;
            BUTTONEQUAL.Text = "=";
            BUTTONEQUAL.UseVisualStyleBackColor = true;
            BUTTONEQUAL.Click += BUTTONEQUAL_Click;
            // 
            // BUTTONADD
            // 
            BUTTONADD.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONADD.Location = new Point(228, 307);
            BUTTONADD.Margin = new Padding(3, 2, 3, 2);
            BUTTONADD.Name = "BUTTONADD";
            BUTTONADD.Size = new Size(67, 58);
            BUTTONADD.TabIndex = 18;
            BUTTONADD.Text = "+";
            BUTTONADD.UseVisualStyleBackColor = true;
            BUTTONADD.Click += operator_click;
            // 
            // BUTTONDEC
            // 
            BUTTONDEC.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONDEC.Location = new Point(156, 307);
            BUTTONDEC.Margin = new Padding(3, 2, 3, 2);
            BUTTONDEC.Name = "BUTTONDEC";
            BUTTONDEC.Size = new Size(67, 58);
            BUTTONDEC.TabIndex = 17;
            BUTTONDEC.Text = ".";
            BUTTONDEC.UseVisualStyleBackColor = true;
            BUTTONDEC.Click += button_click;
            // 
            // NUM0
            // 
            NUM0.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM0.Location = new Point(10, 307);
            NUM0.Margin = new Padding(3, 2, 3, 2);
            NUM0.Name = "NUM0";
            NUM0.Size = new Size(140, 58);
            NUM0.TabIndex = 15;
            NUM0.Text = "0";
            NUM0.UseVisualStyleBackColor = true;
            NUM0.Click += button_click;
            // 
            // BUTTONSUBT
            // 
            BUTTONSUBT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONSUBT.Location = new Point(228, 244);
            BUTTONSUBT.Margin = new Padding(3, 2, 3, 2);
            BUTTONSUBT.Name = "BUTTONSUBT";
            BUTTONSUBT.Size = new Size(67, 58);
            BUTTONSUBT.TabIndex = 13;
            BUTTONSUBT.Text = "-";
            BUTTONSUBT.UseVisualStyleBackColor = true;
            BUTTONSUBT.Click += operator_click;
            // 
            // NUM3
            // 
            NUM3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM3.Location = new Point(156, 244);
            NUM3.Margin = new Padding(3, 2, 3, 2);
            NUM3.Name = "NUM3";
            NUM3.Size = new Size(67, 58);
            NUM3.TabIndex = 12;
            NUM3.Text = "3";
            NUM3.UseVisualStyleBackColor = true;
            NUM3.Click += button_click;
            // 
            // NUM2
            // 
            NUM2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM2.Location = new Point(83, 244);
            NUM2.Margin = new Padding(3, 2, 3, 2);
            NUM2.Name = "NUM2";
            NUM2.Size = new Size(67, 58);
            NUM2.TabIndex = 11;
            NUM2.Text = "2";
            NUM2.UseVisualStyleBackColor = true;
            NUM2.Click += button_click;
            // 
            // NUM1
            // 
            NUM1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUM1.Location = new Point(10, 244);
            NUM1.Margin = new Padding(3, 2, 3, 2);
            NUM1.Name = "NUM1";
            NUM1.Size = new Size(67, 58);
            NUM1.TabIndex = 10;
            NUM1.Text = "1";
            NUM1.UseVisualStyleBackColor = true;
            NUM1.Click += button_click;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Result.Location = new Point(10, 59);
            textBox_Result.Margin = new Padding(3, 2, 3, 2);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(360, 50);
            textBox_Result.TabIndex = 20;
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.BackColor = SystemColors.ButtonShadow;
            labelCurrentOperation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentOperation.Location = new Point(10, 36);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 21);
            labelCurrentOperation.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(301, 3);
            button1.Name = "button1";
            button1.Size = new Size(69, 29);
            button1.TabIndex = 22;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // calcu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 368);
            Controls.Add(button1);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button1;
    }
}