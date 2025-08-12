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
    public partial class CalculatorForm : Form
    {
        private decimal firstNumber = 0;
        private decimal secondNumber = 0;
        private string operation = "";
        private bool isOperationClicked = false;

        public CalculatorForm()
        {
            InitializeComponent();
            AssignButtonEvents();
        }

        private void AssignButtonEvents()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (decimal.TryParse(btn.Text, out _) || btn.Text == ".")
                        btn.Click += Button_Click;
                    else if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/")
                        btn.Click += Operation_Click;
                    else if (btn.Text == "=")
                        btn.Click += Equal_Click;
                    else if (btn.Text == "C")
                        btn.Click += Clear_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox_Display.Text == "0" || isOperationClicked)
                textBox_Display.Clear();

            isOperationClicked = false;
            Button btn = (Button)sender;

            if (btn.Text == "." && textBox_Display.Text.Contains("."))
                return;

            textBox_Display.Text += btn.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNumber = Convert.ToDecimal(textBox_Display.Text);
            operation = btn.Text;
            isOperationClicked = true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDecimal(textBox_Display.Text);
            decimal result = 0;

            switch (operation)
            {
                case "+": result = firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Cannot divide by zero!");
                    break;
            }

            textBox_Display.Text = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_Display.Text = "0";
            firstNumber = secondNumber = 0;
            operation = "";
        }
    }
}