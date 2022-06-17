using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class HTMLReportBuilder:IReportBuilder
    {
        private ProductHTML htmlRapor = new ProductHTML();

        public HTMLReportBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.htmlRapor = new ProductHTML();
        }
        public void BuildPartA(string ad, string soyad, string tcNo)
        {
            string part1= "<!DOCTYPE html><html><style>table, th, td {border: 1px solid black;}</style><body><h2> Seyehat Bilgileri </h2><table style = \"width:100%\"><tr><th> Kişisel Bilgiler </th><th> Ulaşım </th><th> Konaklama </th></tr><tr><td>" + ad + " " + soyad + " " + tcNo + "</td><td>";
            this.htmlRapor.Add(part1);
        }
        public void BuildPartB(string ulasimTipi, string tarih, string lokasyon,string sirket)
        {
            string part2 = "<table style = \"width:100%\"><tr><th> Ulaşım Tipi </th><th> Gidiş - Dönüş Tarihleri </th><th> Nereden Nereye </th><th> Şirket Adı </th><th>Ücret</th></tr><tr><td> " + ulasimTipi + " </td> <td> " + tarih + " </td><td> " + lokasyon + " </td><td> " + sirket + "<td>50 TL</td> </td></tr> ";
            this.htmlRapor.Add(part2);

        }
        public void BuildPartC(string konaklamaTipi, string konaklamaBilgi)
        {
            string part3 = "</table></td><td><table style = \"width:100%\"><tr><th> Konaklama Tipi </th><th> Check In - Check Out Tarihleri</th><th>Ücret</th></tr><tr><td> " + konaklamaTipi + " </td><td> " + konaklamaBilgi + "</td><td>50 TL</td></tr></table></td></table><p> Bizi tercih ettiğiniz için teşekkür ederiz.</p></body></html>";
            this.htmlRapor.Add(part3);
        }
        public ProductHTML GetProduct()
        {
            ProductHTML sonuç = this.htmlRapor;

            this.Reset();

            return sonuç;
        }
    }
}
