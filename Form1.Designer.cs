namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            MENU = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(972, 12);
            button1.Name = "button1";
            button1.Size = new Size(185, 59);
            button1.TabIndex = 0;
            button1.Text = "RETURN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(MENU);
            panel1.Location = new Point(62, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 602);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(615, 365);
            button6.Name = "button6";
            button6.Size = new Size(311, 104);
            button6.TabIndex = 4;
            button6.Text = "ALARCON, MARY GRACE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(143, 365);
            button5.Name = "button5";
            button5.Size = new Size(311, 104);
            button5.TabIndex = 3;
            button5.Text = "SEVILLANO, MARIA KRISTINA";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(615, 168);
            button4.Name = "button4";
            button4.Size = new Size(311, 104);
            button4.TabIndex = 2;
            button4.Text = "TAMBA, JOHN RICHTER CLYDE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(143, 168);
            button3.Name = "button3";
            button3.Size = new Size(311, 104);
            button3.TabIndex = 1;
            button3.Text = "ESTACIO, REXYL KYLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MENU
            // 
            MENU.AutoSize = true;
            MENU.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MENU.Location = new Point(388, 29);
            MENU.Name = "MENU";
            MENU.Size = new Size(274, 90);
            MENU.TabIndex = 0;
            MENU.Text = "MENU";
            MENU.Click += MENU_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 716);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label MENU;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
    }
}
