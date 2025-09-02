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
        private int scrollOffset = 0;


        public TAMBA()
        {
            InitializeComponent();



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
                        pictureBox1.Image = img;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image display mode as needed
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void TAMBA_Resize(object sender, EventArgs e)
        {
            scrollPanel.Location = new Point(10, 10);
            scrollPanel.Size = new Size(this.ClientSize.Width - vScrollBar1.Width - 20, this.ClientSize.Height - 20);

            vScrollBar1.Location = new Point(this.ClientSize.Width - vScrollBar1.Width - 10, 10);
            vScrollBar1.Height = this.ClientSize.Height - 20;

            // Update scroll range in case size change affects scroll logic
            scrollPanel_Resize(sender, e);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int newOffset = e.NewValue;
            int delta = newOffset - scrollOffset;

            foreach (Control ctrl in scrollPanel.Controls)
            {
                ctrl.Top -= delta;
            }

            scrollOffset = newOffset;
        }

        protected override void OnLoad(EventArgs e)


        {
            base.OnLoad(e);

            base.OnLoad(e);

            // Find the tallest control inside scrollPanel
            int contentHeight = 0;
            foreach (Control ctrl in scrollPanel.Controls)
            {
                contentHeight = Math.Max(contentHeight, ctrl.Bottom);
            }

            int visibleHeight = scrollPanel.Height;

            vScrollBar1.Minimum = 0;
            vScrollBar1.LargeChange = visibleHeight;
            vScrollBar1.SmallChange = 20;

            // Allow scrolling up to bottom of last control
            vScrollBar1.Maximum = Math.Max(0, contentHeight - visibleHeight);
            vScrollBar1.Value = 0;

            scrollOffset = 0;


        }

        private void scrollPanel_Resize(object sender, EventArgs e)
        {
            int contentHeight = 0;
            foreach (Control ctrl in scrollPanel.Controls)
            {
                contentHeight = Math.Max(contentHeight, ctrl.Bottom);
            }

            int visibleHeight = scrollPanel.Height;

            vScrollBar1.LargeChange = visibleHeight;
            vScrollBar1.Maximum = Math.Max(0, contentHeight - visibleHeight);
        }

        private void scrollPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Check if an image is uploaded
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload an image before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Required field checks
            if (string.IsNullOrWhiteSpace(CNAME.Text) ||
                string.IsNullOrWhiteSpace(CNUM.Text) ||
                string.IsNullOrWhiteSpace(CEMAIL.Text) ||
                string.IsNullOrWhiteSpace(CADDRESS.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Email format validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(CEMAIL.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Contact number validation (Philippines format example: starts with 09 and has 11 digits)
            if (!System.Text.RegularExpressions.Regex.IsMatch(CNUM.Text, @"^09\d{9}$"))
            {
                MessageBox.Show("Please enter a valid contact number (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ If all validations pass, proceed
            this.Hide();
            TAMBACV tAMBACV = new TAMBACV();

            tAMBACV.pictureBox10.Image = pictureBox1.Image;
            tAMBACV.CNAME0.Text = CNAME.Text;
            tAMBACV.CNUM0.Text = CNUM.Text;
            tAMBACV.CEMAIL0.Text = CEMAIL.Text;
            tAMBACV.CADDRESS0.Text = CADDRESS.Text;
            tAMBACV.CPRIMARY0.Text = CPRIMARY.Text;
            tAMBACV.CSECONDARY0.Text = CSECONDARY.Text;
            tAMBACV.CTERTIARY0.Text = CTERTIARY.Text;
            tAMBACV.CYR1E0.Text = CYR1E.Text;
            tAMBACV.CYR2E0.Text = CYR2E.Text;
            tAMBACV.CYR3E0.Text = CYR3E.Text;
            tAMBACV.CCOMP10.Text = CCOMP1.Text;
            tAMBACV.CCOMP20.Text = CCOMP2.Text;
            tAMBACV.CCOMP30.Text = CCOMP3.Text;
            tAMBACV.CYOE10.Text = CYOE1.Text;
            tAMBACV.CYOE20.Text = CYOE2.Text;
            tAMBACV.CYOE30.Text = CYOE3.Text;
            tAMBACV.CSKI10.Text = CSKI1.Text;
            tAMBACV.CSKI20.Text = CSKI2.Text;
            tAMBACV.CSKI30.Text = CSKI3.Text;
            tAMBACV.CREF10.Text = CREF1.Text;
            tAMBACV.CREF20.Text = CREF2.Text;
            tAMBACV.COCC10.Text = COCC1.Text;
            tAMBACV.COCC20.Text = COCC2.Text;
            tAMBACV.CCON10.Text = CCON1.Text;
            tAMBACV.CCON20.Text = CCON2.Text;

            tAMBACV.Show();
        }

        private void CADDRESS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
