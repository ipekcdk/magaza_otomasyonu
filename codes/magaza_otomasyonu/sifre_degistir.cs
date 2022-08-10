using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTDGP_uygulama
{
    public partial class sifre_degistir : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";

        public int sonuc = 0;

        public sifre_degistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Captcha.Text == sonuc.ToString())
            {
                label_mesaj.Text = "";
                if (textBox_YeniSifre.Text == textBox_YeniSifreOnay.Text)
                {
                    eskiSifreKontrol();
                }
                else
                {
                    label_mesaj.Text = "Şifreler eşleşmiyor!";
                    CaptchaOlustur();
                }                                    
            }
            else
            {
                label_mesaj.Text = "Captcha hatalı girildi...";
                CaptchaOlustur();
            }
        }

        public void eskiSifreKontrol()
        {
            string sorgu = $"select * from uyeler where email = @user and sifre = @pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", login.kullanicimSession);
            cmd.Parameters.AddWithValue("@pass", veriTabani.MD5Sifrele(textBox_EskiSifre.Text));

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read()) 
            {
                string sql = $"update uyeler set sifre= '{veriTabani.MD5Sifrele(textBox_YeniSifre.Text)}' where email = '{login.kullanicimSession}'";
                veriTabani.KomutYolla(sql);
                string table = (login.yetki == "personel") ? "personel" : "musteri";
                sql = $"update tbl_{table} set sifre = '{veriTabani.MD5Sifrele(textBox_YeniSifre.Text)}' where email = '{login.kullanicimSession}'";
                veriTabani.KomutYolla(sql);
                MessageBox.Show("Şifre değiştirme işlemi başarılı...");
                label_mesaj.Text = "Şifreniz başarıyla değiştirildi.";
            }
            else
            {
                label_mesaj.Text = "Eski şifreniz hatalı...";
                CaptchaOlustur();
            }

            con.Close();
        }

        public void CaptchaOlustur()
        {
            Random r = new Random();
            int ilk = r.Next(0, 100);
            int ikinci = r.Next(0, 50);
            sonuc = ilk + ikinci;
            label_captcha.Text = ilk.ToString() + "+" + ikinci.ToString() + "=";
            textBox_Captcha.Clear();
        }

        private void SifreDeğistir_Load(object sender, EventArgs e)
        {
            label_mesaj.Text = "";
            CaptchaOlustur();            
        }
    }
}
