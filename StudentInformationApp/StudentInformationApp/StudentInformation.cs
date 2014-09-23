using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    
    public partial class StudentInformation : Form
    {
        public StudentInformation()
        {
            InitializeComponent();
        }

         Student aStudent = new Student();
        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.id = idTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            idTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;


            MessageBox.Show(aStudent.firstName + " " + aStudent.lastName + ", your Id number is :" + " " + aStudent.id);
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aStudent.id;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }
    }
}
