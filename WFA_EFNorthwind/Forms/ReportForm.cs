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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db=new NorthwindEntities();
         private void CategoryList()
        {
            foreach (Category category in db.Categories)
            {
                listBox1.Items.Add(category.CategoryName+" "+category.Products.Count);

            }
        }
        private void OrderList()
        {
          var result=db.Orders.GroupBy(x=>x.Employee.FirstName).Select(x => new
          {
              Calisan=x.Key,
              SiparisAdet=x.Count()

          }).ToList();
            listBox2.DataSource = result;
        }

        private void EmployeeList()
        {
           
           var result = db.Employees.GroupBy(x => x.Country).Select(x => new
           {
              Ulke= x.Key,
              Kisi=x.Count()
           }).ToList();

            listBox3.DataSource = result;
        
            
        }
        private void OrderTarih()
        {
            var result=db.Orders.Where(x=>x.OrderDate>=dateTimePicker1.Value && x.OrderDate <= dateTimePicker2.Value).Select(x => new
            {
                x.OrderID,
                
            });
        }
        private void EmployeeOrder()
        {
            var result = db.Orders.Where(x => x.Employee.FirstName == textBox1.Text).Select(x => new
            {
                x.OrderID,
                x.Employee.LastName,
            }).ToList();

            listBox5.DataSource = result;

        }
        private void ProductListTarih()
        {
            var result=db.Products.Where(x=>x.UnitPrice>=numericUpDown1.Value && x.UnitPrice<=numericUpDown2.Value ).Select(x => new
            {
                x.ProductName,
                x.Category.CategoryName
            }).ToList();
            listBox6.DataSource = result;
        }


        private void ReportForm_Load(object sender, EventArgs e)
        {
            CategoryList();
            OrderList();
            EmployeeList();
           
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OrderTarih();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            EmployeeOrder();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductListTarih();
        }
    }
}
