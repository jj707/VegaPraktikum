using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Calculator;

namespace MyFirstWinFormsApp
{

    public partial class Form1 : Form
    {
        private Calculation calculation;

        public Form1()
        {
            InitializeComponent();

            calculation = new Calculation();
            calculation.ValueChanged += Calculation_ValueChanged;
        }

        private void Calculation_ValueChanged(object? sender, EventArgs e)
        {
            txtEquation.Text = calculation.EquationText;
        }

        private void btnNoOne_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("1");
        }

        private void btnNoTwo_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("2");
        }

        private void btnNoThree_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("3");
        }

        private void BtnNoFour_Click_1(object sender, EventArgs e)
        {
            calculation.UpdateEquation("4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("5");
        }

        private void btnNoSix_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("6");
        }

        private void btnNoSeven_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("7");
        }

        private void btnNoEight_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("8");
        }

        private void BtnNoNine_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("9");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("+");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            calculation.Clear();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("0");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("/");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            calculation.UpdateEquation("-");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            calculation.CalculateEquation(txtEquation.Text);
        }

        private void txtEquation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (calculation.IsOperator(e.KeyChar) && !calculation.CanWriteOperator(e.KeyChar.ToString(), txtEquation.Text))
            {
                e.Handled = true;
            }

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                calculation.CalculateEquation(txtEquation.Text);
            }
        }

        private void txtEquation_TextChanged(object sender, EventArgs e)
        {
            calculation.SetEquation(txtEquation.Text);
            txtEquation.Focus();
            txtEquation.Select(txtEquation.Text.Length, 0);
        }
    }
}