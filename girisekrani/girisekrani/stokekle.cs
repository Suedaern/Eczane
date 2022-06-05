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
    public partial class stokekle : Form
    {
        public stokekle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        OleDbCommand komut = new OleDbCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            stok stok = new stok();
            stok.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbCommand com = new OleDbCommand("SELECT * from ilaç_kayıt where İlaç_adı='" + comboBox1.Text + "' AND Kullanıcı_adı='" + textBox3.Text + "'", baglanti);
            com.Connection=baglanti;
            OleDbDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                textBox4.Text = read[8].ToString();
            }

            int sayi2 = Convert.ToInt16(textBox2.Text);
            int sayi1 = Convert.ToInt16(textBox4.Text);
            int sonuç = sayi1 + sayi2;
            string sonuc = sonuç.ToString();
            komut.CommandText = "UPDATE ilaç_kayıt set Fiyatı='" + textBox1.Text + "', Alınan_adet='" + sonuc + "' where İlaç_adı ='" + comboBox1.Text + "' AND Kullanıcı_adı='" + textBox3 +"'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme tamamlandı");
        }

        private void stokekle_Load(object sender, EventArgs e)
        {
            textBox3.Text = giris.kullanıcı.ToString();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from ilaç_kayıt where kullanıcı_adı='" + textBox3.Text + "' ORDER BY İlaç_adı ASC ", baglanti);
            da.Fill(dt);
            comboBox1.ValueMember = "Kullanıcı_adı";
            comboBox1.DisplayMember = "İlaç_adı";
            comboBox1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand com = new OleDbCommand("SELECT * from ilaç_kayıt where İlaç_adı='" + comboBox1.Text + "' AND Kullanıcı_adı='" + textBox3.Text + "'", baglanti);
            com.Connection = baglanti;
            OleDbDataReader read = com.ExecuteReader();
            while(read.Read())
            {
                textBox4.Text = read[8].ToString();
            }
            
            baglanti.Close();
        }
    }
}
