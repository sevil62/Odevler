using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.SyisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRastGele_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ListBox)
                {
                    ListBox lb = (ListBox)ctrl;

                    for (int i = 0; i < 6; i++)
                    {
                        int sayi = rnd.Next(1, 49);
                       
                        if (lb.Items.Contains(sayi))
                        {
                            i--;
                            continue;

                        }
                        else
                        {
                            lb.Items.Add(sayi);
                        }
                    }


                }
            }




        }
    }
}
