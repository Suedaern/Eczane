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
    public partial class ilcblg : Form
    {
        veritabanı veri = new veritabanı();
        public ilcblg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            veri.Yeni_ilac(ürüngrubutxt, üreticiFirmatxt, etkenmaddetxt, ATCkodutxt, reçetetipitxt, miktarıtxt, fiyatıtxt, alınanadettxt);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
