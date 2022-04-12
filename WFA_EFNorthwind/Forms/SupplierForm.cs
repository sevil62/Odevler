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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db=new NorthwindEntities();
        private void GetSuppliers()
        {
            listView1.Items.Clear();
            foreach (Supplier supplier in db.Suppliers)
            {
                ListViewItem liv=new ListViewItem();
                liv.Text=supplier.SupplierID.ToString();
                liv.SubItems.Add(supplier.CompanyName);
                liv.SubItems.Add(supplier.ContactName);
                liv.SubItems.Add(supplier.City);
                listView1.Items.Add(liv);

            }
        }

        private void AddSupplier()
        {
            Supplier supplier = new Supplier();
            supplier.CompanyName =txtCompanyName.Text;
            supplier.ContactName =txtContactName.Text;
            supplier.City=txtCity.Text;
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            MessageBox.Show("Kaydetme işlemi başarıyla gerçekleşti");
            GetSuppliers();
            txtCity.Text = "";
            txtCompanyName.Text = "";
            txtContactName.Text = "";
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            GetSuppliers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }
    }
}
