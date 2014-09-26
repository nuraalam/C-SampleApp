using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Personal_Information_App
{
    public partial class PersonalInformationApp : Form
    {
        public PersonalInformationApp()
        {
            InitializeComponent();
        }
        string firstName, lastName, fathersName, mothersName, address;
        int contactNumber;

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveStudentInformation();
            showAllInformation();
        }

        private void saveStudentInformation()
        {
            firstName = firstNameTextBox.Text;
            lastName = LastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            contactNumber = Convert.ToInt32(contactNumberTextBox.Text);
            address = addressTextBox.Text;
            firstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            fathersNameTextBox.Text = "";
            mothersNameTextBox.Text = "";
            contactNumberTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            LastNameTextBox.Text = lastName;
            fathersNameTextBox.Text = firstName;
            mothersNameTextBox.Text = mothersName;
            contactNumberTextBox.Text = contactNumber.ToString();
            addressTextBox.Text = address;
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            showAllInformation();
        }

        private void showAllInformation()
        {
            MessageBox.Show("Name : " + firstName + "" + lastName + "\nFathers Name : " + fathersName +
                            "\nMothers Name: " + mothersName + "\nContact Number : " + contactNumber + "\nAddress" +
                            address);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : " + firstName + " " + lastName);

        }

        private void parentsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fathers Name : "+fathersName);
        }

        private void addressAndContuctNumberButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address : " + address + "\nContact Number : " + contactNumber);
        }
    }
}
