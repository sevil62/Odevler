using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.AracKaydi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Arac arac=new Arac();
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            arac.Marka=cmbMarka.SelectedItem.ToString();
            arac.Model =cmbModel.SelectedItem.ToString();
            arac.YakıtTip=cmbYakit.SelectedItem.ToString();
            arac.VitesTip=cmbVites.SelectedItem.ToString();

            arac.Renk=colorDialog1.Color.ToString();
            arac.ModelYili=dateTimePicker1.Value.Year ;

            ListViewItem liv=new ListViewItem();
            liv.Text = arac.Marka;
            liv.SubItems.Add(arac.Model.ToString());
            liv.SubItems.Add(arac.YakıtTip);
            liv.SubItems.Add(arac.VitesTip);
            liv.SubItems.Add("");
            liv.SubItems[4].BackColor = btnRenk.BackColor;
           
            liv.SubItems.Add(arac.ModelYili.ToString());
            listView1.Items.Add(liv);

           
            cmbModel.Items.Clear();
            

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {

            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                
                btnRenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("işlem iptal edildi!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            cmbModel.Items.Clear();
            cmbVites.Items.Clear();
            cmbYakit.Items.Clear();
            //ComboBox'a marka ekleme:
            cmbMarka.Items.Add("Alfa Romeo");
            cmbMarka.Items.Add("Renault");
            cmbMarka.Items.Add("Ferrari");
            cmbMarka.Items.Add("Porsche");
            cmbMarka.Items.Add("Tesla");

            //Yakit Tipi:
            cmbYakit.Items.Add("Dizel");
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Elektrikli");

            //Vites Tipi:
            cmbVites.Items.Add("Otomatik");
            cmbVites.Items.Add("Manuel");
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMarka.SelectedItem)
            {
                case "Alfa Romeo":
                    cmbModel.Items.Add("Giulietta");

                    break;
                case "Renault":
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Clio");

                    break;
                case "Ferrari":
                    cmbModel.Items.Add("California");

                    break;
                case "Porsche":

                    cmbModel.Items.Add("Carrera");
                    break;
                case "Tesla":
                    cmbMarka.Items.Add("XXX");

                    break;
            }
           
        }
    }
}
