using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DISPLAY_PAGE;

namespace WinFormsApp1
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();

            Login login = new Login();
            Login.ActiveForm.Hide();
            this.Show();
        }


        private void cvicoPB_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void calcuicoPB_Click(object sender, EventArgs e)
        {
            calcu calcu = new calcu();
            calcu.Show();
        }

        private void grading_Click(object sender, EventArgs e)
        {

        }

        private void ordericoPB_Click(object sender, EventArgs e)
        {
            Ordering Ordering = new Ordering();
            Ordering.Show();
        }

        private void gradingicoPB_Click(object sender, EventArgs e)
        {
            Grading_System_Student_Panel Gradesys = new Grading_System_Student_Panel();
            Gradesys.Show();
        }
    }
}
