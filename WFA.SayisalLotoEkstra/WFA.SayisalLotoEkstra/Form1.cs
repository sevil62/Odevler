using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.SayisalLotoEkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnRastGele_Click(object sender, EventArgs e)
        {


            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;

                    for (int i = 0; i < 6; i++)
                    {
                        int sayi = rnd.Next(1, 49);

                        if (lst.Items.Contains(sayi))
                        {
                            i--;
                            continue;

                        }
                        else
                        {
                            lst.Items.Add(sayi);
                        }
                    }


                }
            }
                    }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    Label lb = (Label)ctrl;


                    if (lb.Name != "lbl1" && lb.Name != "lbl2" && lb.Name != "lbl3" && lb.Name != "lbl4" && lb.Name != "lbl5" && lb.Name != "lbl6" && lb.Name != "lbl7" && lb.Name != "lbl8")
                    {

                        int sayi = rnd.Next(1, 49);
                        lb.Text = sayi.ToString();

                        if (label9.Text == listBox1.Items.Count.ToString())
                        {
                            listBox1.SelectedItems.ToString();


                        }
                    }
                   
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
