using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace girisekrani
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into kullanıcı_kayıt (Ad,Soyad,E_posta,Kullanıcı_adı,Şifre) values('" + adtxt.Text.ToString() + "', '" + soyadtxt.Text.ToString() + "', '" + e_postatxt.Text.ToString() + "', '" + kullanıcı_adıtxt.Text.ToString() + "', '" + şifretxt.Text.ToString() + "')", baglanti);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Girmiş olduğunuz kullanıcı adı kullanılmakta.");
                }
            }

            baglanti.Close();
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
