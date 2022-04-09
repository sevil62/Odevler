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
        string[] konular = { "if-else", "While", "Do-While", "Foreach", "Hata Yonetimi", "Constructor", "İnterface", "Polimorphism", "Abstaraction", "Encapsilacion", "İnheritance", "Static", };

        Random rnd = new Random();
        Random rnd2 = new Random();
        Random rnd3=new Random();
        int konu;
        int ad;
        int soyad;


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ogrenciAdlari.Length && i<ogrenciSoyadlari.Length; i++)
            {
                
                listBox1.Items.Add(ogrenciAdlari[i] + ogrenciSoyadlari[i]);
            }

            for (int j = 0; j < konular.Length; j++)
            {
                listBox2.Items.Add(konular[j]);
            }
            
        }

        private void btnBilirKisi_Click(object sender, EventArgs e)
        {
            ad=rnd.Next(0,ogrenciAdlari.Length);
            soyad=rnd2.Next(0,ogrenciSoyadlari.Length);
            konu=rnd3.Next(0,konular.Length);

            MessageBox.Show("Kişi"+" "+ogrenciAdlari[ad]+" "+ogrenciSoyadlari[soyad]+" "+"Konu"+" "+konular[konu]);

            listBox1.Items.Remove(ogrenciAdlari[ad]+ogrenciSoyadlari[soyad]);



        }
    }
}
