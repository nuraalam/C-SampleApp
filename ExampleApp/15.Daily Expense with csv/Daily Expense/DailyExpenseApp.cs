using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace Daily_Expense
{
    public partial class DailyExpenseApp : Form
    {
        private string fileLocation = @"dailyexpense.csv";
        public DailyExpenseApp()
        {
            InitializeComponent();
        }
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            //viewSummaryShowButton.Enabled = true;
            List<string> aDailyExpenseList = new List<string>();
            if((amountTextBox.Text=="")
            ||(entryCatagoryComboBox.Text=="")
             ||(particularTextBox.Text == ""))
            {
                MessageBox.Show("Entry is missing");
                return;
            }
           // amountTextBox.Text.



           
            //  aDailyExpenseList.Clear();
                aDailyExpenseList.Add(amountTextBox.Text);
                aDailyExpenseList.Add(entryCatagoryComboBox.Text);
                aDailyExpenseList.Add(particularTextBox.Text);
            //aDailyExpenseList.Add("\n");
            FileStream aStream = new FileStream(fileLocation, FileMode.OpenOrCreate);

                long fileLength = new FileInfo(fileLocation).Length;
            if (fileLength != 0)
            {
                aStream.Close();
                FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                aWriter.WriteRow(aDailyExpenseList);
                aFileStream.Close();
            }
            else
            {

               // FileStream aStream = new FileStream(fileLocation, FileMode.Create);
                CsvFileWriter aWriter = new CsvFileWriter(aStream);
                aWriter.WriteRow(aDailyExpenseList);

                aStream.Close(); 
            }
            MessageBox.Show("Entry is saved");
            amountTextBox.Text = "";
            entryCatagoryComboBox.Text = "";
            particularTextBox.Text = "";
         
        }

        private void viewSummaryShowButton_Click(object sender, EventArgs e)
        {

            FileStream aStream = new FileStream(fileLocation, FileMode.OpenOrCreate);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aDailyExpenseList = new List<string>();
            List<double> expenseList = new List<double>();
            double totalExpense = 0, maximumExpense = 0;
            long fileLength = new FileInfo(fileLocation).Length;


            if (fileLength != 0)
            {
                while (aReader.ReadRow(aDailyExpenseList))
                {
                    var catagoryWiseExpense = Convert.ToDouble(aDailyExpenseList[0]);
                    totalExpense = totalExpense + catagoryWiseExpense;
                    expenseList.Add(catagoryWiseExpense);


                }
                foreach (double expenseIndex in expenseList)
                {
                    while (maximumExpense < expenseIndex)
                    {

                        maximumExpense = expenseIndex;
                    }

                }
                totalExpenseTextBox.Text = totalExpense.ToString();
                maximumExpenseTextBox.Text = maximumExpense.ToString();
            }
            else
            {
                MessageBox.Show("file is empty");
                aStream.Close();
                return;
            }
            aStream.Close();
        }

        private void viewCatagoryWiseShowButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> viewCatagoryWiseExpenseList = new List<string>();
            List<double> catagoryWiseValueList=new List<double>();
            double total = 0;


            viewCatagoryWiseListBox.Items.Clear();

            while (aReader.ReadRow(viewCatagoryWiseExpenseList))
            {
                if (viewCatagoryWiseExpenseList[1]==viewCatagoryComboBox.Text)
                {
                    total = total + Convert.ToDouble(viewCatagoryWiseExpenseList[0]);
                    catagoryWiseValueList.Add(Convert.ToDouble(viewCatagoryWiseExpenseList[0]));
                }
                else
                {
                    continue;
                }
               
            }
            aStream.Close();
            foreach (double value in catagoryWiseValueList)
            {
                viewCatagoryWiseListBox.Items.Add(value.ToString());
            }
            viewTotalTextBox.Text = total.ToString();
            viewCatagoryComboBox.Text = "";

        }

       // private void DailyExpenseApp_Load(object sender, EventArgs e)
       //{
          //  FileStream aStream = new FileStream(fileLocation, FileMode.Append);
           // CsvFileReader aReader = new CsvFileReader(aStream);
           // if (new FileInfo(fileLocation).Length == 0)
            //{
              //  viewSummaryShowButton.Enabled = false; 
                
           // }
            
        }

       
    }

