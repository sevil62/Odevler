using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.TahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 5;
        int sayi;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd=new Random();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            sayi =Convert.ToInt32( txtTahmin.Text);
            if (hak<5)
            {
                if (true)
                {

                }

            }
        }
    }
}
