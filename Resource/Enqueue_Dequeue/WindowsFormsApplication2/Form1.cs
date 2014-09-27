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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        string [] complainList = new string [3];

        Queue <string> complain = new Queue<string>();

        int count = 0;
 

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (enameTextBox.Text != "" && ecomplainTextBox.Text != "")
            {

            
            complain.Enqueue(enameTextBox.Text);
            complain.Enqueue(ecomplainTextBox.Text);
           
            ListViewItem item;

            complainList[0] = (count + 1).ToString();
            complainList[1] = enameTextBox.Text;
            complainList[2] = ecomplainTextBox.Text;

            item = new ListViewItem(complainList);
            waitingQueueListView.Items.Add(item);

            enameTextBox.Text = "";
            ecomplainTextBox.Text = "";

            count++;
            

            }
           
            
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {

            if (dnameTextBox.Text != "" && dcomplainTextBox.Text != "" && serialNoTextBox.Text != "")
            {

                complain.Dequeue();
                complain.Dequeue();


                waitingQueueListView.Items[0].Remove();

                dnameTextBox.Text = "";
                dcomplainTextBox.Text = "";
                serialNoTextBox.Text = "";
 
            }

        }

        private void waitingQueueListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialNoTextBox.Text = waitingQueueListView.Items[0].SubItems[0].Text;
            dnameTextBox.Text = waitingQueueListView.Items[0].SubItems[1].Text;
            dcomplainTextBox.Text = waitingQueueListView.Items[0].SubItems[2].Text;

        }
    }
}
