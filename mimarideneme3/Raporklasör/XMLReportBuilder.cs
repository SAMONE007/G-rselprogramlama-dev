using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class XMLReportBuilder:IReportBuilder
    {
        private ProductXML xmlRapor = new ProductXML();

        public XMLReportBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.xmlRapor = new ProductXML();
        }
        public void BuildPartA(string ad, string soyad, string tcNo)
        {
            string part1 = "{ \"Ad\": \"" + ad + "\", \"Soyad\": \"" + soyad + "\",\"TCNo\": " + tcNo + ",";
            this.xmlRapor.Add(part1);
        }
        public void BuildPartB(string ulasimTipi, string tarih, string lokasyon, string sirket)
        {
            string part2 = "\"Ulaşım\": { \"tipi\": \"" + ulasimTipi + "\", \"tarihi\": \"" + tarih + "\", \"ülkeler\": \"" + lokasyon + "\",\"firma\": \"" + sirket + "\",\"ücret\": \"50 TL\"}, ";
            this.xmlRapor.Add(part2);

        }
        public void BuildPartC(string konaklamaTipi, string konaklamaBilgi)
        {
            string part3 = "\"Konaklama\": {\"tipi\": \"" + konaklamaTipi + "\",\"inOutTarih\": \"" + konaklamaBilgi + "\",\"ücret\": \"150 TL\"}}";
            this.xmlRapor.Add(part3);
        }
        public ProductXML GetProduct()
        {
            ProductXML sonuç = this.xmlRapor;

            this.Reset();

            return sonuç;
        }
    }
}
