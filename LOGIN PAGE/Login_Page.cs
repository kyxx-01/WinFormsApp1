using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Login_Page : Form
    {
        //each string[] holds email and password
        public static List<string[]> Users = new List<string[]>();
        public Login_Page()
        {
            InitializeComponent();
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void loginTxt_TextChanged(object sender, EventArgs e)

        {
            // When the user clicks into the textbox
            if (loginTxt.Text == "Username")
                loginTxt.Text = "";

            // Clear placeholder text
            loginTxt.ForeColor = Color.Black;

            // Set Text color to black
        }

        private void UsernameTxt_LostFocus(object sender, EventArgs e)
        {
            // When the user leaves the textbox
            if (string.IsNullOrWhiteSpace(loginTxt.Text))
            {
                loginTxt.Text = "Username";  // Set placeholder text
                loginTxt.ForeColor = Color.DarkGray;  // Set text color to gray
            }

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string email = loginTxt.Text.Trim();
            string password = passwordTxt.Text;

            bool found = false;

            foreach (string[] user in Users)
            {
                if (user[0] == email)
                {
                    if (user[1] == password)
                    {
                        MessageBox.Show("Login successful");
                        Main_Page mainPage = new Main_Page();
                        mainPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Email not found");
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            Registration_Form regform = new Registration_Form();
            regform.Show();
            this.Hide();
        }
    }
}
