using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    public class ProductJSON
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string jsonRapor = "";

            for (int i = 0; i < this._parts.Count; i++)
            {
                jsonRapor += this._parts[i];
            }

            return jsonRapor;
        }
    }
}
