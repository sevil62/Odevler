using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EFNorthwind.Forms
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void GetEmployee()
        {
            listView1.Items.Clear();
            foreach (Employee employee in db.Employees)
            {
                ListViewItem liv=new ListViewItem();
                liv.Text = employee.EmployeeID.ToString();
                liv.SubItems.Add(employee.FirstName);
                liv.SubItems.Add(employee.LastName);
                listView1.Items.Add(liv);

            }

        }

        private void AddEmployee()
        {
            Employee employee = new Employee();
            employee.FirstName =txtFirstName.Text;
            employee.LastName =txtLastName.Text;
            db.Employees.Add(employee);
            db.SaveChanges();
            MessageBox.Show("Kayıt işlemi başarılı..");
            GetEmployee();
            txtFirstName.Text = "";
            txtLastName.Text = "";

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            GetEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }
    }
}
