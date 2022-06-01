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

      

        private void ayarlar_Load(object sender, EventArgs e)
        {

        }
    }
}
