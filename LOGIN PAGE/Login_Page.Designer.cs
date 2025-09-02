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
            AdminPB = new PictureBox();
            label1 = new Label();
            passwordpanel = new Panel();
            passwordTxt = new TextBox();
            passwordicopb = new PictureBox();
            registerbutton = new Button();
            loginbutton = new Button();
            loginicopb = new PictureBox();
            LoginPanel = new Panel();
            loginTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AdminPB).BeginInit();
            passwordpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordicopb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginicopb).BeginInit();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminPB
            // 
            AdminPB.BackColor = Color.Transparent;
            AdminPB.Image = (Image)resources.GetObject("AdminPB.Image");
            AdminPB.Location = new Point(136, 65);
            AdminPB.Name = "AdminPB";
            AdminPB.Size = new Size(189, 157);
            AdminPB.SizeMode = PictureBoxSizeMode.StretchImage;
            AdminPB.TabIndex = 0;
            AdminPB.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(191, 255);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 2;
            label1.Text = "Sign In";
            label1.Click += label1_Click;
            // 
            // passwordpanel
            // 
            passwordpanel.BackColor = Color.Honeydew;
            passwordpanel.Controls.Add(passwordTxt);
            passwordpanel.Controls.Add(passwordicopb);
            passwordpanel.Location = new Point(67, 384);
            passwordpanel.Name = "passwordpanel";
            passwordpanel.Size = new Size(323, 58);
            passwordpanel.TabIndex = 4;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.Honeydew;
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.ForeColor = Color.Black;
            passwordTxt.Location = new Point(55, 16);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '•';
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(249, 28);
            passwordTxt.TabIndex = 9;
            // 
            // passwordicopb
            // 
            passwordicopb.Image = (Image)resources.GetObject("passwordicopb.Image");
            passwordicopb.Location = new Point(17, 11);
            passwordicopb.Name = "passwordicopb";
            passwordicopb.Size = new Size(27, 38);
            passwordicopb.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordicopb.TabIndex = 3;
            passwordicopb.TabStop = false;
            // 
            // registerbutton
            // 
            registerbutton.BackColor = Color.SeaGreen;
            registerbutton.Location = new Point(67, 485);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(323, 39);
            registerbutton.TabIndex = 5;
            registerbutton.Text = "Register";
            registerbutton.UseVisualStyleBackColor = false;
            registerbutton.Click += registerbutton_Click;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.SeaGreen;
            loginbutton.Location = new Point(67, 543);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(323, 39);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // loginicopb
            // 
            loginicopb.Image = (Image)resources.GetObject("loginicopb.Image");
            loginicopb.Location = new Point(11, 10);
            loginicopb.Name = "loginicopb";
            loginicopb.Size = new Size(40, 40);
            loginicopb.SizeMode = PictureBoxSizeMode.StretchImage;
            loginicopb.TabIndex = 3;
            loginicopb.TabStop = false;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.Honeydew;
            LoginPanel.Controls.Add(loginTxt);
            LoginPanel.Controls.Add(loginicopb);
            LoginPanel.Cursor = Cursors.IBeam;
            LoginPanel.Location = new Point(67, 309);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(323, 58);
            LoginPanel.TabIndex = 1;
            LoginPanel.Paint += LoginPanel_Paint;
            // 
            // loginTxt
            // 
            loginTxt.BackColor = Color.Honeydew;
            loginTxt.BorderStyle = BorderStyle.None;
            loginTxt.ForeColor = Color.Black;
            loginTxt.Location = new Point(57, 16);
            loginTxt.Multiline = true;
            loginTxt.Name = "loginTxt";
            loginTxt.PlaceholderText = "Username";
            loginTxt.Size = new Size(249, 28);
            loginTxt.TabIndex = 8;
            loginTxt.TextChanged += loginTxt_TextChanged;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(489, 648);
            Controls.Add(loginbutton);
            Controls.Add(registerbutton);
            Controls.Add(passwordpanel);
            Controls.Add(label1);
            Controls.Add(LoginPanel);
            Controls.Add(AdminPB);
            DoubleBuffered = true;
            Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Page";
            Load += Login_Page_Load;
            ((System.ComponentModel.ISupportInitialize)AdminPB).EndInit();
            passwordpanel.ResumeLayout(false);
            passwordpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordicopb).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginicopb).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AdminPB;
        private Label label1;
        private Panel passwordpanel;
        private PictureBox passwordicopb;
        private Button registerbutton;
        private Button loginbutton;
        private PictureBox loginicopb;
        private Panel LoginPanel;
        private TextBox loginTxt;
        private TextBox passwordTxt;
    }
}