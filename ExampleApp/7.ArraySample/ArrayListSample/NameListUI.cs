using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSample
{
    public partial class NameListUI : Form
    {

        private string[] names = new string[10];

        private int arrayIndex = 0;

        public NameListUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            names[arrayIndex] = nameTextBox.Text;
            nameTextBox.Text = "";
            arrayIndex++;
            addCountLabel.Text = arrayIndex.ToString();



        }

        private void showAllNameButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();
            for (int i = 0; i < arrayIndex; i++)
            {
                namesListBox.Items.Add(names[i]);
            } 
        }

        private void NameListUI_Load(object sender, EventArgs e)
        {

        }

        private void reseatButton_Click(object sender, EventArgs e)
        {


            namesListBox.Items.Clear();
            addCountLabel.Text = "";
            arrayIndex = 0;
            
            // names.Clear();



        }
    }
}
