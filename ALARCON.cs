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
    public partial class ALARCON : Form
    {
        public ALARCON()
        {
            InitializeComponent();

            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(0, 1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(); // Assuming Form1 is the main form
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
                        Picbx.Image = img;
                        Picbx.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image display mode as needed
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // 1. Check if an image is uploaded
            if (Picbx.Image == null)
            {
                MessageBox.Show("Please upload an image before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Required field checks
            if (string.IsNullOrWhiteSpace(Namebx.Text) ||
                string.IsNullOrWhiteSpace(Contactbx.Text) ||
                string.IsNullOrWhiteSpace(Emailbx.Text) ||
                string.IsNullOrWhiteSpace(Emailbx.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Email format validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(Emailbx.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Contact number validation (Philippines format example: starts with 09 and has 11 digits)
            if (!System.Text.RegularExpressions.Regex.IsMatch(Contactbx.Text, @"^09\d{9}$"))
            {
                MessageBox.Show("Please enter a valid contact number (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ALARCONCV alarconCVForm = new ALARCONCV(); // Create instance of ALARCONCV

            alarconCVForm.Picbx1.Image = Picbx.Image; // Pass the image to ALARCONCV
            alarconCVForm.Namebx1.Text = Namebx.Text; // Pass the name to ALARCONCV 
            alarconCVForm.Contactbx1.Text = Contactbx.Text; // Pass the number to ALARCONCV 
            alarconCVForm.Emailbx1.Text = Emailbx.Text; // Pass the email to ALARCONCV
            alarconCVForm.Addressbx1.Text = Addressbx.Text; // Pass the address to ALARCONCV
            alarconCVForm.Birthdaybx1.Text = Birthdaybx.Text; // Pass the birth date to ALARCONCV
            alarconCVForm.PREN1.Text = PREN.Text; // Pass the pre-n to ALARCONCV
            alarconCVForm.PRGR1.Text = PRGR.Text; // Pass the pre-gr to ALARCONCV
            alarconCVForm.Primarybx1.Text = Primarybx.Text; // Pass the primary education to ALARCONCV
            alarconCVForm.Secondarybx1.Text = Secondarybx.Text; // Pass the secondary education to ALARCONCV
            alarconCVForm.Tertiarybx1.Text = Tertiarybx.Text; // Pass the tertiary education to ALARCONCV
            alarconCVForm.SECEN1.Text = SECEN.Text; // Pass the secondary education name to ALARCONCV
            alarconCVForm.TREN1.Text = TREN.Text; // Pass the tertiary education name to ALARCONCV
            alarconCVForm.SECGR1.Text = SECGR.Text; // Pass the secondary education grade to ALARCONCV
            alarconCVForm.TRGR1.Text = TRGR.Text; // Pass the tertiary education grade to ALARCONCV
            alarconCVForm.Com1bx1.Text = Com1bx.Text; // Pass the first comment to ALARCONCV
            alarconCVForm.Com2bx1.Text = Com2bx.Text; // Pass the second comment to ALARCONCV
            alarconCVForm.YR1EM1.Text = YR1EM.Text; // Pass the first year of employment to ALARCONCV
            alarconCVForm.YR2EM1.Text = YR2EM.Text; // Pass the second year of employment to ALARCONCV
            alarconCVForm.Skbx10.Text = Skbx1.Text; // Pass the first skill to ALARCONCV
            alarconCVForm.Skbx20.Text = Skbx2.Text; // Pass the second skill to ALARCONCV
            alarconCVForm.Skbx30.Text = Skbx3.Text; // Pass the third skill to ALARCONCV

            alarconCVForm.Show();
            this.Hide(); 
        }
    }
}
