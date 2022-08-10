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
    public partial class islemler_uye : Form
    {
        public islemler_uye()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd, cmd1;
        DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";
        string sqlSorgu;

        public int urun_id;

        void GridDoldur(string sql)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Islemler_Uye_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            GridDoldur("select * from magaza_urunlerr");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürünler";

            sqlSorgu = "select * from magaza_urunlerr";
            GridDoldur(sqlSorgu);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Seçiniz...")
            {
                MessageBox.Show("Lüften Adet Sayısı Giriniz");
                return;
            }
            cmd = new SqlCommand();
            string sql = "insert into tbl_islemler(islemTutar, islemTarih, islemBirim, email, uID) values (@tutar, @tarih, @birim, @email, @uid)";
            cmd.Parameters.AddWithValue("@tutar", Convert.ToDouble(label_tutar.Text));
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@birim", Convert.ToDouble(comboBox1.Text));
            cmd.Parameters.AddWithValue("@email", login.kullanicimSession);
            cmd.Parameters.AddWithValue("@uid", urun_id);
            veriTabani.KomutYollaParametreli(sql, cmd);

            MessageBox.Show("Satın alma gerçekleşti!");
            cmd1 = new SqlCommand();
            sql = "UPDATE magaza_urunlerr set urun_stok-=@adet where urun_id=@uid";
            cmd1.Parameters.AddWithValue("@adet", Convert.ToInt32(comboBox1.Text));
            cmd1.Parameters.AddWithValue("@uid", urun_id);
            veriTabani.KomutYollaParametreli(sql, cmd1);

            GridDoldur("select * from magaza_urunlerr");
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifre_degistir a = new sifre_degistir();
            a.Show();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {

            urun_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            label_urun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label_fiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label_stok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label_kategori.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label_beden.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                sqlSorgu = $"select * from magaza_urunlerr where urun_isim like '%{textBox1.Text}%' order by urun_isim asc";
                GridDoldur(sqlSorgu);
            }
        }

        private void geçmişSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gecmis a = new gecmis();
            a.Show();
            this.Hide();
        }

        private void hesapBilgilerimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hesabim x = new hesabim();
            x.Show();
        }

        private void faturaAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapor_goster a = new rapor_goster();
            a.ds=ds;
            this.Hide();
            a.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text!="Seçiniz...")
            label_tutar.Text = (Convert.ToDouble(comboBox1.Text) * Convert.ToDouble(label_fiyat.Text)).ToString();
        }
    }
}
