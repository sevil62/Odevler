using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AracKaydi
{
    public class Arac
    {

        public string Marka { get; set; }
       
        public string Model { get; set; }
        public string YakıtTip { get; set; }
        public string VitesTip { get; set; }
        public string Renk { get; set; }

        private int _modelYili;

        public int ModelYili 
        {
            get
            {
                return _modelYili;
            }
            set
            {
                if (value > 2010)
                {
                    _modelYili = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Model yılı ekleyiniz.");
                }
            }
        }

    }
}
