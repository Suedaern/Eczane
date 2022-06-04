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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            ayarlar ayarlar= new ayarlar();
            ayarlar.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into personel_kayıt (Kullanıcı_adı,Ad_soyad,Tc_no,Doğum_tarihi,Tel_no,E_mail,Adresi,Diploma,Bölümü,İşe_giriş_tarihi) values('" + textBox3.Text.ToString() + "', '" + ad_soyadtxt.Text.ToString() + "', '" + tc_notxt.Text.ToString() + "', '" + doğum_tarihitxt.Text.ToString() + "', '" + tel_notxt.Text.ToString() + "', '" + e_mailtxt.Text.ToString() + "', '" + adresitxt.Text.ToString() + "', '" + diplomatxt.Text.ToString() + "', '" + bölümtxt.Text.ToString() + "', '" + işe_giriştxt.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel kaydedildi");
           
        }

        private void personel_Load(object sender, EventArgs e)
        {
            textBox3.Text = giris.kullanıcı.ToString();
        }
    }
}
