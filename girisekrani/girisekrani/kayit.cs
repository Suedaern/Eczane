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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }

        veritabanı veri = new veritabanı();
        private void button1_Click(object sender, EventArgs e)
        {

            veri.Yeni_kullanıcı(adtxt, soyadtxt, e_postatxt, kullanıcı_adıtxt, şifretxt);
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.aeo.org.tr/");
            linkLabel1.LinkVisited = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
