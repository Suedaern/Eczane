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
    public partial class hstkyt : Form
    {
        public hstkyt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        veritabanı veri = new veritabanı();
        private void button2_Click(object sender, EventArgs e)
        {
            veri.Yeni_hasta(adsoyadtxt, tctxt, teltxt, doğumtarihitxt, sosyalgüvencetxt, cinsiyettxt);
           
        }
    }
}
