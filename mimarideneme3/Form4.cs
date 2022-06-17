using mimarideneme3.AbstractFactory;
using mimarideneme3.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace mimarideneme3
{
    public partial class Form4 : Form
    {
        private SoyutFabrika _fabrika;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MES942P;Initial Catalog=mimari;Integrated Security=True");
        private SqlDataAdapter da;
        public static string ad = "";
        public static string soyad = "";
        public static string tc = "";
        public static string koltukno = "";
        public static string tarih = "";
        public static string binis = "";
        public static string inis = "";

        public Form4(SoyutFabrika fabrika)
        {
            _fabrika = fabrika;
            InitializeComponent();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label8.Text = Form5.UlasimBilgisi.ToString();
            label9.Text = Form5.KonaklamaBilgisi.ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            IKonaklama konaklama = _fabrika.YaratKonaklama(txtName.Text, txtSoyad.Text, txtTc.Text, txtNo.Text, txtTarih.Text, txtBinis.Text, txtİnis.Text);
            IUlasim ulasim = _fabrika.YaratUlasim(txtName.Text, txtSoyad.Text, txtTc.Text, txtNo.Text, txtTarih.Text, txtBinis.Text, txtİnis.Text);
            MessageBox.Show(konaklama.Ad + " " + konaklama.Soyad + " " + konaklama.Tarih + " " + konaklama.Tc + " " + konaklama.İnis + " " + konaklama.Binis + " " + konaklama.KoltukNo);

            SqlCommand komut = new SqlCommand("insert into rezervasyon(ad,soyad,tc,koltukno,tarih,binis,inis) values('" + konaklama.Ad.ToString() + "','" + konaklama.Soyad.ToString() + "','" + konaklama.Tc.ToString() + "','" + konaklama.KoltukNo.ToString() + "','" + konaklama.Tarih.ToString() + "','" + konaklama.Binis.ToString() + "','" + konaklama.İnis.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Rezervasyon Yapıldı");
            baglanti.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            IKonaklama konaklama = _fabrika.YaratKonaklama(txtName.Text, txtSoyad.Text, txtTc.Text, txtNo.Text, txtTarih.Text, txtBinis.Text, txtİnis.Text);
            //IUlasim ulasim = _fabrika.YaratUlasim(txtName.Text, txtSoyad.Text, txtTc.Text, txtNo.Text, txtTarih.Text, txtBinis.Text, txtİnis.Text);
            string sorgu = "delete from rezervasyon where tc=@tc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", konaklama.Tc);
            komut.ExecuteNonQuery();
            MessageBox.Show("Rezervasyon Silindi");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            IKonaklama konaklama = _fabrika.YaratKonaklama(txtName.Text, txtSoyad.Text, txtTc.Text, txtNo.Text, txtTarih.Text, txtBinis.Text, txtİnis.Text);
            //IUlasim ulasim = _fabrika.YaratUlasim(txtName.Text, txtSoyad.Text, txtTc.Text, txtNo.Text, txtTarih.Text, txtBinis.Text, txtİnis.Text);
            string sorgu = "update rezervasyon set ad=@ad,soyad=@soyad,koltukno=@koltukno,tarih=@tarih,binis=@binis,inis=@inis where tc=@tc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", konaklama.Ad);
            komut.Parameters.AddWithValue("@soyad", konaklama.Soyad);
            komut.Parameters.AddWithValue("@tc", konaklama.Tc);
            komut.Parameters.AddWithValue("@koltukno", konaklama.KoltukNo);
            komut.Parameters.AddWithValue("@tarih", konaklama.Tarih);
            komut.Parameters.AddWithValue("@binis", konaklama.Binis);
            komut.Parameters.AddWithValue("@inis", konaklama.İnis);
            komut.ExecuteNonQuery();
            MessageBox.Show("Rezervasyon Güncellendi");
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            da = new SqlDataAdapter("Select * from rezervasyon", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            ad = txtName.Text.ToString();
            soyad = txtSoyad.Text.ToString();
            tc = txtTc.Text.ToString();
            tarih = txtTarih.Text.ToString();
            koltukno = txtNo.Text.ToString();
            binis = txtBinis.Text.ToString();
            inis = txtİnis.Text.ToString();
            baglanti.Open();
            form6.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
    }
}
