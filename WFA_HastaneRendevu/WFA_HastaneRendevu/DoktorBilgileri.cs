using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class DoktorBilgileri
    {
       
        public  string DoktorAd { get; set; }
        public Brans DrBrans { get; set; }
        public static List<DoktorBilgileri> drbilgileri = new List<DoktorBilgileri>();
        public override string ToString()
        {
            return DoktorAd ;
        }


    }
}
