using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    public interface IReportBuilder
    {
        void BuildPartA(string ad, string soyad, string tcNo);
        void BuildPartB(string ulasimTipi, string tarih, string lokasyon, string sirket);
        void BuildPartC(string konaklamaTipi, string konaklamaBilgi);
    }
}
