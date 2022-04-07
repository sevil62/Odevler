using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.RuntimeOdev1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string[] siniflistesi = { "EDEBALİ MERT ATALAY", "AZAD MAJIDLI", "SILA ŞİRİN", "UMUT YILBAŞ", "SARUHAN MERT DEMİRAY", "ONUR DOĞRU", "SEVİL AYDIN", "ENES SERENLİ", "FURKAN SEMİH GÜNEŞ", "KAAN ÜNAL", "BAHADIR ARDA", "MERT ÇINAR", "BURAK UYSAL", "AHMET CANER TAI", "TUBA KARADUT BUĞDAY", "MAHMURE OKAN", "ARYA KAPIKIRAN", "BERK BASAT" };
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = 1;
            for (int i = 1; i <=6 ; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = sayi.ToString();
                    sayi++;
                   
                    btn.Location = new Point(btn.Width * j, btn.Height * i);

                    this.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }


            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int liste=rnd.Next(1,siniflistesi.Length);

            MessageBox.Show(siniflistesi[liste]);
        }
    }
}
