using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.Barbut
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
            grp2.Enabled = false;
        }
        decimal cekilen = 0;
        decimal cekilen2 = 0;
        decimal yatirilan = 0;
        decimal yatirilan2 = 0;
        decimal bakiye = 500;
        decimal bakiye2 = 500;
        decimal puanyatir=0;
        
        Random rnd=new Random();
        int zar1, zar2;

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            if (bakiye>cekilen)
            {

                cekilen = nudParaCek.Value;
                bakiye -= cekilen;
                lblBakiye.Text = bakiye.ToString("C2");
                
                lstSonuc1.Items.Add("1.Oyuncu:" + " " +"Çekilen Tutar"+ cekilen.ToString("C2") + " " + "Hesabında kalan:" + " " + bakiye.ToString("C2"));
            }
            


        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            if (bakiye > yatirilan)
            {

                yatirilan = nudParaYatir.Value;
                bakiye += yatirilan;
                lblBakiye.Text = bakiye.ToString("C2");

                lstSonuc1.Items.Add("1.Oyuncu:" + " " + "Yatırılan Tutar" + yatirilan.ToString("C2") + " " + "Hesabına Eklenen:" + " " + bakiye.ToString("C2"));
            }

        }

        private void btnYatir1_Click(object sender, EventArgs e)
        {
            if (bakiye>puanyatir)
            {
                puanyatir = nudKatil1.Value;
                bakiye-=puanyatir;
                lblBakiye.Text = bakiye.ToString("C2");
                lblOrta.Text = puanyatir.ToString();
                lstSonuc1.Items.Add("Aktarılan Puan:"+" "+puanyatir.ToString());
            }
            grp2.Enabled = true;

        }

        private void btnParaCek2_Click(object sender, EventArgs e)
        {
            if (bakiye2>cekilen2)
            {
                cekilen2 = nudParaCek2.Value;
                bakiye2-=cekilen2;
                lblBakiye2.Text = bakiye2.ToString("C2");
                lstSonuc2.Items.Add("2.Oyuncu:" + " " + "Çekilen Tutar" + cekilen2.ToString("C2") + " " + "Hesabında kalan:" + " " + bakiye2.ToString("C2"));
            }
        }

        private void btnYatir2_Click(object sender, EventArgs e)
        {
            if (bakiye2>puanyatir)
            {
                decimal orta;
                puanyatir = nudKatil2.Value;
                bakiye2 -=puanyatir;
                lblBakiye2.Text = bakiye2.ToString("C2");
                orta = nudKatil1.Value + nudKatil2.Value;
                lblOrta.Text = orta.ToString();
                lstSonuc2.Items.Add("Aktarılan Puan:" + " " + puanyatir.ToString());
                btnZar1.Enabled = true;
                btnZar2.Enabled = true;
            }
        }

        private void btnZar1_Click(object sender, EventArgs e)
        {
            zar1 = rnd.Next(1, 7);
            lblZar1.Text = zar1.ToString();
        }

        private void btnZar2_Click(object sender, EventArgs e)
        {
            zar2 = rnd.Next(1, 7);
            lblZar2.Text = zar2.ToString();
            if (zar1>zar2)
            {
                lblSonuc.Text = "Birinci zarı atan kişi kazandı";
                lstSonuc.Items.Add("OyunucuBir:" + " " + zar1+" "+"Oyuncuİki:"+" "+zar2 );


            }
            else if (zar1<zar2)
            {
                lblSonuc.Text = "İkinci zarı atan kişi kazandı";
                lstSonuc.Items.Add("OyunucuBir:" + " " + zar1 + " " + "Oyuncuİki:" + " " + zar2);
            }
            else
            {
                lblSonuc.Text = "Oyunda eşitlik söz konusu";
                lstSonuc.Items.Add("OyunucuBir:" + " " + zar1 + " " + "Oyuncuİki:" + " " + zar2);

            }
        }

        private void btnParaYatir2_Click(object sender, EventArgs e)
        {
            if (bakiye2>yatirilan2)
            {
                yatirilan2 = nudParaYatir2.Value;
                bakiye2 += yatirilan2;
                lblBakiye2.Text = bakiye2.ToString("C2");
                lstSonuc2.Items.Add("2.Oyuncu:" + " " + "Yatırılan Tutar" + yatirilan2.ToString("C2") + " " + "Hesabında kalan:" + " " + bakiye2.ToString("C2"));

            }
        }
    }
}

