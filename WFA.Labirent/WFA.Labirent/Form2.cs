using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.Labirent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int buton1 = 2;
        int buton2 = 2;
        int buton3 = 2;
        int buton4 = 2;
        int buton5 = 2;
        int buton6 = 2;
        int buton7 = 2;
        int buton8 = 2;
        int buton9 = 2;
        int buton10 = 2;
        int buton11 = 2;
        int buton12 = 10;
        int toplam;

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
            

            label10.Visible = false;
           
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            lblFinish.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            lblToplam.Visible = false;
            label1.Visible=false;
            btn1.Visible = false;

            btn10.Visible = false;
            btn11.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;
            btnSuper.Visible = false;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {


            if (txtAd.Text == "Sevil" && txtSoyad.Text == "Aydın")
            {
                MessageBox.Show("Oyunu başlatabilirsiniz");
            }

            else
            {
                MessageBox.Show("Hatalı giriş oyunu başlatamazsınız");
            }

            label10.Visible = true;
           lblToplam.Visible=true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            lblFinish.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label1.Visible = true;


            btn1.Visible = true;

            btn10.Visible = true;
            btn11.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;
            btnSuper.Visible = true;
        }
        

        private void lblFinish_MouseHover_1(object sender, EventArgs e)
        {
            MessageBox.Show("Oyunu kazandınız");
        }




        private void btn11_MouseHover(object sender, EventArgs e)
        {
            toplam = buton11;
            lblToplam.Text = toplam.ToString();
            btn11.Visible = false;
        }

        private void btn10_MouseHover(object sender, EventArgs e)
        {

            toplam = buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn10.Visible = false;
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            toplam = buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn8.Visible = false;

        }

        private void btn9_MouseHover(object sender, EventArgs e)
        {
            toplam = buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn9.Visible = false;

        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            toplam = buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn7.Visible = false;

        }

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            toplam = buton6 + buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn6.Visible = false;
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            toplam = buton4 + buton6 + buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn4.Visible = false;
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            toplam = buton5 + buton4 + buton6 + buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn5.Visible = false;
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            toplam = buton3 + buton5 + buton4 + buton6 + buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn3.Visible = false;
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            toplam = buton2 + buton3 + buton5 + buton4 + buton6 + buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn2.Visible = false;
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            toplam = buton1 + buton2 + buton3 + buton5 + buton4 + buton6 + buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btn1.Visible = false;
        }

        private void btnSuper_MouseHover(object sender, EventArgs e)
        {
            toplam = buton12 + buton1 + buton2 + buton3 + buton5 + buton4 + buton6 + buton7 + buton9 + buton8 + buton10 + buton11;
            lblToplam.Text = toplam.ToString();
            btnSuper.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Oyunu Kaybettiniz");
        }
    }
}
