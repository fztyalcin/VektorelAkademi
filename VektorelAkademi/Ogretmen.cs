using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorelAkademi
{
    public class Ogretmen
    {
        public int Id;
        public string Ad;
        public string Soyadı;

        public Ogretmen(int id, string ad, string soyadı)
        {
            Id = id;
            Ad = ad;
            Soyadı = soyadı;
        }
    }
}
