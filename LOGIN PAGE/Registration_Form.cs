using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Page loginPage = new Login_Page();
            loginPage.Show();
            this.Hide();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            string email = EmailTB.Text.Trim();
            string password = PasswordTB.Text;
            string confirm = ConpassTB.Text;

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            // Check if email already exists
            foreach (string[] user in Login_Page.Users)
            {
                if (user[0] == email)
                {
                    MessageBox.Show("Email already registered");
                    return;
                }
            }

            // Add new user to list

            Login_Page.Users.Add(new string[] { email, password });

            MessageBox.Show("Registration successful"); 
            // Clear the textboxes after register
            EmailTB.Text = "";
            PasswordTB.Text = "";
            ConpassTB.Text = "";

        }
    }
}
