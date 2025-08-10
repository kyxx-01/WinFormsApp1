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
    public partial class SEVILLANO : Form
    {
        public SEVILLANO()
        {
            InitializeComponent();
        }

        private void SEVILLANO_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load and display the selected image in the PictureBox
                    pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CV_PREVIEW resume = new CV_PREVIEW();
            //first tab
            resume.profilePicBox.Image = pictureBox2.Image;
            resume.nameTB.Text = nameINPUT.Text;
            resume.profileSummaryTB.Text = profileSummaryINPUT.Text;
            resume.addressTB.Text = addressINPUT.Text;
            resume.emailTB.Text = emailINPUT.Text;
            resume.contactTB.Text = contactINPUT.Text;
            resume.primaryTB.Text = primaryINPUT.Text;
            resume.pyearTB.Text = pyearINPUT.Text;
            resume.pyearGraduatedTB.Text = pyearGraduatedINPUT.Text;
            resume.secondaryTB.Text = secondaryINPUT.Text;
            resume.syearTB.Text = syearINPUT.Text;
            resume.syearGraduatedTB.Text = syearGraduatedINPUT.Text;
            resume.tertiaryTB.Text = tertiaryINPUT.Text;
            resume.tyearTB.Text = tyearINPUT.Text;
            resume.tyearGraduatedTB.Text = tyearGraduatedINPUT.Text;
            //second tab
            resume.skill1TB.Text = skill1INPUT.Text;
            resume.skill2TB.Text = skill2INPUT.Text;
            resume.skill3TB.Text = skill3INPUT.Text;
            resume.skill4TB.Text = skill4INPUT.Text;
            resume.skill5TB.Text = skill5INPUT.Text;
            resume.language1TB.Text = language1INPUT.Text;
            resume.language2TB.Text = language2INPUT.Text;
            resume.companyNameTB.Text = companyNameINPUT.Text;
            resume.yearStartTB.Text = yearStartINPUT.Text;
            resume.yearEndTB.Text = yearEndINPUT.Text;
            resume.char1TB.Text = char1INPUT.Text;
            resume.occupation1TB.Text = occupation1INPUT.Text;
            resume.contact1TB.Text = contact1INPUT.Text;
            resume.char2TB.Text = char2INPUT.Text;
            resume.occupation2TB.Text = occupation2INPUT.Text;
            resume.contact2TB.Text = contact2INPUT.Text;
            resume.Show();
        }
    }
}
