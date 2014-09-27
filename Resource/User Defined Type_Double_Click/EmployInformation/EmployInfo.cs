using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployInformation
{
    public partial class InformationUI : Form
    {
        public InformationUI()
        {
            InitializeComponent();
        }

        List<NewEmp> empList = new List<NewEmp>();
        
        NewEmp emp = new NewEmp();

        
        private void btnSave_Click(object sender, EventArgs e)

        {
           // NewEmp emp= new NewEmp();

            emp.aID = Convert.ToInt16(txtID.Text);
            emp.aName = txtname.Text;
            emp.aSalary = Convert.ToDouble(txtSalary.Text);
            emp.address = txtAddress.Text;
            
            // add in lists 

             empList.Add(emp);

       

            // inserting to the list view by call ListViewIteam control

            ListViewItem listViewItem = new ListViewItem(emp.aID.ToString());
            listViewItem.SubItems.Add(emp.aName);
            listViewItem.SubItems.Add(emp.aSalary.ToString());
           
            myListView.Items.Add(listViewItem);

            MessageBox.Show("Save successful");

            txtID.Text = string.Empty;
            txtname.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtAddress.Text = string.Empty;
            
        }

        private void myListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = myListView.SelectedIndices[0];

            // double click seleted values returned to lists

            NewEmp employee = empList[selectedIndex];
            txtID.Text = employee.aID.ToString();
            txtname.Text = employee.aName;
            txtSalary.Text = employee.aSalary.ToString();
            txtAddress.Text = employee.address;
        }
    }
}
