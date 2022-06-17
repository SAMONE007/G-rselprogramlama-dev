using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimarideneme3.Rapor
{
    class Raporyonetici
    {
        private RaporBuilder Builder;
        
        public Raporyonetici(RaporBuilder builder)
        {
            Builder = builder;
        
        }

        public string RaporGetir()
        {
            string product = Builder.HeaderGetir();
            product += Builder.İcerikGetir();
            product += Builder.FooterGetir();
            return product;
        }
    }
}
