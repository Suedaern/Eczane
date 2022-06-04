using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace girisekrani
{
    public partial class ilcblg : Form
    {
        
        public ilcblg()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into ilaç_kayıt (Kullanıcı_adı,Ürün_grubu,Üretici_firma,Etken_madde,ATC_kodu,Reçete_tipi,Miktarı,Fiyatı,Alınan_adet) values('" + textBox1.Text.ToString() + "', '" + ürüngrubutxt.Text.ToString() + "', '" + üreticiFirmatxt.Text.ToString() + "', '" + etkenmaddetxt.Text.ToString() + "', '" + ATCkodutxt.Text.ToString() + "', '" + reçetetipitxt.Text.ToString() + "', '" + miktarıtxt.Text.ToString() + "', '" +fiyatıtxt.Text.ToString() + "', '" + alınanadettxt.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ürüngrubutxt.Items.Clear();
            üreticiFirmatxt.Clear();
            etkenmaddetxt.Clear();
            ATCkodutxt.Items.Clear();
            reçetetipitxt.Items.Clear();
            miktarıtxt.Clear();
            fiyatıtxt.Clear();
            alınanadettxt.Clear();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ilcblg_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.kullanıcı.ToString();
        }
    }
}
