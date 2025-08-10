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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // START button design for button1 in Form2
            button1.BackColor = Color.SeaGreen;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            button1.Cursor = Cursors.Hand;

            // Rounded corners
            button1.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 25, 25));

            // Hover effect
            button1.MouseEnter += (s, eArgs) => button1.BackColor = Color.MediumSeaGreen;
            button1.MouseLeave += (s, eArgs) => button1.BackColor = Color.SeaGreen;

            // Optional: Label it "START"
            button1.Text = "START";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
    int nWidthEllipse, int nHeightEllipse
);

    }
}
