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
    public partial class Ordering : Form
    {
        private readonly Dictionary<string, decimal> itemPrices = new()
        {
            // Orange Juice
            { "Orange Juice Small", 29m },
            { "Orange Juice Medium", 39m },
            { "Orange Juice Large", 49m },
            // Buko Juice
            { "Buko Juice Small", 10m },
            { "Buko Juice Medium", 15m },
            { "Buko Juice Large", 20m },
            // Apple Juice
            { "Apple Juice Small", 30m },
            { "Apple Juice Medium", 50m },
            { "Apple Juice Large", 60m }
        };

        private string receiptText = "";

        public Ordering()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;

            Osmall.ValueChanged += NumericUpDown_ValueChanged;
            Omedium.ValueChanged += NumericUpDown_ValueChanged;
            Olarge.ValueChanged += NumericUpDown_ValueChanged;
            Bsmall.ValueChanged += NumericUpDown_ValueChanged;
            Bmedium.ValueChanged += NumericUpDown_ValueChanged;
            Blarge.ValueChanged += NumericUpDown_ValueChanged;
            Asmall.ValueChanged += NumericUpDown_ValueChanged;
            Amedium.ValueChanged += NumericUpDown_ValueChanged;
            Alarge.ValueChanged += NumericUpDown_ValueChanged;

            cashbx.KeyPress += TextBox3_KeyPress;
            cashbx.TextChanged += Cashbx_TextChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = radioButton1.Checked;
            panel3.Visible = radioButton2.Checked;
            panel4.Visible = radioButton3.Checked;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var preview = new StringBuilder();
            decimal total = 0;

            // Panel 2 (Orange)
            if (Osmall.Value > 0)
            {
                decimal price = itemPrices["Orange Juice Small"];
                preview.AppendLine($"Orange Juice Small: {Osmall.Value} x ₱{price:N2} = ₱{(Osmall.Value * price):N2}");
                total += Osmall.Value * price;
            }
            if (Omedium.Value > 0)
            {
                decimal price = itemPrices["Orange Juice Medium"];
                preview.AppendLine($"Orange Juice Medium: {Omedium.Value} x ₱{price:N2} = ₱{(Omedium.Value * price):N2}");
                total += Omedium.Value * price;
            }
            if (Olarge.Value > 0)
            {
                decimal price = itemPrices["Orange Juice Large"];
                preview.AppendLine($"Orange Juice Large: {Olarge.Value} x ₱{price:N2} = ₱{(Olarge.Value * price):N2}");
                total += Olarge.Value * price;
            }

            // Panel 3 (RosyBrown)
            if (Bsmall.Value > 0)
            {
                decimal price = itemPrices["Buko Juice Small"];
                preview.AppendLine($"Buko Juice Small: {Bsmall.Value} x ₱{price:N2} = ₱{(Bsmall.Value * price):N2}");
                total += Bsmall.Value * price;
            }
            if (Bmedium.Value > 0)
            {
                decimal price = itemPrices["Buko Juice Medium"];
                preview.AppendLine($"Buko Juice Medium: {Bmedium.Value} x ₱{price:N2} = ₱{(Bmedium.Value * price):N2}");
                total += Bmedium.Value * price;
            }
            if (Blarge.Value > 0)
            {
                decimal price = itemPrices["Buko Juice Large"];
                preview.AppendLine($"Buko Juice Large: {Blarge.Value} x ₱{price:N2} = ₱{(Blarge.Value * price):N2}");
                total += Blarge.Value * price;
            }

            // Panel 4 (Gold)
            if (Asmall.Value > 0)
            {
                decimal price = itemPrices["Apple Juice Small"];
                preview.AppendLine($"Apple Juice Small: {Asmall.Value} x ₱{price:N2} = ₱{(Asmall.Value * price):N2}");
                total += Asmall.Value * price;
            }
            if (Amedium.Value > 0)
            {
                decimal price = itemPrices["Apple Juice Medium"];
                preview.AppendLine($"Apple Juice Medium: {Amedium.Value} x ₱{price:N2} = ₱{(Amedium.Value * price):N2}");
                total += Amedium.Value * price;
            }
            if (Alarge.Value > 0)
            {
                decimal price = itemPrices["Apple Juice Large"];
                preview.AppendLine($"Apple Juice Large: {Alarge.Value} x ₱{price:N2} = ₱{(Alarge.Value * price):N2}");
                total += Alarge.Value * price;
            }

            PreviewBox.Text = preview.ToString();

            // Show total in totalbx
            totalbx.Text = $"₱{total:N2}";
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cashbx_TextChanged(object sender, EventArgs e)
        {
            // Remove the peso sign and parse the total
            string totalText = totalbx.Text.Replace("₱", "").Trim();
            decimal total = 0;
            decimal cash = 0;

            decimal.TryParse(totalText, out total);
            decimal.TryParse(cashbx.Text, out cash);

            decimal change = cash - total;
            // Prevent negative values
            changebx.Text = $"₱{Math.Max(0, change):N2}";

            // Show warning if payment is insufficient
            warningLabel.Visible = cash < total;
        }

        private void print_Click(object sender, EventArgs e)
        {
            // Build the receipt text
            var receipt = new StringBuilder();
            receipt.AppendLine("Receipt");
            receipt.AppendLine("-----------------------------");
            receipt.AppendLine(PreviewBox.Text);
            receipt.AppendLine("-----------------------------");
            receipt.AppendLine($"Total: {totalbx.Text}");
            receipt.AppendLine($"Cash: {cashbx.Text}");
            receipt.AppendLine($"Change: {changebx.Text}");

            // Show in receiptbx
            receiptbx.Text = receipt.ToString();
        }
    }
}