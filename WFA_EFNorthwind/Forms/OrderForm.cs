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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db=new NorthwindEntities();
        private void GetOrders()
        {
            listView1.Items.Clear();
            foreach (Order order in db.Orders)
            {
                ListViewItem liv=new ListViewItem();
                liv.Text=order.OrderID.ToString();
                liv.SubItems.Add(order.ShipName);
                liv.SubItems.Add(order.ShipAddress);
                liv.SubItems.Add(order.ShipCity);
                listView1.Items.Add(liv);
            }

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetOrders();
        }
    }
}
