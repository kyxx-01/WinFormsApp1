namespace WinFormsApp1
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            label1 = new Label();
            Fnamepanel = new Panel();
            Lnamepanel = new Panel();
            emailpanel = new Panel();
            passwordpanel = new Panel();
            conpasspanel = new Panel();
            Registerbutton = new Button();
            label2 = new Label();
            signinlinkLabel = new LinkLabel();
            FnameTB = new TextBox();
            LnameTB = new TextBox();
            EmailTB = new TextBox();
            ConpassTB = new TextBox();
            PaasowrdTB = new TextBox();
            Fnamepanel.SuspendLayout();
            Lnamepanel.SuspendLayout();
            emailpanel.SuspendLayout();
            passwordpanel.SuspendLayout();
            conpasspanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(195, 57);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // Fnamepanel
            // 
            Fnamepanel.BackColor = Color.Honeydew;
            Fnamepanel.Controls.Add(FnameTB);
            Fnamepanel.Location = new Point(30, 124);
            Fnamepanel.Name = "Fnamepanel";
            Fnamepanel.Size = new Size(188, 59);
            Fnamepanel.TabIndex = 1;
            // 
            // Lnamepanel
            // 
            Lnamepanel.BackColor = Color.Honeydew;
            Lnamepanel.Controls.Add(LnameTB);
            Lnamepanel.Location = new Point(258, 124);
            Lnamepanel.Name = "Lnamepanel";
            Lnamepanel.Size = new Size(188, 59);
            Lnamepanel.TabIndex = 2;
            // 
            // emailpanel
            // 
            emailpanel.BackColor = Color.Honeydew;
            emailpanel.Controls.Add(EmailTB);
            emailpanel.Location = new Point(30, 212);
            emailpanel.Name = "emailpanel";
            emailpanel.Size = new Size(416, 77);
            emailpanel.TabIndex = 3;
            // 
            // passwordpanel
            // 
            passwordpanel.BackColor = Color.Honeydew;
            passwordpanel.Controls.Add(PaasowrdTB);
            passwordpanel.Location = new Point(30, 315);
            passwordpanel.Name = "passwordpanel";
            passwordpanel.Size = new Size(416, 77);
            passwordpanel.TabIndex = 4;
            // 
            // conpasspanel
            // 
            conpasspanel.BackColor = Color.Honeydew;
            conpasspanel.Controls.Add(ConpassTB);
            conpasspanel.Location = new Point(30, 413);
            conpasspanel.Name = "conpasspanel";
            conpasspanel.Size = new Size(416, 77);
            conpasspanel.TabIndex = 5;
            // 
            // Registerbutton
            // 
            Registerbutton.BackColor = Color.SeaGreen;
            Registerbutton.Location = new Point(30, 515);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(416, 57);
            Registerbutton.TabIndex = 6;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 592);
            label2.Name = "label2";
            label2.Size = new Size(206, 23);
            label2.TabIndex = 7;
            label2.Text = "Already have an account?";
            // 
            // signinlinkLabel
            // 
            signinlinkLabel.AutoSize = true;
            signinlinkLabel.BackColor = Color.Transparent;
            signinlinkLabel.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signinlinkLabel.LinkColor = Color.SeaGreen;
            signinlinkLabel.Location = new Point(292, 592);
            signinlinkLabel.Name = "signinlinkLabel";
            signinlinkLabel.Size = new Size(64, 23);
            signinlinkLabel.TabIndex = 8;
            signinlinkLabel.TabStop = true;
            signinlinkLabel.Text = "Sign In";
            // 
            // FnameTB
            // 
            FnameTB.BackColor = Color.Honeydew;
            FnameTB.BorderStyle = BorderStyle.None;
            FnameTB.Location = new Point(10, 12);
            FnameTB.Multiline = true;
            FnameTB.Name = "FnameTB";
            FnameTB.PlaceholderText = "Firstname";
            FnameTB.Size = new Size(166, 36);
            FnameTB.TabIndex = 0;
            // 
            // LnameTB
            // 
            LnameTB.BackColor = Color.Honeydew;
            LnameTB.BorderStyle = BorderStyle.None;
            LnameTB.Location = new Point(12, 12);
            LnameTB.Multiline = true;
            LnameTB.Name = "LnameTB";
            LnameTB.PlaceholderText = "Lastname";
            LnameTB.Size = new Size(166, 36);
            LnameTB.TabIndex = 1;
            // 
            // EmailTB
            // 
            EmailTB.BackColor = Color.Honeydew;
            EmailTB.BorderStyle = BorderStyle.None;
            EmailTB.Location = new Point(17, 20);
            EmailTB.Multiline = true;
            EmailTB.Name = "EmailTB";
            EmailTB.PlaceholderText = "Email";
            EmailTB.Size = new Size(384, 35);
            EmailTB.TabIndex = 0;
            // 
            // ConpassTB
            // 
            ConpassTB.BackColor = Color.Honeydew;
            ConpassTB.BorderStyle = BorderStyle.None;
            ConpassTB.Location = new Point(17, 22);
            ConpassTB.Multiline = true;
            ConpassTB.Name = "ConpassTB";
            ConpassTB.PlaceholderText = "Confirm Password";
            ConpassTB.Size = new Size(384, 35);
            ConpassTB.TabIndex = 1;
            ConpassTB.TextChanged += textBox1_TextChanged;
            // 
            // PaasowrdTB
            // 
            PaasowrdTB.BackColor = Color.Honeydew;
            PaasowrdTB.BorderStyle = BorderStyle.None;
            PaasowrdTB.Location = new Point(16, 23);
            PaasowrdTB.Multiline = true;
            PaasowrdTB.Name = "PaasowrdTB";
            PaasowrdTB.PlaceholderText = "Password";
            PaasowrdTB.Size = new Size(384, 35);
            PaasowrdTB.TabIndex = 2;
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(489, 648);
            Controls.Add(signinlinkLabel);
            Controls.Add(label2);
            Controls.Add(Registerbutton);
            Controls.Add(conpasspanel);
            Controls.Add(passwordpanel);
            Controls.Add(emailpanel);
            Controls.Add(Lnamepanel);
            Controls.Add(Fnamepanel);
            Controls.Add(label1);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration_Form";
            Fnamepanel.ResumeLayout(false);
            Fnamepanel.PerformLayout();
            Lnamepanel.ResumeLayout(false);
            Lnamepanel.PerformLayout();
            emailpanel.ResumeLayout(false);
            emailpanel.PerformLayout();
            passwordpanel.ResumeLayout(false);
            passwordpanel.PerformLayout();
            conpasspanel.ResumeLayout(false);
            conpasspanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel Fnamepanel;
        private Panel Lnamepanel;
        private Panel emailpanel;
        private Panel passwordpanel;
        private Panel conpasspanel;
        private Button Registerbutton;
        private Label label2;
        private TextBox FnameTB;
        private LinkLabel signinlinkLabel;
        private TextBox LnameTB;
        private TextBox ConpassTB;
        private TextBox EmailTB;
        private TextBox PaasowrdTB;
    }
}