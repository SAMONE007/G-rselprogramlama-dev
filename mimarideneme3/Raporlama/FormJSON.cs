using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimari_proje
{
    public partial class FormJSON : Form
    {
        public FormJSON()
        {
            InitializeComponent();
        }

        private void FormJSON_Load(object sender, EventArgs e)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText("JSONrapor.json", Encoding.UTF8));
            listView1.View = View.Details;
            listView1.Items.Add(new ListViewItem(new string[] { jsonFile["Ad"], jsonFile["Soyad"], jsonFile["TCNo"], jsonFile["Ulaşım"]["tipi"], jsonFile["Ulaşım"]["tarihi"], jsonFile["Ulaşım"]["ülkeler"], jsonFile["Ulaşım"]["firma"], jsonFile["Ulaşım"]["ücret"], jsonFile["Konaklama"]["tipi"], jsonFile["Konaklama"]["inOutTarih"], jsonFile["Konaklama"]["ücret"] }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRaporMenu formRaporMenu = new FormRaporMenu();
            this.Hide();
            formRaporMenu.Show();
        }
    }
}
