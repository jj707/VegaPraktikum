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
            UpdateEquation("1");
        }

        private void btnNoTwo_Click(object sender, EventArgs e)
        {
            UpdateEquation("2");
        }

        private void btnNoThree_Click(object sender, EventArgs e)
        {
            UpdateEquation("3");
        }

        private void BtnNoFour_Click_1(object sender, EventArgs e)
        {
            UpdateEquation("4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateEquation("5");
        }

        private void btnNoSix_Click(object sender, EventArgs e)
        {
            UpdateEquation("6");
        }

        private void btnNoSeven_Click(object sender, EventArgs e)
        {
            UpdateEquation("7");
        }

        private void btnNoEight_Click(object sender, EventArgs e)
        {
            UpdateEquation("8");
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
            CalculateEquation(txtEquation.Text);
        }

        private void UpdateEquation(string value)
        {
            var isOperator = IsOperator(value.Last());
            if (!isOperator || (isOperator && canWriteOperator(value, txtEquation.Text)))
            {
                number += value;
                txtEquation.Text = number;
            }
        }

        private void CalculateEquation(string equationText)
        {
            if (string.IsNullOrWhiteSpace(equationText))
            {
                return;
            }

            // Definieren des Regex-Musters zum Aufteilen der Gleichung
            string pattern = @"([-+*/])";

            // Aufteilen der Gleichung anhand des Regex-Musters
            string[] parts = Regex.Split(equationText, pattern);

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

            if (parts.Length == 1)
            {
                return;
            }

            // Das letzte berechnete Element ist das Endergebnis
            var result = parts[parts.Length - 2];

            number = result;
            txtEquation.Text = result.ToString();
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

            if (e.KeyChar == (char)Keys.Enter)
            {
                CalculateEquation(txtEquation.Text);
            }
        }

        private void txtEquation_TextChanged(object sender, EventArgs e)
        {
            number = txtEquation.Text;
            txtEquation.Focus();
            txtEquation.Select(txtEquation.Text.Length, 0);

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