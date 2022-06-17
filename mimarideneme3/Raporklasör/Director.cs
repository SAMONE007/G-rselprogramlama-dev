using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    public class Director
    {
        private IReportBuilder _builder;
        public IReportBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildDüzdenRapor(string ad, string soyad, string tcNo, string ulasimTipi, string tarih, string lokasyon, string sirket, string konaklamaTipi, string konaklamaBilgi)
        {
            this._builder.BuildPartA(ad,soyad,tcNo);
            this._builder.BuildPartB(ulasimTipi,tarih,lokasyon,sirket);
            this._builder.BuildPartC(konaklamaTipi,konaklamaBilgi);
        }
    }
}
