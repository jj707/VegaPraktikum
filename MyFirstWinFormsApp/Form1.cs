using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace MyFirstWinFormsApp
{

    public partial class Form1 : Form
    {
        string number = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoOne_Click(object sender, EventArgs e)
        {
            number += "1";
            txtEquation.Text = number;
        }

        private void btnNoTwo_Click(object sender, EventArgs e)
        {
            number += "2";
            txtEquation.Text = number;
        }

        private void btnNoThree_Click(object sender, EventArgs e)
        {
            number += "3";
            txtEquation.Text = number;
        }

        private void BtnNoFour_Click_1(object sender, EventArgs e)
        {
            number += "4";
            txtEquation.Text = number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number += "5";
            txtEquation.Text = number;
        }

        private void btnNoSix_Click(object sender, EventArgs e)
        {
            number += "6";
            txtEquation.Text = number;
        }

        private void btnNoSeven_Click(object sender, EventArgs e)
        {
            number += "7";
            txtEquation.Text = number;
        }

        private void btnNoEight_Click(object sender, EventArgs e)
        {
            number += "8";
            txtEquation.Text = number;
        }

        private void BtnNoNine_Click(object sender, EventArgs e)
        {
            UpdateEquation("9");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            UpdateEquation("+");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            number = "";
            txtEquation.Text = number;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            UpdateEquation("0");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            UpdateEquation("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            UpdateEquation("/");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            UpdateEquation("-");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Definieren des Regex-Musters zum Aufteilen der Gleichung
            string pattern = @"([-+*/])";

            // Aufteilen der Gleichung anhand des Regex-Musters
            string[] parts = Regex.Split(txtEquation.Text, pattern);

            var result = CalculateEquation(parts);

            number = result;
            txtEquation.Text = result.ToString();

        }

        private void UpdateEquation(string value)
        {
            if (canWriteOperator(value, txtEquation.Text))
            {
                number += value;
                txtEquation.Text = number;
            }
        }

        private string CalculateEquation(string[] parts)
        {
            // Durchführung der arithmetischen Operationen
            for (int i = 1; i < parts.Length; i += 2)
            {
                string op = parts[i];

                var operand1 = Convert.ToDouble(parts[i - 1]);
                var operand2 = Convert.ToDouble(parts[i + 1]);

                switch (op)
                {
                    case "+":
                        parts[i] = (operand1 + operand2).ToString();
                        break;
                    case "-":
                        parts[i] = (Convert.ToDouble(parts[i - 1]) - Convert.ToDouble(parts[i + 1])).ToString();
                        break;
                    case "*":
                        parts[i] = (Convert.ToDouble(parts[i - 1]) * Convert.ToDouble(parts[i + 1])).ToString();
                        break;
                    case "/":
                        parts[i] = (Convert.ToDouble(parts[i - 1]) / Convert.ToDouble(parts[i + 1])).ToString();
                        break;
                }
            }

            // Das letzte berechnete Element ist das Endergebnis
            var result = parts[parts.Length - 2];

            return result;
        }

        private void txtEquation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsOperator(e.KeyChar) && !canWriteOperator(e.KeyChar.ToString(), txtEquation.Text))
            {
                e.Handled = true;
            }

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEquation_TextChanged(object sender, EventArgs e)
        {
            number = txtEquation.Text;
        }

        private bool canWriteOperator(string value, string equationText)
        {
            var isValueOperator = IsOperator(value.Last());

            var isLastCharOperator = IsOperator(equationText.Trim().LastOrDefault());

            return isValueOperator != isLastCharOperator;
        }

        private bool IsOperator(char value)
        {
            bool isOperator = false;
            switch (value)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    isOperator = true;
                    break;
            }
            return isOperator;
        }

        // TODO: Punkt vor Strich
        // TODO: Cursor verstecken
    }
}