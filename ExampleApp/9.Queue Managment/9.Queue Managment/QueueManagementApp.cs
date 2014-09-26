using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _9.Queue_Managment
{
    public partial class QueueManagementApp : Form
    {
        public QueueManagementApp()
        {
            InitializeComponent();
        }

        Queue<string> nameQueue=new Queue<string>();
        Queue<string> complainQueue=new Queue<string>();
        Queue<int> serialNumberQueue=new Queue<int>();
       // List<string> nameList=new List<string>();
       // List<string> complainList=new List<string>();
        int serialNo = 1;
        
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            
            nameQueue.Enqueue(enqueueNameTextBox.Text);
            complainQueue.Enqueue(enqueueComplainTextBox.Text);
            serialNumberQueue.Enqueue(serialNo);
           // nameList.Add(enqueueNameTextBox.Text);
           // complainList.Add(enqueueComplainTextBox.Text);

          
            var item=new ListViewItem(serialNo.ToString());
            item.SubItems.Add(enqueueNameTextBox.Text);
            item.SubItems.Add(enqueueComplainTextBox.Text);
            queueManagementListView.Items.Add(item);

            enqueueNameTextBox.Text = "";
            enqueueComplainTextBox.Text = "";
            serialNo++;

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            
           // int newSerialNo = 1;
            dequeueNameTextBox.Text = nameQueue.Dequeue();
            dequeueComplainTextBox.Text = complainQueue.Dequeue();
            dequeueSerialNoTextBox.Text = serialNumberQueue.Dequeue().ToString();
            queueManagementListView.Items.RemoveAt(0);
       
               // var newItem= new ListViewItem(i.ToString());
                //newItem.SubItems.Add(nameList[i]);
               // newItem.SubItems.Add(complainList[i]);
            
               // queueManagementListView.Items.Add(newItem);
               // newSerialNo++;
        }

        private void Enable(object sender, MouseEventArgs e)
        {
            var index = queueManagementListView.SelectedIndices[0];
            MessageBox.Show(queueManagementListView.Items[index].SubItems[2].Text+"'s serial Number is "+queueManagementListView.Items[index].Text);


        }
           


                
            

    }
}

