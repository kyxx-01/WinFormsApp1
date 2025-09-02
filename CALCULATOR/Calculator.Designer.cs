namespace WinFormsApp1
{
    partial class Calculator
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
            textBox_Result = new TextBox();
            buttondecimal = new Button();
            button0 = new Button();
            buttonEqual = new Button();
            buttondivide = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonmultiply = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            buttonsubract = new Button();
            buttonclear = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonadd = new Button();
            buttonreturn = new Button();
            SuspendLayout();
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Result.Location = new Point(24, 50);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(382, 76);
            textBox_Result.TabIndex = 0;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // buttondecimal
            // 
            buttondecimal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            buttondecimal.Location = new Point(24, 512);
            buttondecimal.Name = "buttondecimal";
            buttondecimal.Size = new Size(91, 114);
            buttondecimal.TabIndex = 1;
            buttondecimal.Text = ".";
            buttondecimal.UseVisualStyleBackColor = true;
            buttondecimal.Click += button_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button0.Location = new Point(121, 512);
            button0.Name = "button0";
            button0.Size = new Size(91, 114);
            button0.TabIndex = 2;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            buttonEqual.Location = new Point(218, 512);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(91, 114);
            buttonEqual.TabIndex = 3;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttondivide
            // 
            buttondivide.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            buttondivide.Location = new Point(315, 512);
            buttondivide.Name = "buttondivide";
            buttondivide.Size = new Size(91, 114);
            buttondivide.TabIndex = 4;
            buttondivide.Text = "/";
            buttondivide.UseVisualStyleBackColor = true;
            buttondivide.Click += operator_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button1.Location = new Point(24, 392);
            button1.Name = "button1";
            button1.Size = new Size(91, 114);
            button1.TabIndex = 5;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button2.Location = new Point(121, 392);
            button2.Name = "button2";
            button2.Size = new Size(91, 114);
            button2.TabIndex = 6;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button3.Location = new Point(218, 392);
            button3.Name = "button3";
            button3.Size = new Size(91, 114);
            button3.TabIndex = 7;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // buttonmultiply
            // 
            buttonmultiply.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            buttonmultiply.Location = new Point(315, 392);
            buttonmultiply.Name = "buttonmultiply";
            buttonmultiply.Size = new Size(91, 114);
            buttonmultiply.TabIndex = 8;
            buttonmultiply.Text = "*";
            buttonmultiply.UseVisualStyleBackColor = true;
            buttonmultiply.Click += operator_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button4.Location = new Point(24, 272);
            button4.Name = "button4";
            button4.Size = new Size(91, 114);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button6.Location = new Point(218, 272);
            button6.Name = "button6";
            button6.Size = new Size(91, 114);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button5.Location = new Point(121, 272);
            button5.Name = "button5";
            button5.Size = new Size(91, 114);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // buttonsubract
            // 
            buttonsubract.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            buttonsubract.Location = new Point(314, 272);
            buttonsubract.Name = "buttonsubract";
            buttonsubract.Size = new Size(91, 114);
            buttonsubract.TabIndex = 11;
            buttonsubract.Text = "-";
            buttonsubract.UseVisualStyleBackColor = true;
            buttonsubract.Click += operator_Click;
            // 
            // buttonclear
            // 
            buttonclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonclear.Location = new Point(24, 632);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(91, 114);
            buttonclear.TabIndex = 12;
            buttonclear.Text = "CLEAR";
            buttonclear.UseVisualStyleBackColor = true;
            buttonclear.Click += buttonClear_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button7.Location = new Point(24, 152);
            button7.Name = "button7";
            button7.Size = new Size(91, 114);
            button7.TabIndex = 13;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button8.Location = new Point(121, 152);
            button8.Name = "button8";
            button8.Size = new Size(91, 114);
            button8.TabIndex = 14;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button9.Location = new Point(218, 152);
            button9.Name = "button9";
            button9.Size = new Size(91, 114);
            button9.TabIndex = 15;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // buttonadd
            // 
            buttonadd.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            buttonadd.Location = new Point(314, 152);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(91, 114);
            buttonadd.TabIndex = 16;
            buttonadd.Text = "+ ";
            buttonadd.UseVisualStyleBackColor = true;
            buttonadd.Click += operator_Click;
            // 
            // buttonreturn
            // 
            buttonreturn.Location = new Point(300, 647);
            buttonreturn.Name = "buttonreturn";
            buttonreturn.Size = new Size(105, 92);
            buttonreturn.TabIndex = 17;
            buttonreturn.Text = "RETURN";
            buttonreturn.UseVisualStyleBackColor = true;
            buttonreturn.Click += button10_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 758);
            Controls.Add(buttonreturn);
            Controls.Add(buttonadd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonclear);
            Controls.Add(buttonsubract);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(buttonmultiply);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttondivide);
            Controls.Add(buttonEqual);
            Controls.Add(button0);
            Controls.Add(buttondecimal);
            Controls.Add(textBox_Result);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Result;
        private Button buttondecimal;
        private Button button0;
        private Button buttonEqual;
        private Button buttondivide;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonmultiply;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button buttonsubract;
        private Button buttonclear;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonadd;
        private Button buttonreturn;
    }
}