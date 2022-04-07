using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.InsanKaynaklari
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gelenAd=txtKullaniciAdi.Text;
            string gelensifre=txtSifre.Text;
            if(gelenAd=="admin" && gelensifre == "1234")
            {
                PersonelForm pform=new PersonelForm();
                pform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yanlıştır");
            }
        }
    }
}
