using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{
    public partial class ESTACIO : Form
    {
        private int maxScroll;
        private int scrollOffset;

        public ESTACIO()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ESTACIO_Load(object sender, EventArgs e)
        {
            // Calculate the total height of the content inside panel4
            int contentHeight = 0;
            foreach (Control ctrl in panel4.Controls)
            {
                if (ctrl.Bottom > contentHeight)
                    contentHeight = ctrl.Bottom;
            }

            // Set up the scrollbar
            int visibleHeight = panel4.Height;
            maxScroll = Math.Max(0, contentHeight - visibleHeight);
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = maxScroll + vScrollBar1.LargeChange - 1;
            vScrollBar1.LargeChange = visibleHeight;
            vScrollBar1.SmallChange = 20;
            vScrollBar1.Value = 0;
            scrollOffset = 0;

            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(0, 2000);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int newOffset = e.NewValue;
            int delta = newOffset - scrollOffset;
            foreach (Control ctrl in panel4.Controls)
            {
                ctrl.Top -= delta;
            }
            scrollOffset = newOffset;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Insert Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image img = Image.FromFile(openFileDialog.FileName);
                        pb.Image = img;
                        pb.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image display mode as needed
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ESTACIO = new Form1();
            ESTACIO.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESTACIOCV estacioCV = new ESTACIOCV();

            estacioCV.fullnametb0.Text = fullnametb.Text;
            estacioCV.adresstb0.Text = adresstb.Text;
            estacioCV.contacttb0.Text = contacttb.Text;
            estacioCV.emailtb0.Text = emailtb.Text;
            estacioCV.pb0.Image = pb.Image;
            estacioCV.compname10.Text = compname1.Text;
            estacioCV.compname20.Text = comp2.Text;
            estacioCV.comp30.Text = comp3.Text;
            estacioCV.pos10.Text = pos1.Text;
            estacioCV.pos20.Text = pos2.Text;
            estacioCV.pos30.Text = pos3.Text;
            estacioCV.pyearentered0.Text = pyearentered.Text;
            estacioCV.sentered0.Text = sentered.Text;
            estacioCV.tertiaryyearentered0.Text = tertiaryyearentered.Text;
            estacioCV.skill10.Text = richTextBox1.Text;
            estacioCV.skill20.Text = richTextBox2.Text;
            estacioCV.skill30.Text = richTextBox3.Text;



            Show (estacioCV);


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// The above code is a Windows Forms application that implements a form named ESTACIO.