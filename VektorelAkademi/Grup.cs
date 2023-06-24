using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorelAkademi
{
    public class Grup
    {
        public int Id;
        public string Ad;
        public Ogretmen GrupOgretmeni;
        public Ders Ders;
        public Sinav Sinav;
        public List<Ogrenci> Ogrenciler;

        public Grup(int id, string ad, Ogretmen grupOgretmeni, Ders ders, Sinav sinav)
        {
            Id = id;
            Ad = ad;
            GrupOgretmeni = grupOgretmeni;
            Ders = ders;
            Sinav = sinav;

            Ogrenciler = new List<Ogrenci>();
        
        }

        public void OgrenciSec (Ogrenci ogrenci)
        {
            if (!this.Ogrenciler.Contains(ogrenci))
            this.Ogrenciler.Add(ogrenci);
        }

        public void OgrenciCikar (Ogrenci ogrenci)
        {
            if (this.Ogrenciler.Contains(ogrenci))
            this.Ogrenciler.Remove(ogrenci);
        }
    }
}
