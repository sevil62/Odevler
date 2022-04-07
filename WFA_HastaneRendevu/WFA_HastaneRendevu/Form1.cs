using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRendevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
       
       
       
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            
            
                Brans brans = new Brans(txtBrans.Text);
               
                brans.branslar.Add(brans);
                foreach (Brans brn in brans.branslar)
                {
                    if (cmbHastaBrans.Items.Contains(brn.BransAd))
                    {
                        MessageBox.Show("Farklı bir bölüm ekleyiniz");

                    }
                    else if (!cmbHastaBrans.Items.Contains(brans.branslar))
                    {
                        cmbBrans.Items.Add(brn);
                        cmbHastaBrans.Items.Add(brn.BransAd);
                    }

                }

                txtBrans.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtDoktorAd.Text != String.Empty && cmbBrans.SelectedIndex != -1)
            {

                Brans brans = (Brans)cmbBrans.SelectedItem;
                DoktorBilgileri dr = new DoktorBilgileri();
                dr.DoktorAd = txtDoktorAd.Text;
                dr.DrBrans = brans;
                DoktorBilgileri.drbilgileri.Add(dr);


                txtDoktorAd.Text = "";
                cmbBrans.SelectedIndex = -1;
            }

           
            
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            cmbHastaBrans.Items.Clear();
            RandevuBillgileri rd = new RandevuBillgileri();
            rd.HastaAd = txtHastaAd.Text;
            rd.HastaSoyad = txtHastaAd.Text;
            rd.TCKN = txtTckn.Text;

            if (dateTimePicker1.Value >= DateTime.Today)
            {
                for (int i = 9; i <= 18; i++)
                {
                    for (int j = 0; j < 60; j += 30)
                    {
                        Button btn = new Button();
                        btn.Width = 120;
                        btn.Height = 20;
                        btn.Text = (i + ":" + j).ToString();

                        flowLayoutPanel1.Controls.Add(btn);
                       
                        btn.Click += Btn_Click;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Geçmiş tarihe randevu alamazsınız");
            }




            MessageBox.Show("Randevunuz oluşturuldu"+dateTimePicker1.Value.ToShortTimeString());

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;

            MessageBox.Show("Randevunuz oluşturuldu" + dateTimePicker1.Value.ToShortTimeString() + btn.Text);
               btn.Enabled = false;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbHastaBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (DoktorBilgileri drbilgi in DoktorBilgileri.drbilgileri)
            {
                if (drbilgi.DrBrans.ToString()==cmbHastaBrans.SelectedItem.ToString())
                {
                    cmbDoktorBrans.Items.Add(drbilgi);
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
