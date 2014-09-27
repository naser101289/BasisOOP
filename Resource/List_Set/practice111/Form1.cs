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
    public partial class listApp : Form
    {
        public listApp()
        {
            InitializeComponent();
        }

         List<string> nameInput = new List<string>(); 
         int i = 0;
         int number;

        private void addButton_Click(object sender, EventArgs e)
        {
            showAllButton.Enabled = true;
            setButton.Enabled = false;
            resetButton.Enabled = true;

            if (i < number)
            {

                nameInput.Add(nameTextBox.Text);
                nameTextBox.Text = "";
                countLabel.Text = (i + 1).ToString();
                
                i++;

            }

            if (i == number)
            {
               
                addButton.Enabled = false;
                nameTextBox.Text = "";
                showAllButton.Enabled = false;

                foreach (string s in nameInput)
                {
                    if (s != null)
                    {
                        displayListBox.Items.Add(s);
                    }
                }

            }

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameInput = new List<string>();
            displayListBox.Items.Clear();
            i = 0;

            addButton.Enabled = true;
            setButton.Enabled = true;
            showAllButton.Enabled = true;
           
            inputTextBox.Text = "";
            countLabel.Text = "";
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

        private void setButton_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(inputTextBox.Text);
            addButton.Enabled = true;
         
        }

        private void listApp_Load(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            resetButton.Enabled = false;
            showAllButton.Enabled = false;
            setButton.Enabled = true;
            
        }
    }
}
