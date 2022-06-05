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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        OleDbCommand komut = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into satış (Kullanıcı_adı,Alan_kişi,Tc_no,Alınan_ilaç,Adet,Toplam_fiyat,Ödeme_şekli) values('" + textBox3.Text.ToString() + "', '" + comboBox1.Text.ToString() + "', '" + comboBox2.Text.ToString() + "', '" + comboBox3.Text.ToString() + "', '" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + comboBox4.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            OleDbCommand com = new OleDbCommand("SELECT * from ilaç_kayıt where İlaç_adı='" + comboBox3.Text + "' AND Kullanıcı_adı='" + textBox3.Text + "'", baglanti);
            com.Connection = baglanti;
            OleDbDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                string sil = read[8].ToString();
                int sayi2 = Convert.ToInt16(textBox1.Text);
                int sayi1 = Convert.ToInt16(sil);
                int sonuç = sayi1 - sayi2;
                string sonuc = sonuç.ToString();
                komut.CommandText = "UPDATE ilaç_kayıt set Alınan_adet='" + sonuc + "' where İlaç_adı ='" + comboBox1.Text + "' AND Kullanıcı_adı='" + textBox3 + "'";
                komut.ExecuteNonQuery();
            }
            baglanti.Close();

            MessageBox.Show("Satış Tamamlandı");

        }

        private void satis_Load(object sender, EventArgs e)
        {
            textBox3.Text = giris.kullanıcı.ToString();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from ilaç_kayıt where Kullanıcı_adı='" + textBox3.Text + "' ORDER BY İlaç_adı ASC ", baglanti);
            da.Fill(dt);
            comboBox3.ValueMember = "Kullanıcı_adı";
            comboBox3.DisplayMember = "İlaç_adı";
            comboBox3.DataSource = dt;
            DataTable data = new DataTable();
            OleDbDataAdapter d = new OleDbDataAdapter("select * from hasta_kayıt where Kullanıcı_adı='" + textBox3.Text + "' ORDER BY Tc_no ASC ", baglanti);
            d.Fill(data);
            comboBox2.ValueMember = "Kullanıcı_adı";
            comboBox2.DisplayMember = "Tc_no";
            comboBox2.DataSource = data;

            DataTable data2 = new DataTable();
            OleDbDataAdapter a = new OleDbDataAdapter("select * from hasta_kayıt where Kullanıcı_adı='" + textBox3.Text + "' ORDER BY Ad_soyad ASC ", baglanti);
            a.Fill(data2);
            comboBox1.ValueMember = "Kullanıcı_adı";
            comboBox1.DisplayMember = "Ad_soyad";
            comboBox1 .DataSource = data2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand com = new OleDbCommand("SELECT * from ilaç_kayıt where İlaç_adı='" + comboBox3.Text + "' AND Kullanıcı_adı='" + textBox3.Text + "'", baglanti);
            com.Connection = baglanti;
            OleDbDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                textBox4.Text = read[7].ToString();
            }
            double sayi2 = Convert.ToDouble(textBox1.Text);
            double sayi1 = Convert.ToDouble(textBox4.Text);
            double sonuç = sayi1 * sayi2;
            string sonuc = sonuç.ToString();
            textBox2.Text = sonuc;

            baglanti.Close();
        }
    }
}
