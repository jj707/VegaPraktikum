using System.Security.Cryptography.X509Certificates;

namespace MyFirstWinFormsApp
{

    public partial class Form1 : Form
    {
        string number = "";
        public Form1()
        {
            InitializeComponent();
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

        private void BtnNoNine_Click(object sender, EventArgs e)
        {
            number += "9";
            txtEquation.Text = number;
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
    }
}