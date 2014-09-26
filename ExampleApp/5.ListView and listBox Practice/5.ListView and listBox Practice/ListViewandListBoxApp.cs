using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.ListView_and_listBox_Practice
{
    public partial class ListViewandListBoxApp : Form
    {
        public ListViewandListBoxApp()
        {
            InitializeComponent();
        }
        List<string> nameList=new List<string>();
        List<int> contactNumberList=new List<int>(); 
        private void nameAddButton_Click(object sender, EventArgs e)
        {
            nameList.Add(nameTextBox.Text);
            contactNumberList.Add(Convert.ToInt32(contactNumberTextBox.Text));
            
            
           ListViewItem item=new ListViewItem(nameTextBox.Text);
            item.SubItems.Add(contactNumberTextBox.Text);
            showlistView.Items.Add(item);

           nameTextBox.Text = "";
           contactNumberTextBox.Text = "";

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            foreach (string name in nameList)
            {
                showListBox.Items.Add(name);
            }
        }

        private void Enable(object sender, MouseEventArgs e)
        {
            int index = showListBox.SelectedIndices[0];
            MessageBox.Show(nameList[index] + "    " + contactNumberList[index]);
        }
    }
}
