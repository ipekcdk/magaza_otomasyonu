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
    public partial class kayit_yonetici : Form
    {
        public kayit_yonetici()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || maskedTextBox1.Text == "(   )    -")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz...");
                return;
            }

            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Parolalar uyuşmuyor.");
                return;
            }
            if (textBox5.Text.Length < 8) { MessageBox.Show("En az 8 karakterli bir şifre belirleyiniz!"); return; }

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=mydb;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string sorgu = $"select * from uyeler where email = '{textBox3.Text}'";
            cmd = new SqlCommand(sorgu, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Bu email adresine ait hesap bulunmaktadır.");
                con.Close();
                return;
            }

            con.Close();

            sorgu = $"Insert into tbl_personel(personel_Ad,personel_Soyad,email,personel_ceptel,sifre) values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{maskedTextBox1.Text}','{veriTabani.MD5Sifrele(textBox5.Text)}')";
            veriTabani.KomutYolla(sorgu);
            sorgu = $"Insert into uyeler(email,ad,soyad,ceptel,sifre,yetki) values('{textBox3.Text}','{textBox1.Text}','{textBox2.Text}','{maskedTextBox1.Text}','{veriTabani.MD5Sifrele(textBox5.Text)}','personel')";
            veriTabani.KomutYolla(sorgu);
            MessageBox.Show("Kayıt olma işlemi başarılı !");
            login a = new login();
            a.Show();
            this.Close();
        }

        private void kayit_yonetici_Load(object sender, EventArgs e)
        {

        }
    }
}
