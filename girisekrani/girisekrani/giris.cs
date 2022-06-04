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
    public partial class giris : Form
    {
        public static string kullanıcı = "";
        public giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader read;
        private void button1_Click()
        {
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
           System.Diagnostics.Process.Start("https://www.aeo.org.tr/");
           linkLabel1.LinkVisited = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifre sifre = new sifre();
            sifre.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı = kullanıcı_adıtxt.Text;
            string ad = kullanıcı_adıtxt.Text;
            string sifre = şifretxt.Text;


            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanıcı_kayıt where kullanıcı_adı='" + kullanıcı_adıtxt.Text + "' AND şifre='" + şifretxt.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read())
            {
                kullanıcı_adıtxt.Clear();
                şifretxt.Clear();
                anasayfa anasayfa = new anasayfa();
                anasayfa.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            baglanti.Close();
        }



        private void kullanıcı_adıtxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
