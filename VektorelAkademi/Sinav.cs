using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorelAkademi
{
    public class Sinav
    {
        public int Id;
        public string Ad;
        public int SoruSayisi;
        public string Cevap;
        public DateTime SinavTarihi;
        public List<Soru> sorular;

        public Sinav(int id, string ad, int soruSayisi, string cevap, DateTime sinavTarihi)
        {
            Id = id;
            Ad = ad;
            SoruSayisi = soruSayisi;
            Cevap = cevap;
            SinavTarihi = sinavTarihi;
        }
    }
}
