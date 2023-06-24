using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorelAkademi
{
    public class Ders
    {
        public int Id;
        public string Ad;
        public Sinav Sinav;
        public DateTime BaslamaTarihi;
        public DateTime BitisTarihi;

        public Ders(int id, string ad, Sinav sinav, DateTime baslamaTarihi, DateTime bitisTarihi)
        {
            Id = id;
            Ad = ad;
            Sinav = sinav;
            BaslamaTarihi = baslamaTarihi;
            BitisTarihi = bitisTarihi;
        }
    }
}
