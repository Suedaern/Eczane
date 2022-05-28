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
    public partial class stok : Form
    {
        public stok()
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
            //veritabanından girilen ilacı bulu ekranda gösterecek
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokekle stokekle = new stokekle();
            stokekle.Show();
            this.Hide();
        }
    }
}
