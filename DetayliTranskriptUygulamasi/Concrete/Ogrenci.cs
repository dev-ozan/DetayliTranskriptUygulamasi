using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetayliTranskriptUygulamasi.Concrete
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Not { get; set; }
        public Dersler Dersi { get; set; }

        public Ogrenci(string ad, string soyad, int not, Dersler dersi)
        {
            Ad = ad;
            Soyad = soyad;
            Not = not;
            Dersi = dersi;


        }




    }
}
