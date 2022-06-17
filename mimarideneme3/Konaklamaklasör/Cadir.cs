using mimarideneme3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimarideneme3.Konaklamaklasör
{
    public class Cadir : IKonaklama
    {
        public string Ad { get;  set; }
        public string Soyad { get;  set; }
        public string Tc { get;  set; }
        public string KoltukNo { get;  set; }
        public string Tarih { get;  set; }
        public string Binis { get;  set; }
        public string İnis { get;  set; }
        public void OlusturKonaklama()
        {
            return;
        }
    }
}
