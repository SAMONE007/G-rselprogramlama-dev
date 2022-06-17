using mimarideneme3.AbstractFactory;
using mimarideneme3.Ürünler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimarideneme3
{
    public partial class Form5 : Form
    {
        public static string UlasimBilgisi = " ";
        public static string KonaklamaBilgisi = " ";
        SoyutFabrika fabrika;
        

        public Form5()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Otel");
            comboBox1.Items.Add("Çadır");


            comboBox2.Items.Add("Uçak");
            comboBox2.Items.Add("Otobus");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UlasimBilgisi = comboBox2.SelectedItem.ToString();
            KonaklamaBilgisi = comboBox1.SelectedItem.ToString();
            
            if(UlasimBilgisi=="Uçak" && KonaklamaBilgisi=="Otel")
            {
                fabrika = new Fabrika1();
            }

            if (UlasimBilgisi == "Otobus" && KonaklamaBilgisi == "Otel")
            {
                fabrika = new Fabrika2();
            }


            if (UlasimBilgisi == "Uçak" && KonaklamaBilgisi == "Çadır")
            {
                fabrika = new Fabrika3();
            }

            if (UlasimBilgisi == "Otobus" && KonaklamaBilgisi == "Çadır")
            {
                fabrika = new Fabrika4();
            }
            Form4 form4 = new Form4(fabrika);
            form4.Show();
            this.Hide();
        }
    }
}
