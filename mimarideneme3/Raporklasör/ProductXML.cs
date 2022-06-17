using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    public class ProductXML
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string xmlRapor = "";

            for (int i = 0; i < this._parts.Count; i++)
            {
                xmlRapor += this._parts[i];
            }

            return xmlRapor;
        }
    }
}
