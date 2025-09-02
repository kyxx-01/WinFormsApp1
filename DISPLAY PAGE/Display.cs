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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void userpassTB_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = enterbutton;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            enterbutton.Enabled = true;

            Login_Page Login_Page = new Login_Page();
            Login_Page.Show();
            this.Hide();
        }

        private void userpassTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void userpassTB_TextChanged_1(object sender, EventArgs e)
        {
            this.AcceptButton = enterbutton;
        }
    }
}
