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
    public partial class uyeler_guncelleme : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";
        public static string durum = "";
        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from tbl_musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_musteri");

            dataGridView1.DataSource = ds.Tables["tbl_musteri"];
            con.Close();
        }

        public uyeler_guncelleme()
        {
            InitializeComponent();
        }

        private void UyelerGor_Load(object sender, EventArgs e)
        {
            veriTabani.GridTumunuDoldur(dataGridView1, "tbl_musteri");
            dataGridView1.Columns[0].HeaderText = "Müşteri No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Cep Telefonu";
            dataGridView1.Columns[5].HeaderText = "Şifre";
            dataGridView1.Columns[5].Visible = false;
            textBox1.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            islemler_yonetici x = new islemler_yonetici();
            this.Close();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit_musteri a = new kayit_musteri();
            a.Show();
            durum = "uyegor";

            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = $"delete from tbl_musteri where email='{textBox4.Text}'";
            veriTabani.KomutYolla(sql);
            sql = $"delete from uyeler where email = '{textBox4.Text}'";
            veriTabani.KomutYolla(sql);
            GridDoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sql = $"update tbl_musteri set musteri_Ad = '{textBox3.Text}' , musteri_Soyad = '{textBox2.Text}' , email = '{textBox4.Text}' , musteri_ceptel  = '{textBox5.Text}' , sifre = '{veriTabani.MD5Sifrele(textBox6.Text)}'";
            veriTabani.KomutYolla(sql);
            sql = $"update uyeler set email = '{textBox4.Text}' , ad = '{textBox3.Text}' , soyad = '{textBox2.Text}' , sifre = '{textBox6.Text}' , ceptel = '{textBox5.Text}' where email = '{textBox4.Text}'";
            veriTabani.KomutYolla(sql);
            GridDoldur();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }
    }
}
