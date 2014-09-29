using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filepractice
{
    public partial class EmployeeSalary : Form
    {
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        private string filelocation = @"D:\employeesalary.txt";

        private void saveButton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(idTextBox.Text);
            string name = enterNameTextBox.Text;
            double salary = Convert.ToDouble(salaryTextBox.Text);
            string aRow = name + "," + id + "," + salary;

            FileStream aStream = new FileStream(filelocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aStream);
            aStreamWriter.Write(aRow);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(filelocation, FileMode.Open);
            StreamReader asStreamReader = new StreamReader(aStream);
            displayListBox.Items.Clear();
            double totalSalary = 0;

            while (!asStreamReader.EndOfStream)
            {
                string aRow = asStreamReader.ReadLine();
                char[] separator = {','};
                string [] employeeInfo = aRow.Split(separator);
                displayListBox.Items.Add(employeeInfo[0] + " " + employeeInfo[1] + " " + employeeInfo[2]);
                double salary = Convert.ToInt32(employeeInfo[2]);
                totalSalary += salary;
            }

            totalTextBox.Text = totalSalary.ToString();
            asStreamReader.Close();

        }
    }
}
