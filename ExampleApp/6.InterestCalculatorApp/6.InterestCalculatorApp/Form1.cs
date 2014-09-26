using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.InterestCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int interstPercentages;

        private void calculationButton_Click(object sender, EventArgs e)
        {
            string bankName = bankNameComboBox.Text;
            int yearOfInterest = Convert.ToInt32(yearOfInterestTextBox.Text);
            double balanceAfterInterest = 0, initialBalance, interest = 0;
            initialBalance = Convert.ToDouble(initialBalanceTextBox.Text);
            if (bankName == "HSBC")
            {
                interstPercentages = 7;
                Calculation(initialBalance, yearOfInterest);
            }
            else if (bankName == "BRAC")
            {
                interstPercentages = 8;
                Calculation(initialBalance, yearOfInterest);
            }
            else
            {
                interstPercentages = 6;
                Calculation(initialBalance, yearOfInterest);
            }
        }

        private void Calculation(double initialBalance, int yearOfInterest)
        {
            double interest;
            double balanceAfterInterest;
            interest = ((initialBalance/100*interstPercentages)*yearOfInterest);
            balanceAfterInterest = initialBalance+interest;

            balanceAfterInterestTextBox.Text = balanceAfterInterest.ToString();
            outputLebel.Text = interest.ToString();
        }
    }
}
