using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Conditional_Statment_Practice
{
    public partial class ConditionalStatementPracticeApp : Form
    {
        public ConditionalStatementPracticeApp()
        {
            InitializeComponent();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            if (nameComboBox.Text=="Pial")
            {
                MessageBox.Show("Pial is good student \nHe can't lie \nhe goes to school regularly");
            }
            else if (nameComboBox.Text=="Bulbul")
            {
                MessageBox.Show("He doesn't want to go to school");

            }
            else if (nameComboBox.Text == "Naim")
                MessageBox.Show("Warning");
            else
            {
                MessageBox.Show("Text Box is emty");
            }
        }
    }
}
