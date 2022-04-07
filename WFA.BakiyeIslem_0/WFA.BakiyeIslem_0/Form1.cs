using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.BakiyeIslem_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal bakiye = 500;
        decimal yatiralan;
        decimal cekilentutar;
       
        private void Form1_Load(object sender, EventArgs e)
        {
           lblBakiye.Text =bakiye.ToString("C2");
           lstSonuc.Items.Clear();
           lstSonuc2.Items.Clear();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            if (bakiye>=nudParaCek.Value)
            {
                if (nudParaCek.Value>0)
                {
                    bakiye-=nudParaCek.Value;
                    lblBakiye.Text = bakiye.ToString("C2");
                    cekilentutar = nudParaCek.Value;
                    lstSonuc.Items.Add("Çekilen Tutar:"+" "+ cekilentutar.ToString("C2")+" "+"Kalan Bakiye:"+" "+ bakiye.ToString("C2"));
                }
                else
                {
                    MessageBox.Show("Hesap yetersizdir");
                }
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            if (bakiye>=nudParaYatir.Value)
            {
                if (nudParaYatir.Value>0)
                {
                    bakiye += nudParaYatir.Value;
                    lblBakiye.Text = bakiye.ToString("C2");
                    yatiralan = nudParaYatir.Value;
                    lstSonuc.Items.Add("Yatırılan Tutar:" + " " + yatiralan.ToString("C2") + " " + "Kalan Bakiye:" + " " + bakiye.ToString("C2"));
                }
                else
                {
                    MessageBox.Show("En az 1 TL ekleyizniz..");
                }

            }
        }

        private void btnAlisveris_Click(object sender, EventArgs e)
        {
            decimal hesap = 0;
            if (bakiye > 0)

            {



                if (chkEkmek.Checked)
                {
                    hesap += 4;
                    lstSonuc2.Items.Add(chkEkmek.Text + " " + hesap.ToString("C2"));

                }
                if (chkYumurta.Checked)
                {
                    hesap += 20;
                    lstSonuc2.Items.Add(chkYumurta.Text + " " + hesap.ToString("C2"));
                }
                if (chkCay.Checked)
                {
                    hesap += 35;
                    lstSonuc2.Items.Add(chkCay.Text + " " + hesap.ToString("C2"));
                }
                if (chkCikoloata.Checked)
                {
                    hesap += 30;
                    lstSonuc2.Items.Add(chkCikoloata.Text + " " + hesap.ToString("C2"));
                }
                if (chkPeynir.Checked)
                {
                    hesap += 45;
                    lstSonuc2.Items.Add(chkPeynir.Text + " " + hesap.ToString("C2"));
                }
                if (hesap <= bakiye)
                {
                    lblToplam.Text = hesap.ToString();
                    bakiye -= hesap;
                    lblBakiye.Text = bakiye.ToString();

                }
                else
                {
                    MessageBox.Show("Bakiyeniz yetersiz");
                }

            }
            else
            {
                MessageBox.Show("Hiç birşey alamazsınız:)");
            }

        }
    }
}
