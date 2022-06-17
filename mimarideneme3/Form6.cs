
using mimarideneme3.Rapor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace mimarideneme3
{
    public partial class Form6 : Form
    {


        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }




        private void button1_Click(object sender, EventArgs e)
        {
            RaporBilgi bilgi = new RaporBilgi();

            string ad = Form4.ad.ToString();
            bilgi.detayliBilgi = "";
            bilgi.GenelBilgi = "";

            RaporBuilder builder = new HTMLRaporBuilder(bilgi);
            Raporyonetici raporyonetici = new Raporyonetici(builder);
            
            string str = raporyonetici.RaporGetir();

            System.IO.File.WriteAllText(@"C:\Users\TR-HALOMAN06\Desktop\mimarideneme3\deneme.html", str);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            RaporBilgi bilgi = new RaporBilgi();



            RaporBuilder builder = new HTMLRaporBuilder(bilgi);
            Raporyonetici raporyonetici = new Raporyonetici(builder);

            string str = raporyonetici.RaporGetir();

            System.IO.File.WriteAllText(@"C:\Users\TR-HALOMAN06\Desktop\mimarideneme3\deneme.xml", str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RaporBilgi bilgi = new RaporBilgi();



            RaporBuilder builder = new HTMLRaporBuilder(bilgi);
            Raporyonetici raporyonetici = new Raporyonetici(builder);

            string str = raporyonetici.RaporGetir();

            System.IO.File.WriteAllText(@"C:\Users\TR-HALOMAN06\Desktop\mimarideneme3\deneme.json", str);
        }
    }
}
