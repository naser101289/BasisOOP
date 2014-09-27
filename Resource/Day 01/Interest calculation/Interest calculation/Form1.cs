using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_calculation
{
    public partial class InterestcalculatorUI : Form
    {
        public InterestcalculatorUI()
        {
            InitializeComponent();

        }

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {      
                double time =  Convert.ToDouble(timeTextBox.Text);
                double balance = Convert.ToDouble(balanceTextBox.Text);
                double interest;



            if (bankNameComboBox.Text=="BRAC")
            {
                interest = time*balance*(6.0/100.0);
                interestLabel.Text = interest.ToString();

            }
            else if (bankNameComboBox.Text == "DBBL")
            {
                interest = time*balance*(7.0/100.0);
                interestLabel.Text = interest.ToString();
            }
            else
            {
                interest = time*balance*(8.0/100);
                interestLabel.Text = interest.ToString();

            }
        }
    }
}
