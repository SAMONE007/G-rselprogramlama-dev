using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    public class ProductHTML
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string htmlRapor = "";

            for (int i = 0; i < this._parts.Count; i++)
            {
                htmlRapor += this._parts[i];
            }

            return htmlRapor;
        }
    }
}
