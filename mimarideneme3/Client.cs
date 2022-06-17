using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Client
    {
        private IAbstractFactory _abstractFactory;
        private IAbstractKonaklama _konaklama;
        private IAbstractUlasim _ulasim;

        public Client(IAbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
            _ulasim = _abstractFactory.UlasimBilgiDoldur();
            _konaklama = _abstractFactory.KonaklamaBilgiDoldur();
        }
        public string HTML_Rapor(string ad,string soyad,string tcNo)
        {
            Director director = new Director();
            HTMLReportBuilder builder = new HTMLReportBuilder();
            director.Builder = builder;

            director.BuildDüzdenRapor(ad,soyad,tcNo,_ulasim.GetType().Name,_ulasim.GetUlasimTarihBilgi(),_ulasim.GetUlasimLokasyonBilgi(),_ulasim.GetUlasimSirketBilgi(),_konaklama.GetType().Name,_konaklama.GetKonaklamaBilgi());

            return builder.GetProduct().ListParts();
        }
        public string XML_Rapor(string ad, string soyad, string tcNo)
        {
            Director director = new Director();
            JSONReportBuilder builder = new JSONReportBuilder();
            director.Builder = builder;

            director.BuildDüzdenRapor(ad, soyad, tcNo, _ulasim.GetType().Name, _ulasim.GetUlasimTarihBilgi(), _ulasim.GetUlasimLokasyonBilgi(), _ulasim.GetUlasimSirketBilgi(), _konaklama.GetType().Name, _konaklama.GetKonaklamaBilgi());

            return builder.GetProduct().ListParts();
        }
        public string JSON_Rapor(string ad, string soyad, string tcNo)
        {
            Director director = new Director();
            XMLReportBuilder builder = new XMLReportBuilder();
            director.Builder = builder;

            director.BuildDüzdenRapor(ad, soyad, tcNo, _ulasim.GetType().Name, _ulasim.GetUlasimTarihBilgi(), _ulasim.GetUlasimLokasyonBilgi(), _ulasim.GetUlasimSirketBilgi(), _konaklama.GetType().Name, _konaklama.GetKonaklamaBilgi());

            return builder.GetProduct().ListParts();
        }        
    }
}
