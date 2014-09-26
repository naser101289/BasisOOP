using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CustomerComplainApp : Form
    {
        public CustomerComplainApp()
        {
            InitializeComponent();
        }

        Queue <customer> customerQueue = new Queue<customer>();
        customer aCustomer = new customer();
        int count = 0;
 
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (enameTextBox.Text != "" && ecomplainTextBox.Text != "")
            {
                
               aCustomer.name = enameTextBox.Text;
               aCustomer.complain = ecomplainTextBox.Text;

               customerQueue.Enqueue(aCustomer);

               ListViewItem item = new ListViewItem((count + 1).ToString());
               item.SubItems.Add(aCustomer.name);
               item.SubItems.Add(aCustomer.complain);
               waitingQueueListView.Items.Add(item);

               enameTextBox.Text = string.Empty;
               ecomplainTextBox.Text = string.Empty;

               MessageBox.Show(aCustomer.name + ", Successfully Enqueued with Serial Number :" + " " + (count + 1));

               count++;
 
            }
            else
            {

                MessageBox.Show("Please Enter Customer Name & Complain.");

            }
 
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (waitingQueueListView.Items.Count > 0)
            {
                serialNoTextBox.Text = waitingQueueListView.Items[0].SubItems[0].Text;
                dnameTextBox.Text = waitingQueueListView.Items[0].SubItems[1].Text;
                dcomplainTextBox.Text = waitingQueueListView.Items[0].SubItems[2].Text;

                customerQueue.Dequeue();

                waitingQueueListView.Items[0].Remove();

                MessageBox.Show("Serial Number " + serialNoTextBox.Text + ", Dequeued Sucessfully.");

            }
            else
            {

                serialNoTextBox.Text = string.Empty;
                dnameTextBox.Text = string.Empty;
                dcomplainTextBox.Text = string.Empty;

                MessageBox.Show("Waiting Queue is Empty.");

            }

        }

    }
}
