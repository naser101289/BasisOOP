using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeinformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            string address;

            string[] details = new string[3];


        private void saveButton_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text != "" && nameTextBox.Text != "" && salaryTextBox.Text != "" && addressTextBox.Text != "" )
            {

               int id = Convert.ToInt32(idTextBox.Text);
               string name = nameTextBox.Text;
               double salary = Convert.ToDouble(salaryTextBox.Text);
               address = addressTextBox.Text;

                ListViewItem item;

                details[0] = idTextBox.Text;
                details[1] = nameTextBox.Text;
                details[2] = salaryTextBox.Text;

                item = new ListViewItem(details);
                detailsListView.Items.Add(item);

            }

                     idTextBox.Text = "";
                     nameTextBox.Text = "";
                     salaryTextBox.Text = "";
                     addressTextBox.Text = "";

        }

        private void detailsListView_MouseDoubleClick(object sender, MouseEventArgs e)

        {
            
            int selectedIndex = detailsListView.SelectedIndices[0];

            idTextBox.Text = detailsListView.Items[selectedIndex].SubItems[0].Text;
            nameTextBox.Text = detailsListView.Items[selectedIndex].SubItems[1].Text;
            salaryTextBox.Text = detailsListView.Items[selectedIndex].SubItems[2].Text;

            addressTextBox.Text = address;
        }

        
    }
}
