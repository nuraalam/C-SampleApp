using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private double firstValue, seccondValue, indexButton=0;
        
        private void addButton_Click(object sender, EventArgs e)
        {
            indexButton = 1;
            calculation();
        }

        private void calculation()
        {
            firstValue = Convert.ToDouble(firstValueTextBox.Text);
            seccondValue = Convert.ToDouble(seccondValueTextBox.Text);
            if (indexButton==1)
            resultTextBox.Text = (firstValue + seccondValue).ToString();
            else if(indexButton==2)
                resultTextBox.Text = (firstValue - seccondValue).ToString();
            else if(indexButton==3)
                resultTextBox.Text = (firstValue * seccondValue).ToString();
            else 
                resultTextBox.Text = (firstValue/seccondValue).ToString();
            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            indexButton = 2;
            calculation();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            indexButton = 3;
            calculation();
        }

        private void divistionButton_Click(object sender, EventArgs e)
        {
           
            calculation();
        }
    }
}
