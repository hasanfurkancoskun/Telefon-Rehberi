using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Kişi
    {
        public string ad, soyad, no;
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string No { get => no; set => no = value; }
        public Kişi(string ad, string soyad, string no)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;

        }
    }
}
