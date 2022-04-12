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
    public partial class ShipperForm : Form
    {
        public ShipperForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db=new NorthwindEntities();

        private void GetShippers()
        {
            listView1.Items.Clear();
            foreach (Shipper shipper in db.Shippers)
            {
                ListViewItem liv=new ListViewItem();
                liv.Text=shipper.ShipperID.ToString();
                liv.SubItems.Add(shipper.CompanyName);
                liv.SubItems.Add(shipper.Phone);
                listView1.Items.Add(liv);

            }
        }

        private void AddShipper()
        {
            Shipper shipper = new Shipper();
            shipper.CompanyName =txtCompanyName.Text;
            shipper.Phone =txtPhone.Text;
            db.Shippers.Add(shipper);
            db.SaveChanges();
            MessageBox.Show("Son kayıtta tamamdır :)");
            GetShippers();
            txtCompanyName.Text = "";
            txtPhone.Text = "";
        }

        private void ShipperForm_Load(object sender, EventArgs e)
        {
            GetShippers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddShipper();
        }
    }
}
