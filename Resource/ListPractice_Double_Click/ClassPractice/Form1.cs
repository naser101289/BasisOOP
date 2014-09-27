using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ClassPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> idEmployee = new List<int>();
        List<string> nameEmployee = new List<string>();
        List<double> salaryEmployee = new List<double>();
        List<string> addressEmployee = new List<string>();

        private void buttonSave_Click(object sender, EventArgs e)
        {

           int id = Convert.ToInt32(textBoxId.Text);
           string name = textBoxName.Text;
           double  salary = Convert.ToDouble(textBoxSalary.Text);
           string  address = textBoxAddress.Text;
            
            
           idEmployee.Add(id);
           nameEmployee.Add(name);
           salaryEmployee.Add(salary);
           addressEmployee.Add(address);

            ListViewItem anItem = new ListViewItem(id.ToString());

            anItem.SubItems.Add(name.ToString());
           
            anItem.SubItems.Add(salary.ToString());

            listViewShowEmployee.Items.Add(anItem);




        }

        
    }
}
