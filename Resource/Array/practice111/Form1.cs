using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice111
{
    public partial class homeTask : Form
    {
        public homeTask()
        {
            InitializeComponent();
        }

        string[] nameInput = new string[10];
        int i = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {

                nameInput[i] = nameTextBox.Text;
                nameTextBox.Text = "";
                countLabel.Text = (i + 1).ToString();
                
                i++;

            }

            else
            {
               
                addButton.Enabled = false;
                nameTextBox.Text = "";

                foreach (string s in nameInput)
                {
                    if (s != null)
                    {
                        displayListBox.Items.Add(s);
                    }
                }

            }

        }

 
        private void resetButton_Click(object sender, EventArgs e)
        {
            nameInput = new string [10];
            displayListBox.Items.Clear();
            i = 0;
            addButton.Enabled = true;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            foreach (string s in nameInput)
            {
                if (s != null)
                {
                    displayListBox.Items.Add(s);
                }
            }
        }
    }
}
