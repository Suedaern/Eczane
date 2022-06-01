using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girisekrani
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        veritabanı veri = new veritabanı();
        public static string kullanıcı = "";
        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı = kullanıcı_adıtxt.Text;
            veri.Kullanıcı(kullanıcı_adıtxt, şifretxt, veri.GetBaglanti());
            this.Hide();
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
    }
}
