using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information_Apps
{
    public partial class PersonalInformationUI : Form
    {
        String firstName;
        String lastName;
        private String fathersName;
        private string mothersName;
        private string address;
        public PersonalInformationUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            
           
            
            MessageBox.Show("Name:" +firstName+ " " + lastName);

        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("parents Name:" +fathersName + mothersName);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Address: " + address);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
             addressTextBox.Text="";
             firstNameTextBox.Text="";
             lastNameTextBox.Text="";
             fathersNameTextBox.Text="";
             mothersNameTextBox.Text="";
             addressTextBox.Text="";
            MessageBox.Show("All info is saved");
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" First Name:" + firstName + "\nLastName:"
                            + lastName + "\nfathers Name:" + fathersName + "\nmothers Name:" + mothersName +
                            "\nAddress:" + address);

        }
    }
}
