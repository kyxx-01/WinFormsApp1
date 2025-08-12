namespace WinFormsApp1
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox_Display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // textBox_Display
            // 
            this.textBox_Display.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.textBox_Display.Location = new System.Drawing.Point(12, 12);
            this.textBox_Display.Name = "textBox_Display";
            this.textBox_Display.ReadOnly = true;
            this.textBox_Display.Size = new System.Drawing.Size(318, 39);
            this.textBox_Display.TabIndex = 0;
            this.textBox_Display.Text = "0";
            this.textBox_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Create buttons
            string[] buttonLabels = {
                "7","8","9","/",
                "4","5","6","*",
                "1","2","3","-",
                "0",".","=","+",
                "C","BACK"
            };

            int x = 12, y = 60;
            int count = 0;
            for (int i = 0; i < buttonLabels.Length; i++)
            {
                var btn = new System.Windows.Forms.Button();
                btn.Text = buttonLabels[i];
                btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                btn.Size = new System.Drawing.Size(85, 50);
                btn.Location = new System.Drawing.Point(x, y);

                // Assign click events later in Form_Load
                btn.Name = "btn_" + buttonLabels[i];

                this.Controls.Add(btn);

                x += 80;
                count++;
                if (count % 4 == 0)
                {
                    x = 12;
                    y += 55;
                }
            }

            // 
            // CalculatorForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.textBox_Display);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Display;
    }
}
