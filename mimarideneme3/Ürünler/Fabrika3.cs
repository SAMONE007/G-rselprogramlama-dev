using mimarideneme3.AbstractFactory;
using mimarideneme3.Interfaces;
using mimarideneme3.Konaklamaklasör;
using mimarideneme3.Ulasimklasör;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimarideneme3.Ürünler
{
    public class Fabrika3 : SoyutFabrika
    {
        public override IKonaklama YaratKonaklama(string ad, string soyad, string tc, string koltukno, string tarih, string binis, string inis)
        {

            return new Cadir()
            {
                Ad = ad,

                Soyad = soyad,

                Tc = tc,

                KoltukNo = koltukno,

                Tarih = tarih,

                Binis = binis,

                İnis = inis



            }
            ;
        }

        public override IUlasim YaratUlasim(string ad, string soyad, string tc, string koltukno, string tarih, string binis, string inis)
        {
            return new Ucak()
            {
                Ad = ad,

                Soyad = soyad,

                Tc = tc,

                KoltukNo = koltukno,

                Tarih = tarih,

                Binis = binis,

                İnis = inis
            }
            ;
        }
    }
}
