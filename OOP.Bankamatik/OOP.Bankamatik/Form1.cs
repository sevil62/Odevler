using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Bankamatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bakiye bakiye=new Bakiye();
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            bakiye.BakiyeTutar = 500;
            bakiye.CekilenTutar =Convert.ToInt32( nudParaCek.Value);
            bakiye.BakiyeSonuc=bakiye.BakiyeTutar-bakiye.CekilenTutar;
            lblBakiye.Text = bakiye.BakiyeSonuc.ToString();
            lstSonuc.Items.Add("Cekilen para:"+bakiye.CekilenTutar+" "+"Kalan bakiye:"+ bakiye.BakiyeSonuc);

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            bakiye.BakiyeTutar=500;
            bakiye.YatirilanTutar =Convert.ToInt32( nudParaYatir.Value);
            bakiye.BakiyeSonuc = bakiye.BakiyeTutar + bakiye.YatirilanTutar;
            lblBakiye.Text=bakiye.BakiyeSonuc.ToString();
            lstSonuc.Items.Add("Yatırılan para:" + bakiye.YatirilanTutar + " " + "Toplam bakiye:" + bakiye.BakiyeSonuc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSonuc.Items.Clear();
        }
    }
}
