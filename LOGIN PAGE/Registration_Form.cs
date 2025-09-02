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

        private void Registerbutton_Click(object sender, EventArgs e)
        {

        }

        private void signinlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Page Login_Page = new Login_Page();
            Login_Page.Show();
            this.Hide();
        }
    }
}
