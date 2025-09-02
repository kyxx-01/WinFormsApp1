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
    public partial class ALARCONCV : Form
    {
        public ALARCONCV()
        {
            InitializeComponent();

            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(0, 1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ALARCON alarconForm = new ALARCON(); // Create instance of ALARCON
            alarconForm.Show();
            this.Close(); // Close the current form
        }
    }
}
