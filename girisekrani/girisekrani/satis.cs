﻿using System;
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
    public partial class satis : Form
    {
        public satis()
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
            MessageBox.Show("Satış Tamamlandı");
            //stoktan alınan adet kadar ilaçları düşecek 
        }

        private void satis_Load(object sender, EventArgs e)
        {
            textBox3.Text = giris.kullanıcı.ToString();
        }
    }
}
