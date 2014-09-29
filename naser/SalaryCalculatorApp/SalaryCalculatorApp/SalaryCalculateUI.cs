using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculateUI : Form
    {
        public SalaryCalculateUI()
        {
            InitializeComponent();
        }

        Employee anEmployee = new Employee();
        private double basic;
        private double houseRent;
        private double medicalAllowance;

        private void showButton_Click(object sender, EventArgs e)
        {
            Initialize();
            anEmployee.empName = nameTextBox.Text;
            MessageBox.Show(anEmployee.CalculateSaSalary(basic, houseRent, medicalAllowance).ToString());
        }

        private void Initialize()
        {
            basic = Convert.ToDouble(basicTextBox.Text);
            houseRent = Convert.ToDouble(houseRentTextBox.Text);
            medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
        }
    }
}
