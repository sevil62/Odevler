using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //RAM'in çalışması yapısını araştırın.
        Random rnd = new Random();
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // pbAt1.Right = 10; //bir tool'u  sadece  sol (left) ve alt (bottom) özelliklerine değer ataması gerçekleştirilir. sağ (right) ve üst (top) değerleri sadece okunabilir (read only)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atları koşturma
            pbAt1.Left += rnd.Next(10, 30);
            pbAt2.Left += rnd.Next(10, 30);
            pbAt3.Left += rnd.Next(10, 30);

            //Kazanma Durumu
            if (pbAt1.Right>=lblFinish.Left)
            {
               
                timer1.Stop();
              DialogResult dr=  MessageBox.Show("1. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr==DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pbAt2.Right>=lblFinish.Left)
            {
                

                timer1.Stop();
                DialogResult dr = MessageBox.Show("2. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
            else if(pbAt3.Right>=lblFinish.Left)
            {
                

                timer1.Stop();
                DialogResult dr = MessageBox.Show("3. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }

            //Spiker
            if (pbAt1.Right > pbAt2.Right && pbAt1.Right > pbAt3.Right)
            {
                lblSpiker.Text = "1. at önde gidiyor...";
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                lblSpiker.Text = "2. at önde gidiyor...";
            }
            else
            {
                lblSpiker.Text = "3. at önde gidiyor";
            }

            //uygulama start olduğunda üç farklı zemin renginden bir tanesini tanımlansın bunlar;
                //kahverengi
                //yeşil
                //gri
            // zemin rengi kahverengi ise 1. at kazansın.
            // zemin rengi yeşil ise 2. at kazansın.
            // zemin rengi gri ise 3. at kazansın.

            //yatir butonuna tıklanmadan yarış başlamayacak.
        }
        Random rndm = new Random();
        int renk;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;
            int renk = rndm.Next(1, 4);

            if (renk==1)
            {
               this.BackColor = Color.Brown;
            }
            else if (renk==2)
            {
                this.BackColor= Color.Green;
            }
            else if (renk==3)
            {
                this.BackColor = Color.Gray;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor==Color.Brown)
            {

                decimal deger1 = numericUpDown1.Value;
                decimal toplam = 1.5m * deger1;
                label9.Text = "Birinci at oyunu kazandı" + toplam;
                btnBaslat.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Green)
            {
                decimal deger2 = numericUpDown2.Value;
                decimal toplam2 = 1.3m * deger2;
                label9.Text = "İkinci at oyunu kazandı" + toplam2;
                btnBaslat.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button3.Enabled= false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Gray)
            {


                decimal deger3 = numericUpDown3.Value;
                decimal toplam3 = 1.8m * deger3;
                label9.Text = "Üçüncü at oyunu kazandı" + toplam3;
                btnBaslat.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled=false;
            }
        }
    }
}
