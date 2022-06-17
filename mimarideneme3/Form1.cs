using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace mimarideneme3
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            con = new SqlConnection("Data Source=DESKTOP-MES942P;Initial Catalog=mimari;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM logingiris where kullanici_adi ='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız !!");
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }

    
}
