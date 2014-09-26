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

namespace _14.fileWithTxt_for_Employee_Salary
{
    public partial class Form1 : Form
    {

        private string fileLocation = @"StudentSalary.Txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter=new StreamWriter(aFileStream);
            aStreamWriter.Write(nameTextBox.Text+","+divistionTextBox.Text+","+salaryTextBox.Text);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(fileLocation,FileMode.Open);
            StreamReader aStreamReader=new StreamReader(aFileStream);

            employeeSalarylistView.Items.Clear();
          //  double totalSalary = 0;
            while (!aStreamReader.EndOfStream) 
            {
                string aRow = aStreamReader.ReadLine();
                char[] seperator = { ',' };
                string[] employeeInfo = aRow.Split(seperator);
                ListViewItem item=new ListViewItem(employeeInfo[0]);
                item.SubItems.Add(employeeInfo[1]);
                item.SubItems.Add(employeeInfo[2]);
                employeeSalarylistView.Items.Add(item);
                

                //salaryInfoListBox.Items.Add(employeeInfo[0] + " " + employeeInfo[1] + " " + employeeInfo[2]);
               // double salary = Convert.ToDouble(employeeInfo[2]);
               // totalSalary += salary;
            }
            //totalSalarytextBox.Text = totalSalary.ToString();
            aStreamReader.Close();
        }
    }
}
