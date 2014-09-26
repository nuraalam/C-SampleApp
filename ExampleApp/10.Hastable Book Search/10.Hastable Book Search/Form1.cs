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

namespace _10.Hastable_Book_Search
{
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }
        Hashtable aHashtable = new Hashtable();
        private void addButton_Click(object sender, EventArgs e)
        {
            
            aHashtable.Add(addIsbnTextBox.Text,addDetailsTextBox.Text);
            addIsbnTextBox.Text = "";
            addDetailsTextBox.Text = "";
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string detailsOfAbook = aHashtable[findIsbnTextBox.Text] as string;
            findDetailsTextBox.Text = detailsOfAbook;
        }
    }
}
