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
        List<Student> studentList = new List<Student>(); 
        public StudentInformation()
        {
            InitializeComponent();
        }

        // Student aStudent = new Student();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();

            aStudent.id = idTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            idTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;

            studentList.Add(aStudent);


            MessageBox.Show(aStudent.GetFullNmae()+ ", your Id number is :" + " " + aStudent.id);
        }


        private void retrieveButton_Click(object sender, EventArgs e)
        {
            //idTextBox.Text = aStudent.id;
            //firstNameTextBox.Text = aStudent.firstName;
            //lastNameTextBox.Text = aStudent.lastName;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string msg = "Id \t Full Name \n";

            foreach (Student aStudent in studentList)
            {
                msg = aStudent.id + aStudent.GetFullNmae() + "\n";
            }
            
            MessageBox.Show(msg);
        }
    }
}
