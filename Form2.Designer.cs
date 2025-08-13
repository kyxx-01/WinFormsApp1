    namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(18, 582);
            button1.Name = "button1";
            button1.Size = new Size(510, 118);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(20, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 189);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(481, 32);
            label1.TabIndex = 5;
            label1.Text = "TAMBA, JOHN RICHTER CLYDE D.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label4.Location = new Point(22, 153);
            label4.Name = "label4";
            label4.Size = new Size(395, 32);
            label4.TabIndex = 8;
            label4.Text = "ALARCON, MARY GRACE L.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label2.Location = new Point(22, 65);
            label2.Name = "label2";
            label2.Size = new Size(369, 32);
            label2.TabIndex = 6;
            label2.Text = "ESTACIO, REXYL KYLE A.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label3.Location = new Point(22, 109);
            label3.Name = "label3";
            label3.Size = new Size(470, 32);
            label3.TabIndex = 7;
            label3.Text = "SEVILLANO, MARIA KRISTINA N. ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(883, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 716);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "ALARCON, MARY GRACE";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}