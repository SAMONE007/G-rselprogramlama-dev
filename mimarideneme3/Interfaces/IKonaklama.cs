using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimarideneme3.Interfaces
{
    public interface IKonaklama
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        string  Tc { get; set; }
        string KoltukNo { get; set; }
        string Tarih { get; set; }

        string Binis { get; set; }

        string İnis { get; set; }

        void OlusturKonaklama();
    }
}
