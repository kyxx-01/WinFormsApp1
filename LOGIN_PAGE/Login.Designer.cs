namespace WinFormsApp1.DISPLAY_PAGE
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            userPB = new PictureBox();
            label1 = new Label();
            SignInButton = new Button();
            userpasspanel = new Panel();
            EyeOpen = new Button();
            userpassTB = new TextBox();
            EyeClosed = new Button();
            panel1 = new Panel();
            useremailTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)userPB).BeginInit();
            userpasspanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userPB
            // 
            userPB.BackColor = Color.Transparent;
            userPB.Image = (Image)resources.GetObject("userPB.Image");
            userPB.Location = new Point(832, 145);
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
            label1.Location = new Point(916, 445);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.DarkSlateGray;
            SignInButton.FlatStyle = FlatStyle.Popup;
            SignInButton.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(928, 677);
            SignInButton.Margin = new Padding(4);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(95, 45);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // userpasspanel
            // 
            userpasspanel.BackColor = Color.Transparent;
            userpasspanel.Controls.Add(EyeOpen);
            userpasspanel.Controls.Add(userpassTB);
            userpasspanel.Controls.Add(EyeClosed);
            userpasspanel.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userpasspanel.Location = new Point(807, 575);
            userpasspanel.Margin = new Padding(4);
            userpasspanel.Name = "userpasspanel";
            userpasspanel.Size = new Size(340, 74);
            userpasspanel.TabIndex = 1;
            // 
            // EyeOpen
            // 
            EyeOpen.BackColor = SystemColors.Window;
            EyeOpen.BackgroundImage = (Image)resources.GetObject("EyeOpen.BackgroundImage");
            EyeOpen.BackgroundImageLayout = ImageLayout.Stretch;
            EyeOpen.FlatStyle = FlatStyle.Popup;
            EyeOpen.Location = new Point(270, 19);
            EyeOpen.Name = "EyeOpen";
            EyeOpen.Size = new Size(34, 35);
            EyeOpen.TabIndex = 5;
            EyeOpen.Text = "0";
            EyeOpen.UseVisualStyleBackColor = false;
            EyeOpen.Click += EyeOpen_Click_1;
            // 
            // userpassTB
            // 
            userpassTB.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userpassTB.Location = new Point(36, 20);
            userpassTB.Multiline = true;
            userpassTB.Name = "userpassTB";
            userpassTB.PasswordChar = '•';
            userpassTB.PlaceholderText = "Password";
            userpassTB.Size = new Size(267, 35);
            userpassTB.TabIndex = 0;
            userpassTB.TextChanged += userpassTB_TextChanged_1;
            // 
            // EyeClosed
            // 
            EyeClosed.BackColor = SystemColors.Window;
            EyeClosed.BackgroundImage = (Image)resources.GetObject("EyeClosed.BackgroundImage");
            EyeClosed.BackgroundImageLayout = ImageLayout.Stretch;
            EyeClosed.FlatStyle = FlatStyle.Popup;
            EyeClosed.Location = new Point(270, 20);
            EyeClosed.Name = "EyeClosed";
            EyeClosed.Size = new Size(34, 35);
            EyeClosed.TabIndex = 4;
            EyeClosed.Text = "0";
            EyeClosed.UseVisualStyleBackColor = false;
            EyeClosed.Click += EyeClosed_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(useremailTB);
            panel1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(807, 499);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 74);
            panel1.TabIndex = 6;
            // 
            // useremailTB
            // 
            useremailTB.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            useremailTB.Location = new Point(36, 22);
            useremailTB.Multiline = true;
            useremailTB.Name = "useremailTB";
            useremailTB.PlaceholderText = "Username";
            useremailTB.Size = new Size(267, 34);
            useremailTB.TabIndex = 0;
            useremailTB.TextChanged += useremailTB_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1032);
            Controls.Add(panel1);
            Controls.Add(userpasspanel);
            Controls.Add(SignInButton);
            Controls.Add(label1);
            Controls.Add(userPB);
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display_Page";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)userPB).EndInit();
            userpasspanel.ResumeLayout(false);
            userpasspanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userPB;
        private Label label1;
        private Button SignInButton;
        private Panel userpasspanel;
        private TextBox userpassTB;
        private Button EyeClosed;
        private Button EyeOpen;
        private Panel panel1;
        private TextBox useremailTB;
    }
}