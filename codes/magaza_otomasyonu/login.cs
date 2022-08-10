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
    public partial class login : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";

        public int denemeSayisi = 0;

        public static string kullanicimSession = "";
        public static string yetki = "";


        public login()
        {
            InitializeComponent();            
        }

        public void Login()
        {
            string sorgu = "select * from tbl_login where kullanici=@user and sifre=@pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", veriTabani.MD5Sifrele(textBox2.Text));

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş başarılı!");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (veriTabani.LoginKontrol(textBox1.Text, textBox2.Text))
            {

                string sorgu = $"select yetki from uyeler where email = '{textBox1.Text}' and yetki = 'personel'";

                con = new SqlConnection(login.SqlCon);
                cmd = new SqlCommand(sorgu, con);

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı!");
                    islemler_yonetici a = new islemler_yonetici();
                    kullanicimSession = textBox1.Text;
                    yetki = "personel";
                    a.Show();
                    this.Hide();
                    con.Close();
                    
                }
                else
                {
                    MessageBox.Show("Hoşgeldiniz!");
                    islemler_uye x = new islemler_uye();
                    kullanicimSession = textBox1.Text;
                    yetki = "musteri";
                    x.Show();
                    this.Hide();
                    con.Close();
                    
                }

                
            }
            else
            {
                denemeSayisi++;
                if (denemeSayisi == 3)
                {
                    MessageBox.Show("3 defa hatalı giriş yaptınız.");
                    Application.Exit();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayit_secenek x = new kayit_secenek();
            x.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
