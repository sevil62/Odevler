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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db=new NorthwindEntities();
        private void GetCustomers()
        {
           listView1.Items.Clear();
            foreach (Customer customer in db.Customers)
            {
                ListViewItem liv = new ListViewItem();
                liv.Text=customer.CustomerID.ToString();
                liv.SubItems.Add(customer.CompanyName);
                liv.SubItems.Add(customer.Phone);
                listView1.Items.Add(liv);

            }
        }

        private void AddCustomer()
        {
            try
            {
                Customer customer = new Customer();
                customer.CustomerID =txtCustomerID.Text;
                customer.CompanyName = txtCompanyName.Text;
                customer.Phone = txtPhone.Text;
                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show("Kayıt işlemi tamamlandı");
                GetCustomers();
                txtCustomerID.Text = "";
                txtCompanyName.Text = "";
                txtPhone.Text = "";
                txtCompanyName.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
    }
}
