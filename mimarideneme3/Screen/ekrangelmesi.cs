using mimarideneme3.AbstractFactory;
using mimarideneme3.Interfaces;
using mimarideneme3.Konaklamaklasör;
using mimarideneme3.Ulasimklasör;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimarideneme3.Screen
{
    public class ekrangelmesi
    {
        private SoyutFabrika _soyutFabrika;
        private IUlasim _ulasim;
        private IKonaklama _konaklama;

        public ekrangelmesi(SoyutFabrika soyutFabrika)
        {
            _soyutFabrika = soyutFabrika;
           // _ulasim = soyutFabrika.YaratUlasim();
            //_konaklama = soyutFabrika.YaratKonaklama();

        }

        public void ekranolustur()
        {
            _ulasim.OlusturUlasim();
            _konaklama.OlusturKonaklama();
        }
    }
}
