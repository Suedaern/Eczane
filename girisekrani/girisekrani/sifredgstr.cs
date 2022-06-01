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
    public partial class sifredgstr : Form
    {
        public sifredgstr()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("Şifre güncellendi");
                ayarlar ayarlar = new ayarlar();
                ayarlar.Show();
                this.Hide();
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
    }
}
