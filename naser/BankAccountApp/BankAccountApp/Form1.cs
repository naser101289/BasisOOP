using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account anAccount = new Account();
        

        private void createButton_Click(object sender, EventArgs e)
        {
            if (accountNoTextBox.Text != string.Empty && accountNameTextBox.Text != string.Empty)
            {
                anAccount.SetacName(accountNameTextBox.Text);
                anAccount.SetacNumber(accountNoTextBox.Text);

                accountNameTextBox.Text = string.Empty;
                accountNoTextBox.Text = string.Empty;

                MessageBox.Show(anAccount.GetacName() + ", Your Account Created Successfully.Your Account Number is: " + anAccount.GetacNumber());

            }
            else
            {
                MessageBox.Show("Please Enter Account No. and Account Name First");
            }

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount.GetacName() != null && anAccount.GetacNumber() != null)
            {

                anAccount.Deposit(Convert.ToDouble(amountTextBox.Text));
                
                MessageBox.Show(amountTextBox.Text + " " + "Tk. Deposited Successfully");

                amountTextBox.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Please Create an Acount First");
            }
        }

        private void withdrawnButton_Click(object sender, EventArgs e)
        {
            if (anAccount.GetacName() != null && anAccount.GetacNumber() != null)
            {

                anAccount.Withdrawn(Convert.ToDouble(amountTextBox.Text));
               
                MessageBox.Show(amountTextBox.Text + " " + "Tk. Withdrawn Successfully");

                amountTextBox.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Please Create an Acount First");
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Accoutn Balance: " + anAccount.GetacBalance() + " Tk.");
        }
    }
}
