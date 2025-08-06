namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MENU_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TAMBA tambaForm = new TAMBA();  // Create instance of TAMBA
            tambaForm.Show();
            this.Hide();  // Hide the current form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SEVILLANO SEVILLANO = new SEVILLANO();
            SEVILLANO.Show();
            this.Hide();  // Hide the current form
        }
    }
}
