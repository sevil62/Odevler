using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAylar_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text.ToLower();
            string aylar = "";
            //Karar yapıları
            #region IfElse
            //string mevsim = textBox1.Text.ToLower();
            //string aylar = "";

            //if (mevsim == "kış")
            //{
            //    aylar = "Aralık\nOcak\nŞubat";
            //}
            //else if (mevsim == "ilkbahar")
            //{
            //    aylar = "Mart\nNisan\nMayıs";
            //}
            //else if (mevsim == "yaz")
            //{
            //    aylar = "Haziran\nTemmuz\nAğustos";
            //}
            //else if (mevsim == "sonbahar")
            //{
            //    aylar = "Eylül\nEkim\nKasım";
            //}
            //else
            //{
            //    aylar = "böyle bir mevsim duymadım!";
            //}
            //MessageBox.Show(aylar);
            #endregion

            switch (mevsim)//armut
            {
                case "kış":
                    aylar = "Aralık\nOcak\nŞubat";
                    break;
                case "yaz":
                    aylar = "Haziran\nTemmuz\nAğustos";
                    break;
                case "ilkbahar":
                    aylar = "Mart\nNisan\nMayıs";
                    break;

                case "sonbahar":
                    aylar = "Eylül\nEkim\nKasım";
                    break;
                default:
                    aylar = "böyle bir mevsim duymadım";
                    break;
            }
            MessageBox.Show(aylar);
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            //Eğer txtKontrol'e girilen "admin" "moderatör" "yönetici" "ceo" "başkan" girilirse mesaj kutusunda "yönetim paneline yönlendiriliyorsunuz..."
            //"üye" girilirse "anasayfaya yönlendiriliyorsunuz..."
            //harici bir değer girilirse "bu sayfayı görüntülemeye yetkiniz bulunmamaktadır". mesajını kullanıcıya verin.

            string gelenDeger = txtKontrol.Text.ToLower();

            switch (gelenDeger)
            {
                case "admin":
                case "moderatör":
                case "yönetici":
                case "ceo":
                case "başkan":
                    MessageBox.Show("yönetim paneline yönlendiriliyorsunuz...");
                    break;
                case "üye":
                    MessageBox.Show("anasayfaya yönlendiriliyorsunuz...");
                    break;
                default:
                    MessageBox.Show("bu sayfayı görüntülemeye yetkiniz bulunmamaktadır");
                    break;

            }

        }
        string kullaniciAdi = "bilgeadam";
        string sifre = "1234";
        private void button1_Click(object sender, EventArgs e)
        {
            //Eğer txtKullanıcıAdı'na girilen değer "bilgeadam" ve txtSifreye girilen değer "1234" ise "Profil sayfasına yönlendiriliyorsunuz...";
            //Kullanıcı adı doğru şifre yanlışsa "kullanıcı adınız doğru ancak şifreniz yanlış",
            //kullanıcı adı yanlışsa "kullanıcı adınız yanlış şifreye bakmadım bile" mesajını kullanıcıya gösterin.
            kullaniciAdi=txtKullaniciAdi.Text.ToLower();
            sifre=txtSifre.Text.ToLower();

            switch (kullaniciAdi)
            {
                case "bilgeadam":
                    switch (sifre)
                    {
                        case "1234":
                            MessageBox.Show("Profil sayfasına yönlendiriliyorsunuz");
                            break;
                        default:
                            MessageBox.Show("Kulanıcı adı doğru ama şifre yalnış");
                            break;

                    }
                    break;

                default:

                    MessageBox.Show("Kullanıcı adınız yalnıi şifreye bakulmadı");
                    break;

            }
        }
    }
}
