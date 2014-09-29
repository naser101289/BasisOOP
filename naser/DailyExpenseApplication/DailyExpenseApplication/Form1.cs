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
using CSVLib;

namespace DailyExpenseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         string fileLocation = @"D:\My Csv Fileeee.csv";

         double amount;
         string category;
         string particular;

        private void saveButton_Click(object sender, EventArgs e)

        {

                amount = Convert.ToDouble(amountTextBox.Text);
                category = categoryComboBox.Text;
                particular = particularTextBox.Text;


                FileStream aNewStream = new FileStream(fileLocation, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aNewStream);
                List<string> dailyExpense = new List<string>();


                dailyExpense.Add(amount.ToString());
                dailyExpense.Add(category);
                dailyExpense.Add(particular);

                aWriter.WriteRow(dailyExpense);

                aNewStream.Close();

                amountTextBox.Text = "";
                categoryComboBox.Text = "";
                particularTextBox.Text = "";

            MessageBox.Show("Saved");


        }
        

        private void showButton_Click(object sender, EventArgs e)
        {
            double total = 0;
           

            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> dailyExpense = new List<string>();

            List<string> maxExpense = new List<string>();

            while (aReader.ReadRow(dailyExpense))
            {
                
                amount = Convert.ToDouble(dailyExpense[0]);
                double check = amount;

                total += amount;
                maxExpense.Add(amount.ToString());
            }

            double maximum = Convert.ToDouble(maxExpense.Max());
            maximumExpenseTextBox.Text = maximum.ToString();
            totalExpenseTextBox.Text = total.ToString();
          
            aStream.Close();

        }

        private void sshowButton_Click(object sender, EventArgs e)
        {
           
        }

    }
}
