using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KimBilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ogrenciAdlari = { "SEVİL","EDEBALİ MERT", "AZAD", "SILA", "UMUT", "SARUHAN MERT", "ONUR", "Emre", "ENES", "FURKAN SEMİH", "KAAN", "BAHADIR", "MERT", "BURAK", "AHMET CANER", "TUBA" };
        string[] ogrenciSoyadlari = {"AYDIN", "ATALAY", "MAJIDLI", "ŞİRİN", "YILBAŞ", "DEMİRAY", "DOĞRU", "BEKTAŞOĞLU", "SERENLİ", "GÜNEŞ", "ÜNAL", "ARDA", "ÇINAR", "UYSAL", "TAI", "KARADUT BUĞDAY" };
        Random rnd = new Random();
        Random rnd2 = new Random();
        int sayac = 30;


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ogrenciAdlari.Length && i<ogrenciSoyadlari.Length; i++)
            {
                
                listBox1.Items.Add(ogrenciAdlari[i] + ogrenciSoyadlari[i]);
            }
            
        }
        
        private void btnBilirKisi_Click(object sender, EventArgs e)
        {
            timer1.Start();

            int ad = rnd.Next(0, ogrenciAdlari.Length);
            int soyad=rnd2.Next(0, ogrenciSoyadlari.Length);
            int puan ;

            DialogResult dr= MessageBox.Show(ogrenciAdlari[ad]+ogrenciSoyadlari[soyad],"Bilir kişi:",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            ListViewItem liv = new ListViewItem();
            if (dr == DialogResult.Yes)
            {
                puan = 5;
               
                liv.Text = ogrenciAdlari[ad];
                liv.SubItems.Add(ogrenciSoyadlari[soyad]);
                liv.SubItems.Add(puan.ToString());
                timer1.Stop();
                sayac = 30;
                lblSayac.Text = sayac.ToString();
                listView1.Items.Add(liv);
               


            }
            else if (dr == DialogResult.No)
            {
                puan = 0;
                liv.Text = ogrenciAdlari[ad];
                liv.SubItems.Add(ogrenciSoyadlari[soyad]);
                liv.SubItems.Add(puan.ToString());
                timer1.Stop();
                sayac = 30;
                lblSayac.Text = sayac.ToString();
                listView1.Items.Add(liv);
                listBox1.Items.Remove(ogrenciAdlari[ad] + ogrenciSoyadlari[soyad]);
            }
          


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text=sayac.ToString();
            if (sayac==0)
            {
                timer1.Stop();
                lblSayac.Text = sayac.ToString();
            }

        }
    }
}
