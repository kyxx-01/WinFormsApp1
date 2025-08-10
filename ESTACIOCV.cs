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
    public partial class ESTACIOCV : Form
    {
        public ESTACIOCV()
        {
            InitializeComponent();
        }

        private void ESTACIOCV_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESTACIO eSTACIO = new ESTACIO();
            eSTACIO.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearentered3_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearentered1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
