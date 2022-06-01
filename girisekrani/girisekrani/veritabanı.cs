using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace girisekrani
{
    internal class veritabanı
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Desktop\\eczane.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut;
        public SqlDataReader read;
        public anasayfa main = new anasayfa();
        public SqlConnection GetBaglanti()
        {
            return baglanti;
        }

        public SqlDataReader Kullanıcı(TextBox kullanıcı_adı, MaskedTextBox Şifre, SqlConnection baglanti)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from kullanıcı_kayıt where Kullanıcı_adı='" + kullanıcı_adı.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (Şifre.Text == read["Şifre"].ToString())
                {
                    MessageBox.Show("Giriş başarılı");
                    anasayfa anasayfa = new anasayfa();
                    anasayfa.Show();
                    

                }
                else
                {
                    MessageBox.Show("Şifre yanlış girildi", "hata1");
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı", "hata2");
            }
            baglanti.Close();
            return read;
        }

        public void Yeni_kullanıcı(TextBox ad, TextBox soyad, TextBox e_posta, TextBox kullanıcı_adı, MaskedTextBox şifre)
        {

            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into kullanıcı_kayıt values('"+ad.Text+"','"+soyad.Text+"','"+e_posta.Text+"','"+kullanıcı_adı.Text+"','"+şifre.Text+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Tamamlandı");
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }
        public void Yeni_hasta(TextBox adsoyad, TextBox tc, MaskedTextBox tel, MaskedTextBox doğumtarihi, ComboBox sosyalgüvence, ComboBox cinsiyet)
        {
            string kontrol=giris.kullanıcı;
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into hasta_kayıt values('"+kontrol+"','" + adsoyad.Text + "','" + tc.Text + "','" + tel.Text + "','" + doğumtarihi.Text + "','" + sosyalgüvence.Text + "','"+cinsiyet.Text+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Tamamlandı");
            
        }
        public void Yeni_ilac(ComboBox ürüngrubu, TextBox üreticifirma, TextBox etkenmadde, ComboBox ATCkodu, ComboBox reçetetipi, TextBox miktarı, TextBox fiyatı, TextBox alınanadet )
        {
            string kontrol = giris.kullanıcı;
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into ilac_bilgi values('" + kontrol + "','" + ürüngrubu.Text + "','" + üreticifirma.Text + "','" + etkenmadde.Text + "','" + ATCkodu.Text + "','" + reçetetipi.Text + "','" + miktarı.Text + "','"+fiyatı.Text+"', '"+alınanadet.Text+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Tamamlandı");
            
        }
    }
}
