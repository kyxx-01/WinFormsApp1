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

            // New color palette
            Color normalColor = Color.SlateGray;
            Color hoverColor = Color.RoyalBlue;
            Color pressedColor = Color.LightSteelBlue; // Optional click effect

            // Helper method to style buttons
            void StyleBlueButton(Button btn)
            {
                btn.BackColor = normalColor;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.Region = System.Drawing.Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20));

                // Hover effect
                btn.MouseEnter += (s, eArgs) => btn.BackColor = hoverColor;
                btn.MouseLeave += (s, eArgs) => btn.BackColor = normalColor;

                // Pressed effect
                btn.MouseDown += (s, eArgs) => btn.BackColor = pressedColor;
                btn.MouseUp += (s, eArgs) => btn.BackColor = hoverColor;
            }

            // Apply styles to buttons
            StyleBlueButton(button2);
            StyleBlueButton(button3);
            StyleBlueButton(button4);
            StyleBlueButton(button5);
            StyleBlueButton(button6);

         
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
            ALARCON aLARCON = new ALARCON();
            aLARCON.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            Calculator.Show();
            this.Hide();
        }
    }
}
