//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.OleDb;


//namespace girisekrani
//{
//    internal class database
//    {
//        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\DELL\\Desktop\\eczane.accdb");
//        OleDbCommand komut = new OleDbCommand();
//        OleDbDataReader read;


        
//        public void giriş(TextBox kullanıcı_adı, MaskedTextBox Şifre)
//        {
//            giris giris = new giris();
//            string ad = giris.kullanıcı_adıtxt.Text;
//            string sifre = giris.şifretxt.Text;


//            baglanti.Open();
//            komut.Connection = baglanti;
//            komut.CommandText = "SELECT * FROM kullanıcı_kayıt where kullanıcı_adı='" + kullanıcı_adı.Text + "' AND şifre='" + Şifre.Text + "'";
//            read = komut.ExecuteReader();
//            if (read.Read())
//            {
                
//                anasayfa anasayfa = new anasayfa();
//                anasayfa.ShowDialog();
                
//            }
//            else
//            {
//                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
//            }

//            baglanti.Close();
//        }


       
//    }
//}
