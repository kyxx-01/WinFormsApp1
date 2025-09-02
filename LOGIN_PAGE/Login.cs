using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.DISPLAY_PAGE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void userpassTB_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = SignInButton;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userpassTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void userpassTB_TextChanged_1(object sender, EventArgs e)
        {
            this.AcceptButton = SignInButton;
        }

        private void EyeOpen_Click(object sender, EventArgs e)
        {
            if (userpassTB.PasswordChar == '•')
            {
                EyeOpen.BringToFront();
                userpassTB.PasswordChar = '\0';

            }


        }

        private void Eye_Click(object sender, EventArgs e)
        {
            if (userpassTB.PasswordChar == '•')
            {
                EyeOpen.BringToFront();
                userpassTB.PasswordChar = '\0';

            }


        }

        private void EyeOpen_Click_1(object sender, EventArgs e)
        {
            if (userpassTB.PasswordChar == '•')
            {
                EyeClosed.BringToFront();
                userpassTB.PasswordChar = '\0';

            }
        }

        private void EyeClosed_Click(object sender, EventArgs e)
        {
            if (userpassTB.PasswordChar == '\0')
            {
                EyeOpen.BringToFront();
                userpassTB.PasswordChar = '•';
            }
        }


        private void SignInButton_Click(object sender, EventArgs e)
        {

            string username = useremailTB.Text;
            string password = userpassTB.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Both fields must be filled out!");
                return;
            }

            // Five hardcoded username + password combos

            if (username == "Admin" && password == "admin1234")
            {
                MessageBox.Show("Welcome, Admin!");

                Main_Page Main_Page = new Main_Page();
                Main_Page.Show();
                this.Hide();
                
            }
            else if (username == "Clyde" && password == "pass1")
            {
                MessageBox.Show("Welcome, Clyde!");
                Main_Page Main_Page = new Main_Page();
                Main_Page.Show();
                this.Hide();
            }
            else if (username == "Kyle" && password == "pass2")
            {
                MessageBox.Show("Welcome, Kyle!");
                Main_Page Main_Page = new Main_Page();
                Main_Page.Show();
                this.Hide();
            }
            else if (username == "Grace" && password == "pass3")
            {
                MessageBox.Show("Welcome, Grace!");
                Main_Page Main_Page = new Main_Page();
                Main_Page.Show();
                this.Hide();
            }
            else if (username == "guest" && password == "guest123")
            {
                MessageBox.Show("Welcome, Guest!");
                Main_Page Main_Page = new Main_Page();
                Main_Page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
               





            }
        }

        private void useremailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)

        {

        }
    }
}

