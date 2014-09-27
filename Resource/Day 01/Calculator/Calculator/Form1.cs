using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        private double result;

        
           

        public CalculatorUI()
        {
            InitializeComponent();
        }

        
        
        private void addButton_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            fn = Convert.ToDouble(firstNumberTextBox.Text);
            sn = Convert.ToDouble(secondNumberTextBox.Text);
            double result = fn + sn;
            resultTextBox.Text = Convert.ToString(result);

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            fn = Convert.ToDouble(firstNumberTextBox.Text);
            sn = Convert.ToDouble(secondNumberTextBox.Text);
            double result = fn - sn;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            fn = Convert.ToDouble(firstNumberTextBox.Text);
            sn = Convert.ToDouble(secondNumberTextBox.Text);
            double result = fn * sn;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            fn = Convert.ToDouble(firstNumberTextBox.Text);
            sn = Convert.ToDouble(secondNumberTextBox.Text);
            double result = fn / sn;
            resultTextBox.Text = Convert.ToString(result);
        }
    }
}
