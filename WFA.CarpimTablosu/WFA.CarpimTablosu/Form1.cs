using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.CarpimTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++)
            {
                for (int j =1; j <= 10; j++)
                {
                    int sonuc = i * j;


                    lstCarpimTablosu.Items.Add(i +"x"+j+"="+sonuc);
                    
                }
                lstCarpimTablosu.Items.Add("--------------------------------");
                
            }

        }
    }
}
