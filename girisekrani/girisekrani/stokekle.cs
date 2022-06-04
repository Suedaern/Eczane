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
    public partial class stokekle : Form
    {
        public stokekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stok stok = new stok();
            stok.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ekleme tamamlandı");
        }

        private void stokekle_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.kullanıcı.ToString();
        }
    }
}
