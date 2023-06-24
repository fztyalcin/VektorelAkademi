using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorelAkademi
{
    public class Ogrenci
    {
        public int Id;
        public string Ad;
        public string Soyad;
        public decimal Not;
        public bool OgrenciGeldiMi;

        public Ogrenci(int id, string ad, string soyad, decimal not, bool ogrenciGeldiMi)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Not = not;
            OgrenciGeldiMi = ogrenciGeldiMi;
        }
    }
}
