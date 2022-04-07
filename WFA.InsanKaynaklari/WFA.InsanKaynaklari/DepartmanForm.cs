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
    public partial class DepartmanForm : Form
    {
        public DepartmanForm()
        {
            InitializeComponent();
        }
        public static List<Departman> depatmanListesi = new List<Departman>();
        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelForm pform = new PersonelForm();
            
            pform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departman departman = new Departman();
            departman.Ad = textBox1.Text;
            depatmanListesi.Add(departman);
            MessageBox.Show(departman.ToString());


        }
    }
}
