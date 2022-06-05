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
    public partial class sifredgstr : Form
    {
        public sifredgstr()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader read;
        private void button1_Click(object sender, EventArgs e)
        {
            ayarlar ayarlar = new ayarlar();
            ayarlar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          if(label4.Text == textBox1.Text)
          {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM kullanıcı_kayıt where kullanıcı_adı='" + textBox2.Text + "' AND şifre='" + maskedTextBox1.Text + "'";
                read = komut.ExecuteReader();
              
                if (read.Read())
                {
                    read.Close();
                    if (maskedTextBox2.Text==maskedTextBox3.Text)
                    {
                      
                        komut.CommandText = "update kullanıcı_kayıt set Şifre='" + maskedTextBox2.Text + "' where  Kullanıcı_adı='" + textBox2.Text + "'";
                        komut.ExecuteNonQuery();
                      
                        MessageBox.Show("Şifre güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("yeni şifre, yeni şifre tekrara eşit değil.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen eski şifre yanlış");
                }
                
                baglanti.Close();
            }

            else
            {
                MessageBox.Show("Kod hatalı");
                Random rastgele = new Random();
                int sayi1, sayi2;
                int harfdegeri1, harfdegeri2;
                char karakter1, karakter2;
                sayi1 = rastgele.Next(1, 9);
                sayi2 = rastgele.Next(1, 9);
                harfdegeri1 = rastgele.Next(65, 91);
                harfdegeri2 = rastgele.Next(65, 91);
                karakter1 = Convert.ToChar(harfdegeri1);
                karakter2 = Convert.ToChar(harfdegeri2);
                label4.Text = sayi1.ToString() + karakter1 + sayi2.ToString() + karakter2;
            }

          
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Random rastgele = new Random();
            int sayi1, sayi2;
            int harfdegeri1, harfdegeri2;
            char karakter1, karakter2;
            sayi1 = rastgele.Next(1, 9);
            sayi2 = rastgele.Next(1, 9);
            harfdegeri1 = rastgele.Next(65, 91);
            harfdegeri2 = rastgele.Next(65, 91);
            karakter1 = Convert.ToChar(harfdegeri1);
            karakter2 = Convert.ToChar(harfdegeri2);
            label4.Text = sayi1.ToString() + karakter1 + sayi2.ToString() + karakter2;

        }

        private void sifredgstr_Load(object sender, EventArgs e)
        {
            textBox2.Text = giris.kullanıcı.ToString();
        }
    }
}
