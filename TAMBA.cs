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
    public partial class TAMBA : Form
    {
        public TAMBA()
        {
            InitializeComponent();
        }

        private void TAMBA_Load(object sender, EventArgs e)
        {
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += TabControl1_DrawItem;

            tabControl1.TabPages[0].Text = "Personal Information";
            tabControl1.TabPages[1].Text = "Education";
            tabControl1.TabPages[2].Text = "Work Experience";
            tabControl1.TabPages[3].Text = "Skills";
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle tabRect = e.Bounds;
            TabPage tabPage = tabControl1.TabPages[e.Index];

            // Pick a color for each tab manually (simplified)
            Color backColor = Color.LightGray;
            if (e.Index == 0) backColor = Color.FromArgb(192, 192, 192); // Personal Info
            else if (e.Index == 1) backColor = Color.FromArgb(192, 192, 192); // Education
            else if (e.Index == 2) backColor = Color.FromArgb(192, 192, 192);   // Work Experience
            else if (e.Index == 3) backColor = Color.FromArgb(192, 192, 192);  // Skills

            using (SolidBrush brush = new SolidBrush(backColor))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.FillRectangle(brush, tabRect);
                g.DrawString(tabPage.Text, e.Font, textBrush, tabRect, sf);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load and display the selected image in the PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
