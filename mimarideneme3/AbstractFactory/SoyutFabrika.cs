using mimarideneme3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mimarideneme3.Form1;

namespace mimarideneme3.AbstractFactory
{
    public abstract class SoyutFabrika
    {
        public abstract IUlasim YaratUlasim(string ad, string soyad, string tc, string koltukno, string tarih, string binis, string inis);
        public abstract IKonaklama YaratKonaklama(string ad,string soyad,string tc, string koltukno,string tarih,string binis,string inis);

      
    }
}
