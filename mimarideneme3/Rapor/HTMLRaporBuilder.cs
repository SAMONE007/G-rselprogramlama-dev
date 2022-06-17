using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimarideneme3.Rapor
{
    public class HTMLRaporBuilder : RaporBuilder
    {
        public HTMLRaporBuilder(RaporBilgi raporBilgi):base(raporBilgi)
        { }
        public override string FooterGetir()
        {
            string ad = Form4.ad.ToString();
            string soyad = Form4.soyad.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<h1> {0} </h1>  <h1> {1} </h1>", ad, soyad));
            return sb.ToString();
        }

        public override string HeaderGetir()
        {
            string tc = Form4.tc.ToString();
            string tarih = Form4.tarih.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<h1> {0} </h1>  <h1> {1} </h1>", tc, tarih));
            return sb.ToString();
        }

        public override string İcerikGetir()
        {
            string binis = Form4.binis.ToString();
            string inis = Form4.inis.ToString();
            StringBuilder sb = new StringBuilder();
            Random rastgele = new Random();
            int fiyat = rastgele.Next(150, 500);
            sb.Append(string.Format("<h1> {0} </h1>  <h1> {1} </h1> <h1> {2} </h1>", binis,inis,fiyat));
            return sb.ToString();
        }
    }
}
