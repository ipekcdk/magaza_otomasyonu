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
    public partial class urunler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from magaza_urunlerr", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "magaza_urunlerr");

            dataGridView1.DataSource = ds.Tables["magaza_urunlerr"];
            con.Close();
        }

        public urunler()
        {
            InitializeComponent();
            if (veriTabani.baglantiDurum())
            {
                MessageBox.Show("Veri tabanı bağlantısı kuruldu.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriTabani.GridTumunuDoldur(dataGridView1, "magaza_urunlerr");
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sql = "insert into magaza_urunlerr(urun_isim,urun_fiyat,urun_stok,urun_kategori,urun_beden) values (@urunisim, @fiyat, @stok, @kategori, @beden)";
            cmd.Parameters.AddWithValue("@urunisim", textBox1.Text);
            cmd.Parameters.AddWithValue("@fiyat", textBox3.Text);
            cmd.Parameters.AddWithValue("@stok", textBox2.Text);
            cmd.Parameters.AddWithValue("@kategori", textBox4.Text);
            cmd.Parameters.AddWithValue("@beden", textBox5.Text);

            veriTabani.KomutYollaParametreli(sql, cmd);


            GridDoldur();
        }

        public void EklemeSorgu(string sql)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = $"delete from magaza_urunlerr where urun_id={dataGridView1.CurrentRow.Cells[0].Value.ToString()}";
            veriTabani.KomutYolla(sql);
            GridDoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sql = $"update magaza_urunlerr set urun_isim = '{textBox1.Text}' , urun_fiyat = {textBox3.Text} , urun_stok = {textBox2.Text} , urun_kategori = '{textBox4.Text}' , urun_beden = '{textBox5.Text}' where urun_id={dataGridView1.CurrentRow.Cells[0].Value.ToString()}";
            
            veriTabani.KomutYolla(sql);
            GridDoldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            islemler_yonetici x = new islemler_yonetici();
            this.Close();
            x.Show();
        }
    }
}
