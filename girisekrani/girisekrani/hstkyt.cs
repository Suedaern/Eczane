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
    public partial class hstkyt : Form
    {
        public hstkyt()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into hasta_kayıt (Kullanıcı_adı,Ad_soyad,Tc_no,Tel_no,Doğum_tarihi,Sosyal_güvencesi,Cinsiyet) values('" + textBox1.Text.ToString() + "', '" + adsoyadtxt.Text.ToString() + "', '" + tctxt.Text.ToString() + "', '" + teltxt.Text.ToString() + "', '" + doğumtarihitxt.Text.ToString() + "', '" + sosyalgüvencetxt.Text.ToString() +"', '" + cinsiyettxt.Text.ToString() + "')", baglanti);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Girmiş olduğunuz hasta zaten kayıtlı.");
                }
            }
            baglanti.Close();
        }

        private void hstkyt_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.kullanıcı.ToString();
        }
    }
}
