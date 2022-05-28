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
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sifredgstr sifre= new sifredgstr();
            sifre.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullancblglr kullanıcı = new kullancblglr();
            kullanıcı.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder göster= new StringBuilder();
            göster.Append("https://www.google.com/search?tbs=lf:1,lf_ui:3&tbm=lcl&sxsrf=ALiCzsbN9KAolIY3_UBNprIPXWD_Kj3NXw:1653740598862&q=ankara+eczaneler+haritas%C4%B1&rflfq=1&num=10&ved=2ahUKEwiWiMjnl4L4AhUQQvEDHf_5ATkQtgN6BAgWEAY#rlfi=hd:");
            webBrowser1.Navigate(göster.ToString());
        }
    }
}
