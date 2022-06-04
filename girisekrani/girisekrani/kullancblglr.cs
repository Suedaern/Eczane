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
    public partial class kullancblglr : Form
    {
        public kullancblglr()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        OleDbCommand komut = new OleDbCommand();
       

        private void button1_Click(object sender, EventArgs e)
        {
            ayarlar ayarlar = new ayarlar();
            ayarlar.Show();
            this.Hide();
        }

        private void kullancblglr_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.kullanıcı.ToString();
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From kullanıcı_kayıt where kullanıcı_adı='" + textBox1.Text + "'", baglanti);
            da.Fill(ds, "kullanıcı_kayıt");
            dataGridView1.DataSource = ds.Tables["kullanıcı_kayıt"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
