using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimarideneme3.Rapor
{
    class XMLRaporBuilder:RaporBuilder
    {
        public XMLRaporBuilder(RaporBilgi raporBilgi) : base(raporBilgi)
        { }
        public override string FooterGetir()
        {
            string ad = Form4.ad.ToString();
            string soyad = Form4.soyad.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<Footer> {0} </Footer> <Footer> {1} </Footer> ", ad, soyad));
            return sb.ToString();
        }

        public override string HeaderGetir()
        {
            string tc = Form4.tc.ToString();
            string tarih = Form4.tarih.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<Header> {0} </Header>  <Header> {1} </Header>", tc, tarih));
            return sb.ToString();
        }

        public override string İcerikGetir()
        {
            string binis = Form4.binis.ToString();
            string inis = Form4.inis.ToString();
            StringBuilder sb = new StringBuilder();
            Random rastgele = new Random();
            int fiyat = rastgele.Next(150, 500);


            sb.Append(string.Format("<Header> {0} </Header>  <Header> {1} </Header>  <Header> {2}</Header>", binis, inis,fiyat));
            return sb.ToString();
        }
    }
}
