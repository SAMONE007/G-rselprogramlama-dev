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
namespace mimarideneme3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MES942P;Initial Catalog=mimari;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"update logingiris set sifre=@sifre where kullanici_adi='{textBox1.Text}'",baglanti);
            
            //komut.Parameters.AddWithValue("@kullanici_ad", textBox1.Text);
            
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi Tebrikler");


        }
    }
}
