using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string empName ;
        

        public double CalculateSaSalary(double basic, double houseRent, double medicalAllowance)
        {
            return basic + ((basic * houseRent)/100) + ((basic * medicalAllowance)/100);
        }


    }
}
