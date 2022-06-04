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
    public partial class hstblg : Form
    {
        public hstblg()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ds.Tables.Clear();
            dataGridView1.Refresh();
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter("Select Ad_soyad,Tc_no,Tel_no,Doğum_tarihi,Sosyal_güvencesi,Cinsiyet from hasta_kayıt where kullanıcı_adı='" + textBox1.Text + "' AND Tc_no='" + textBox5.Text + "'", baglanti);
            da.Fill(ds, "hasta_kayıt");
            dataGridView1.DataSource = ds.Tables["hasta_kayıt"];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hstkyt hstkyt = new hstkyt();
            hstkyt.Show();
            this.Hide();
        }

        private void hstblg_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.kullanıcı.ToString();
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter("Select Ad_soyad,Tc_no,Tel_no,Doğum_tarihi,Sosyal_güvencesi,Cinsiyet from hasta_kayıt where kullanıcı_adı='" + textBox1.Text + "'", baglanti);
            da.Fill(ds, "hasta_kayıt");
            dataGridView1.DataSource = ds.Tables["hasta_kayıt"];
            baglanti.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ds.Tables.Clear();
            dataGridView1.Refresh();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from hasta_kayıt where  Tc_no='" + textBox2.Text + "'";
            komut.ExecuteNonQuery();
            OleDbDataAdapter da = new OleDbDataAdapter("Select Ad_soyad,Tc_no,Tel_no,Doğum_tarihi,Sosyal_güvencesi,Cinsiyet from hasta_kayıt where kullanıcı_adı='" + textBox1.Text + "'", baglanti);
            da.Fill(ds, "hasta_kayıt");
            dataGridView1.DataSource = ds.Tables["hasta_kayıt"];
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ds.Tables.Clear();
            dataGridView1.Refresh();
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter("Select Ad_soyad,Tc_no,Tel_no,Doğum_tarihi,Sosyal_güvencesi,Cinsiyet from hasta_kayıt where kullanıcı_adı='" + textBox1.Text + "'", baglanti);
            da.Fill(ds, "hasta_kayıt");
            dataGridView1.DataSource = ds.Tables["hasta_kayıt"];
            baglanti.Close();
        }
    }
}
