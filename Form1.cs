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
            // Style for button1 (Red Theme)
            button1.BackColor = Color.Firebrick;                // Dark red background
            button1.ForeColor = Color.White;                    // White text
            button1.FlatStyle = FlatStyle.Flat;                 // Flat look
            button1.FlatAppearance.BorderSize = 0;              // No border
            button1.Font = new Font("Times New Roman", 12, FontStyle.Bold); // Font style
            button1.Cursor = Cursors.Hand;                      // Hand cursor

            // Rounded corners
            button1.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));

            // Hover effect
            button1.MouseEnter += (s, eArgs) => button1.BackColor = Color.Red;          // Brighter red
            button1.MouseLeave += (s, eArgs) => button1.BackColor = Color.Firebrick;    // Original red

            button4.BackColor = Color.MediumSlateBlue;
            button4.ForeColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            button4.Cursor = Cursors.Hand;

            button4.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 20, 20));

            button4.MouseEnter += (s, eArgs) => button4.BackColor = Color.DodgerBlue;
            button4.MouseLeave += (s, eArgs) => button4.BackColor = Color.MediumSlateBlue;

            // Style for button3
            button3.BackColor = Color.MediumSlateBlue;
            button3.ForeColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            button3.Cursor = Cursors.Hand;
            button3.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            button3.MouseEnter += (s, eArgs) => button3.BackColor = Color.DodgerBlue;
            button3.MouseLeave += (s, eArgs) => button3.BackColor = Color.MediumSlateBlue;

            // Style for button5
            button5.BackColor = Color.MediumSlateBlue;
            button5.ForeColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            button5.Cursor = Cursors.Hand;
            button5.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));
            button5.MouseEnter += (s, eArgs) => button5.BackColor = Color.DodgerBlue;
            button5.MouseLeave += (s, eArgs) => button5.BackColor = Color.MediumSlateBlue;

            // Style for button6
            button6.BackColor = Color.MediumSlateBlue;
            button6.ForeColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            button6.Cursor = Cursors.Hand;
            button6.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 20, 20));
            button6.MouseEnter += (s, eArgs) => button6.BackColor = Color.DodgerBlue;
            button6.MouseLeave += (s, eArgs) => button6.BackColor = Color.MediumSlateBlue;

            // Panel border and shadow simulation
            panel1.BackColor = Color.White; // Keep it white if that's what you want

            // Add a border using a padding panel or by painting
            panel1.BorderStyle = BorderStyle.FixedSingle;

            // Optional: Add some padding inside (if you're placing controls inside)
            panel1.Padding = new Padding(10);

            // Optional: Rounded corners (Windows API)
            panel1.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));


        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            ESTACIO EstacioForm = new ESTACIO();  // Create instance of TAMBA
            EstacioForm.Show();
            this.Hide();
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
            this.Hide();
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        private void button5_Click(object sender, EventArgs e)
        {
            SEVILLANO sEVILLANO = new SEVILLANO();
            sEVILLANO.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorForm CalculatorForm = new CalculatorForm();
            CalculatorForm.Show();
            this.Hide();
        }
    }
}
