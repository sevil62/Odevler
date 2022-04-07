using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.BarbutTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnZar1.Enabled = false;
            btnZar2.Enabled = false;
            groupBox4.Enabled = false;
        }
        decimal bakiye=500 ;
        decimal bakiye2=500;
        decimal sonuc2; 
        decimal sonuc5;
        decimal toplam;
        decimal puan;
        decimal puan1;
        int zar1, zar2;
        private void btnParaCek_Click(object sender, EventArgs e)
        {
           
            decimal deger=nudParaCek.Value;
            decimal sonuc = bakiye - deger;
            lblBakiye.Text = sonuc.ToString();
            lstSonuc1.Items.Add("Çekilen Tutar"+" "+deger+" "+"Kalan Bakiye"+sonuc);

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            
            decimal deger2=nudParaYatir.Value;
            decimal sonuc1=bakiye + deger2;
            lblBakiye.Text = sonuc1.ToString();
            lstSonuc1.Items.Add("Yatırılan Tutar" + " " + deger2 + " " + "Kalan Tutar" + sonuc1);

        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            puan = nudKatil1.Value;
            sonuc2=bakiye - puan;
            lblBakiye.Text = sonuc2.ToString();
            lblOrta.Text=puan.ToString();
            lstSonuc1.Items.Add("Ortaya Yatırılan Tutar" + " " + puan +" "+ "Kalan Bakiye" + " " + sonuc2);
        }

        private void btnCek2_Click(object sender, EventArgs e)
        {
            
            decimal deger3 = nudcek2.Value;
            decimal sonuc3=bakiye2 - deger3;
            lblbakiye2.Text = sonuc3.ToString();
            lstSonu2.Items.Add("Çekilen Tutar" + " " + deger3 + " " + "Kalan Bakiye " + sonuc3);

        }

        private void btnYatie2_Click(object sender, EventArgs e)
        {
            decimal deger4 = nudYati2.Value;
            decimal sonuc4=bakiye2 - deger4;
            lblbakiye2.Text = sonuc4.ToString();
            lstSonu2.Items.Add("Yatırılan Tutar" + " " + deger4 + " " + "Kalan Bakiye " + sonuc4);
        }

        private void btnYatir1_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            puan1 = nudKatil2.Value;
            sonuc5=bakiye2 - puan1;
            lblbakiye2.Text = sonuc5.ToString();
            toplam = puan + puan1;
            lblOrta.Text = toplam.ToString();
            lstSonu2.Items.Add("Ortaya Yatırılan Tutar" + " " + puan1 + " " + "Kalan Bakiye" + " " + sonuc5);


            btnZar1.Enabled = true;
            btnZar2.Enabled = true;
        }
        Random rnd = new Random();
        private void btnZar1_Click(object sender, EventArgs e)
        {
            zar1=rnd.Next(1,7);
            lblZar1.Text = zar1.ToString();
            lstSonuc.Items.Add("Birinci zar:"+" "+zar1);
            btnZar1.Enabled = false;
        }

        private void btnZar2_Click(object sender, EventArgs e)
        {
             zar2 = rnd.Next(1, 7);
            lblZar2.Text = zar2.ToString();
            lstSonuc.Items.Add("İkinci zar:" + " " + zar2);
            btnZar2.Enabled = false;

            if (zar1>zar2)
            {
                lblSonuc.Text = "Birinci oyuncu Kazandı";
                decimal sontoplam = sonuc2 + toplam;
               lblBakiye.Text= sontoplam.ToString();
                lstSonuc1.Items.Add("Oyunu birinci oyuncu kazandı puanları topladı:)"+" " + sontoplam);
              

            }
            else if(zar2>zar1)
            {
                lblSonuc.Text = "İkinci oyuncu kazandı";
                decimal sontoplam1 = sonuc5 + toplam;
                lblbakiye2.Text = sontoplam1.ToString();
                lstSonu2.Items.Add("Oyunu ikinci oyuncu kazandı puanları topladı:)" + " " + sontoplam1);

            }
            else
            {
               lblSonuc.Text= "Oyun eşit bitti";
            }

           
        }

    }
}

