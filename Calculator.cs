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
    public partial class Calculator : Form
    {
        double result = 0; // Stores the current result
        string operation = ""; // Stores the current operation (+, -, *, /)
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        // Numbers and decimal point
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        // Operators (+, -, *, /)
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEqual.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBox_Result.Text);
                isOperationPerformed = true;
            }
        }

        // Clear button
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result = 0;
        }

        // Equal button
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (result + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (result * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(textBox_Result.Text) != 0)
                        textBox_Result.Text = (result / double.Parse(textBox_Result.Text)).ToString();
                    else
                        textBox_Result.Text = "Error";
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox_Result.Text);
            operation = "";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // Apply background to form
            this.BackColor = Color.LightSkyBlue;

            // Apply button colors
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.DeepSkyBlue;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    // Add hover effect
                    btn.MouseEnter += (s, ev) => { btn.BackColor = Color.SteelBlue; };
                    btn.MouseLeave += (s, ev) => { btn.BackColor = Color.DeepSkyBlue; };

                    // Style for button1 (Red Theme)
                    buttonreturn.BackColor = Color.Firebrick;                // Dark red background
                    buttonreturn.ForeColor = Color.White;                    // White text
                    buttonreturn.FlatStyle = FlatStyle.Flat;                 // Flat look
                    buttonreturn.FlatAppearance.BorderSize = 0;              // No border
                    buttonreturn.Font = new Font("Times New Roman", 12, FontStyle.Bold); // Font style
                    buttonreturn.Cursor = Cursors.Hand;

                    // Hover effect
                    buttonreturn.MouseEnter += (s, eArgs) => buttonreturn.BackColor = Color.Red;          // Brighter red
                    buttonreturn.MouseLeave += (s, eArgs) => buttonreturn.BackColor = Color.Firebrick;    // Original red
                }
            }

            // Style TextBox
            textBox_Result.BackColor = Color.White;
            textBox_Result.ForeColor = Color.Black;
            textBox_Result.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Calculator = new Form1();
            Calculator.Show();
        }
    }
}