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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Başarılı");
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
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
    }
}
