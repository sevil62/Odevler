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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button btn = new Button();
                   
                    btn.Text = (i + "x" + j).ToString();
                    btn.Left = this.ClientSize.Width-btnEkle.Width;
                    btn.Top = this.ClientSize.Height-btnEkle.Height;
                    btn.Location = new Point(btnEkle.Width*j, btnEkle.Height * i);
                   
                    this.Controls.Add(btn);

                }
                
               
               
            }
        }
    }
}
