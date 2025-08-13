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
    public partial class calcu : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public calcu()
        {
            InitializeComponent();
        }

        private void calcu_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }
            else
            {
                textBox_Result.Text += button.Text; // just append numbers
            }
        }

        

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                BUTTONEQUAL.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                if (double.TryParse(textBox_Result.Text, out double parsedValue))
                {
                    operationPerformed = button.Text;
                    resultValue = parsedValue;
                    labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                    isOperationPerformed = true;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void BUTTONCLEAR_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void BUTTONDEL_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length > 1)
            {
                // Remove last character
                textBox_Result.Text = textBox_Result.Text.Substring(0, textBox_Result.Text.Length - 1);
            }
            else
            {
                // If there's only one digit left, reset to 0
                textBox_Result.Text = "0";
            }
        }


        private void BUTTONEQUAL_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_Result.Text, out double parsedInput))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + parsedInput).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - parsedInput).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * parsedInput).ToString();
                    break;
                case "/":
                    if (parsedInput != 0)
                        textBox_Result.Text = (resultValue / parsedInput).ToString();
                    else
                        MessageBox.Show("Cannot divide by zero.");
                    break;
                default:
                    break;
            }

            if (double.TryParse(textBox_Result.Text, out double finalValue))
                resultValue = finalValue;

            labelCurrentOperation.Text = "";
        }

    }
}
