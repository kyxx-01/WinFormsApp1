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

        }
    }
}
