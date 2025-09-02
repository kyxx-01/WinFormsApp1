namespace WinFormsApp1.DISPLAY_PAGE
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            userPB = new PictureBox();
            label1 = new Label();
            enterbutton = new Button();
            userpasspanel = new Panel();
            userpassTB = new TextBox();
            EyeClosed = new PictureBox();
            EyeOpen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userPB).BeginInit();
            userpasspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EyeClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EyeOpen).BeginInit();
            SuspendLayout();
            // 
            // userPB
            // 
            userPB.BackColor = Color.Transparent;
            userPB.Image = (Image)resources.GetObject("userPB.Image");
            userPB.Location = new Point(832, 179);
            userPB.Margin = new Padding(5, 4, 5, 4);
            userPB.Name = "userPB";
            userPB.Size = new Size(276, 270);
            userPB.SizeMode = PictureBoxSizeMode.StretchImage;
            userPB.TabIndex = 0;
            userPB.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(916, 455);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // enterbutton
            // 
            enterbutton.BackColor = Color.DarkSlateGray;
            enterbutton.FlatStyle = FlatStyle.Popup;
            enterbutton.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterbutton.ForeColor = Color.White;
            enterbutton.Location = new Point(929, 616);
            enterbutton.Margin = new Padding(4);
            enterbutton.Name = "enterbutton";
            enterbutton.Size = new Size(95, 45);
            enterbutton.TabIndex = 3;
            enterbutton.Text = "Enter";
            enterbutton.UseVisualStyleBackColor = false;
            enterbutton.Click += enterbutton_Click;
            // 
            // userpasspanel
            // 
            userpasspanel.BackColor = Color.Transparent;
            userpasspanel.Controls.Add(userpassTB);
            userpasspanel.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userpasspanel.Location = new Point(809, 526);
            userpasspanel.Margin = new Padding(4);
            userpasspanel.Name = "userpasspanel";
            userpasspanel.Size = new Size(340, 74);
            userpasspanel.TabIndex = 1;
            // 
            // userpassTB
            // 
            userpassTB.Location = new Point(48, 21);
            userpassTB.Multiline = true;
            userpassTB.Name = "userpassTB";
            userpassTB.PasswordChar = '•';
            userpassTB.Size = new Size(251, 34);
            userpassTB.TabIndex = 0;
            userpassTB.TextChanged += userpassTB_TextChanged_1;
            // 
            // EyeClosed
            // 
            EyeClosed.BackColor = Color.Black;
            EyeClosed.Image = (Image)resources.GetObject("EyeClosed.Image");
            EyeClosed.Location = new Point(1196, 547);
            EyeClosed.Name = "EyeClosed";
            EyeClosed.Size = new Size(34, 34);
            EyeClosed.SizeMode = PictureBoxSizeMode.StretchImage;
            EyeClosed.TabIndex = 5;
            EyeClosed.TabStop = false;
            // 
            // EyeOpen
            // 
            EyeOpen.BackColor = Color.Black;
            EyeOpen.Image = (Image)resources.GetObject("EyeOpen.Image");
            EyeOpen.Location = new Point(1156, 547);
            EyeOpen.Name = "EyeOpen";
            EyeOpen.Size = new Size(34, 34);
            EyeOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            EyeOpen.TabIndex = 4;
            EyeOpen.TabStop = false;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1032);
            Controls.Add(EyeClosed);
            Controls.Add(EyeOpen);
            Controls.Add(userpasspanel);
            Controls.Add(enterbutton);
            Controls.Add(label1);
            Controls.Add(userPB);
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Display";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display_Page";
            ((System.ComponentModel.ISupportInitialize)userPB).EndInit();
            userpasspanel.ResumeLayout(false);
            userpasspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EyeClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)EyeOpen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userPB;
        private Label label1;
        private Button enterbutton;
        private Panel userpasspanel;
        private TextBox userpassTB;
        private PictureBox EyeClosed;
        private PictureBox EyeOpen;
    }
}