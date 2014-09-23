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


namespace DailyExpenses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string category;
        private int amount;
        private string particular;
        private int totalExpense = 0;
        private string fileLocation = @"C:\Users\PC21\Desktop\ExamClass\DailyExpenses\DailyExpense.csv";

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxAmount.Text != "" || textBoxParticular.Text != "") { 
            amount = Convert.ToInt32(textBoxAmount.Text);
            category = comboBoxCategory.SelectedItem.ToString();
            particular = textBoxParticular.Text;

            

            textBoxAmount.Text = "";
            textBoxParticular.Text = "";
            


            FileStream aNewStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aNewStream);
            List<string> expanseList = new List<string>();

            expanseList.Add(amount.ToString());
            expanseList.Add(category);
            expanseList.Add(particular);


            aWriter.WriteRow(expanseList);

            MessageBox.Show("Save Successfully");

            aNewStream.Close();
            }

            else
            {
                MessageBox.Show("Please fill the text boxes");
            }

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> showList = new List<string>();

            List<int> maxIndicator = new List<int>();
            

            totalExpense = 0;

            while (aReader.ReadRow(showList))
            {
                int readExpense = Convert.ToInt32(showList[0]);

                int check = readExpense;

                textBoxTotalExpense.Text = "";
                
                totalExpense = totalExpense + check;

                textBoxTotalExpense.Text = totalExpense.ToString();              

                maxIndicator.Add(check);
            }
            
            int maximum = maxIndicator.Max();
            textBoxMaximumExpense.Text = maximum.ToString();

            aStream.Close();
            
        }


        private void buttonShowCategory_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> showList = new List<string>();

            string userCategory = comboBoxCategorwise.SelectedItem.ToString();

            listViewShowDetails.Items.Clear();

            int total = 0;

            while (aReader.ReadRow(showList))
            {
                if (userCategory == showList[1] && comboBoxCategorwise.SelectedItem.ToString()!= "")
                {
                    ListViewItem aItem = new ListViewItem(showList[0]);
                    aItem.SubItems.Add(showList[1]);
                    aItem.SubItems.Add(showList[2]);

                    total = total + Convert.ToInt32(showList[0]);

                    textBoxTotal.Text = total.ToString();

                    listViewShowDetails.Items.Add(aItem);
                }

                


            }

            aStream.Close();
        }


    }
}
