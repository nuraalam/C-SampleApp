using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Userdefine_Type_Example
{
    public partial class personalInformation : Form
    {
        usrDefineVariable personalInformUsrDefineVariable = new usrDefineVariable();
        public personalInformation()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            personalInformUsrDefineVariable.name = nameTextBox.Text;
            personalInformUsrDefineVariable.address = addressTextBox.Text;
            personalInformUsrDefineVariable.phone = Convert.ToInt32(phoneTextBox.Text);
            ListViewItem item=new ListViewItem(personalInformUsrDefineVariable.name);
            item.SubItems.Add(personalInformUsrDefineVariable.address);
            item.SubItems.Add(personalInformUsrDefineVariable.phone.ToString());
            personalInformationListView.Items.Add(item);

        }
    }
}
