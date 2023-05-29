using DetayliTranskriptUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetayliTranskriptUygulamasi.Concrete
{
    public class Dersler
    {
        public string Ad { get; set; }
        public int Kredisi { get; set; }


        public Donem DersinDonemi { get; set; }


        public Dersler(string ad, int kredisi, Donem donem)
        {
            Ad = ad;
            Kredisi = kredisi;
            DersinDonemi = donem;


        }

        public override string ToString()
        {
            return $"{Ad}";
        }
    }
}
