using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimarideneme3.Rapor
{
    public abstract class RaporBuilder
    {
        protected RaporBilgi Bilgi;

        public RaporBuilder (RaporBilgi raporBilgi)
        {
            string cikti = HeaderGetir();
            cikti += İcerikGetir();
            cikti += FooterGetir();
        }
        public abstract string HeaderGetir();
        public abstract string İcerikGetir();
        public abstract string FooterGetir();
    }
}
