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
    public partial class islemler_yonetici : Form
    {
        public islemler_yonetici()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd, cmd1;
        DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";

        public int urunID;
        public string sqlSorgu;

        void GridDoldur(string sql)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "magaza_urunlerr");

            dataGridView1.DataSource = ds.Tables["magaza_urunlerr"];
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton1.Checked)  
                {
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_isim like '%" + textBox1.Text + "%' order by urun_isim ASC";   
                        GridDoldur(sqlSorgu);
                    }
                    else
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_isim like '%" + textBox1.Text + "%' order by urun_isim DESC";
                        GridDoldur(sqlSorgu);
                    }
                }    
            }
            else
            {
                sqlSorgu = "select * from magaza_urunlerr";
                GridDoldur(sqlSorgu);
            }
        }

        private void Islemler_Yonetici_Load(object sender, EventArgs e)
        {
            veriTabani.GridTumunuDoldur(dataGridView1,"magaza_urunlerr");
            maskedTextBox1.Visible = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ürün İsmi";
            dataGridView1.Columns[2].HeaderText = "Fiyat";
            dataGridView1.Columns[3].HeaderText = "Stok";
            dataGridView1.Columns[4].HeaderText = "Kategori";
            dataGridView1.Columns[5].HeaderText = "Beden";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = true;
            textBox1.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = true;
            textBox1.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            textBox1.Visible = true;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {

                if (radioButton2.Checked)  
                {
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = $"select * from magaza_urunlerr where urun_stok > {maskedTextBox1.Text} order by urun_stok asc";
                        GridDoldur(sqlSorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sqlSorgu = $"select * from magaza_urunlerr where urun_stok > {maskedTextBox1.Text} order by urun_stok desc";
                        GridDoldur(sqlSorgu);
                    }
                }

                else if (radioButton4.Checked) 
                {
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_fiyat between " + maskedTextBox1.Text + "*0.9 AND " + maskedTextBox1.Text + "*1.1 order by urun_fiyat ASC";
                        GridDoldur(sqlSorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_fiyat between " + maskedTextBox1.Text + "*0.9 AND " + maskedTextBox1.Text + "*1.1 order by urun_fiyat DESC";
                        GridDoldur(sqlSorgu);
                    }
                }
            }
            else
            {
                sqlSorgu = "select * from magaza_urunlerr";
                GridDoldur(sqlSorgu);
            }
        }

        private void islemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunler f = new urunler();
            this.Hide();
            f.Show();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifre_degistir a = new sifre_degistir();
            a.ShowDialog();
        }

        private void müşterileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uyeler_guncelleme a = new uyeler_guncelleme();
            a.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton1.Checked)  
                {
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_isim like '%" + textBox1.Text + "%' order by urun_isim ASC";   //birden fazla karaktere bakacağımız zaman
                        GridDoldur(sqlSorgu);
                    }
                    else
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_isim like '%" + textBox1.Text + "%' order by urun_isim DESC";
                        GridDoldur(sqlSorgu);
                    }
                }

                else if (radioButton2.Checked)  
                {
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = $"select * from magaza_urunlerr where urun_stok > {maskedTextBox1.Text} order by urun_stok asc";
                        GridDoldur(sqlSorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sqlSorgu = $"select * from magaza_urunlerr where urun_stok > {maskedTextBox1.Text} order by urun_stok desc";
                        GridDoldur(sqlSorgu);
                    }
                }

                else if (radioButton4.Checked) 
                {
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_fiyat between " + maskedTextBox1.Text + "*0.9 AND " + maskedTextBox1.Text + "*1.1 order by urun_iyat ASC";
                        GridDoldur(sqlSorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sqlSorgu = "select * from magaza_urunlerr where urun_fiyat between " + maskedTextBox1.Text + "*0.9 AND " + maskedTextBox1.Text + "*1.1 order by urun_fiyat DESC";
                        GridDoldur(sqlSorgu);
                    }
                }
            }
            else
            {
                sqlSorgu = "select * from magaza_urunlerr";
                GridDoldur(sqlSorgu);
            }
        }
    }
}   
