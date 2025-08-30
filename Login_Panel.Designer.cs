namespace WinFormsApp1
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            loginpanel = new Panel();
            LoginTxt = new TextBox();
            loginicopb = new PictureBox();
            panel1 = new Panel();
            PasswordTxt = new TextBox();
            passwordicopb = new PictureBox();
            Regbutton = new Button();
            loginbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginicopb).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordicopb).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 202);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            // 
            // loginpanel
            // 
            loginpanel.BackColor = Color.White;
            loginpanel.Controls.Add(LoginTxt);
            loginpanel.Controls.Add(loginicopb);
            loginpanel.Location = new Point(66, 249);
            loginpanel.Name = "loginpanel";
            loginpanel.Size = new Size(323, 58);
            loginpanel.TabIndex = 2;
            loginpanel.Paint += panel1_Paint;
            // 
            // LoginTxt
            // 
            LoginTxt.BorderStyle = BorderStyle.None;
            LoginTxt.ForeColor = Color.Black;
            LoginTxt.Location = new Point(54, 12);
            LoginTxt.Multiline = true;
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(254, 34);
            LoginTxt.TabIndex = 3;
            LoginTxt.TextChanged += LoginTxt_TextChanged;
            // 
            // loginicopb
            // 
            loginicopb.Image = (Image)resources.GetObject("loginicopb.Image");
            loginicopb.Location = new Point(8, 9);
            loginicopb.Name = "loginicopb";
            loginicopb.Size = new Size(40, 40);
            loginicopb.SizeMode = PictureBoxSizeMode.StretchImage;
            loginicopb.TabIndex = 3;
            loginicopb.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(PasswordTxt);
            panel1.Controls.Add(passwordicopb);
            panel1.Location = new Point(66, 329);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 4;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BorderStyle = BorderStyle.None;
            PasswordTxt.ForeColor = Color.Black;
            PasswordTxt.Location = new Point(54, 12);
            PasswordTxt.Multiline = true;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(254, 34);
            PasswordTxt.TabIndex = 3;
            // 
            // passwordicopb
            // 
            passwordicopb.Image = (Image)resources.GetObject("passwordicopb.Image");
            passwordicopb.Location = new Point(11, 12);
            passwordicopb.Name = "passwordicopb";
            passwordicopb.Size = new Size(30, 37);
            passwordicopb.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordicopb.TabIndex = 3;
            passwordicopb.TabStop = false;
            // 
            // Regbutton
            // 
            Regbutton.BackColor = SystemColors.ControlDark;
            Regbutton.Location = new Point(66, 429);
            Regbutton.Name = "Regbutton";
            Regbutton.Size = new Size(323, 44);
            Regbutton.TabIndex = 5;
            Regbutton.Text = "Register";
            Regbutton.UseVisualStyleBackColor = false;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = SystemColors.Highlight;
            loginbutton.Location = new Point(66, 495);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(323, 44);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(489, 648);
            Controls.Add(loginbutton);
            Controls.Add(Regbutton);
            Controls.Add(panel1);
            Controls.Add(loginpanel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginicopb).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordicopb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel loginpanel;
        private TextBox LoginTxt;
        private PictureBox loginicopb;
        private Panel panel1;
        private TextBox PasswordTxt;
        private PictureBox passwordicopb;
        private Button Regbutton;
        private Button loginbutton;
    }
}