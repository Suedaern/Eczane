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
    public partial class sifre : Form
    {
        public sifre()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        OleDbCommand komut = new OleDbCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection=baglanti; 

            if (label3.Text == textBox3.Text)
            {
                komut.CommandText = "Update kullanıcı_kayıt set Şifre='" + maskedTextBox2.Text + "' where Kullanıcı_adı ='" + maskedTextBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Şifre Güncellendi");
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
                label3.Text = sayi1.ToString() + karakter1 + sayi2.ToString() + karakter2;

            }
        }

        private void sifre_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

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
            label3.Text = sayi1.ToString() + karakter1 + sayi2.ToString() + karakter2;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
