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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db=new NorthwindEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {

            foreach (User user in db.Users)
            {
                if (user.FirstName == textBox1.Text && user.Password == textBox2.Text)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                   
                }
               

            }
                
            
        }
    }
}
