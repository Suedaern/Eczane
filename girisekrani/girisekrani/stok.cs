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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        OleDbCommand komut = new OleDbCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ds.Tables.Clear();
            dataGridView1.Refresh();
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter("Select İlaç_adı,Ürün_grubu,Üretici_firma,Etken_madde,ATC_kodu,Reçete_tipi,Miktarı,Fiyatı,Alınan_adet from ilaç_kayıt where kullanıcı_adı='" + textBox1.Text + "' AND İlaç_adı='" + textBox5.Text + "'", baglanti);
            da.Fill(ds, "ilaç_kayıt");
            dataGridView1.DataSource = ds.Tables["ilaç_kayıt"];
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokekle stokekle = new stokekle();
            stokekle.Show();
            this.Hide();
        }

        private void stok_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.kullanıcı.ToString();
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter("Select İlaç_adı,Ürün_grubu,Üretici_firma,Etken_madde,ATC_kodu,Reçete_tipi,Miktarı,Fiyatı,Alınan_adet from ilaç_kayıt where kullanıcı_adı='" + textBox1.Text + "' ORDER BY İlaç_adı ASC ", baglanti);
            da.Fill(ds, "ilaç_kayıt");
            dataGridView1.DataSource = ds.Tables["ilaç_kayıt"];
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ds.Tables.Clear();
            dataGridView1.Refresh();
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter("Select İlaç_adı,Ürün_grubu,Üretici_firma,Etken_madde,ATC_kodu,Reçete_tipi,Miktarı,Fiyatı,Alınan_adet from ilaç_kayıt where kullanıcı_adı='" + textBox1.Text + "' ORDER BY İlaç_adı ASC ", baglanti);
            da.Fill(ds, "ilaç_kayıt");
            dataGridView1.DataSource = ds.Tables["ilaç_kayıt"];
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            ds.Tables.Clear();
            dataGridView1.Refresh();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from ilaç_kayıt where  İlaç_adı='" + textBox2.Text + "'";
            komut.ExecuteNonQuery();
            OleDbDataAdapter da = new OleDbDataAdapter("Select İlaç_adı,Ürün_grubu,Üretici_firma,Etken_madde,ATC_kodu,Reçete_tipi,Miktarı,Fiyatı,Alınan_adet from ilaç_kayıt where kullanıcı_adı='" + textBox1.Text + "'", baglanti);
            da.Fill(ds, "ilaç_kayıt");
            dataGridView1.DataSource = ds.Tables["ilaç_kayıt"];
            baglanti.Close();
        }
    }
}
