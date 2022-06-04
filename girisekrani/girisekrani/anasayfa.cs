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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)


        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hstkyt hstkyt = new hstkyt();
            hstkyt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hstblg hstblg = new hstblg();  
            hstblg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ilcblg ilcblg = new ilcblg();
            ilcblg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stok stok = new stok();
            stok.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ayarlar ayarlar = new ayarlar();
            ayarlar.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            satis satis = new satis();
            satis.Show();
            this.Hide();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.kullanıcı.ToString();

        }
    }
}
