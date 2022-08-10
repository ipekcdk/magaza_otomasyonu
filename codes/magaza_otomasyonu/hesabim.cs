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
    public partial class hesabim : Form
    {
        public hesabim()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd, cmd1;
        DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter($"select * from tbl_musteri where email = '{login.kullanicimSession}'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_musteri");

            dataGridView1.DataSource = ds.Tables["tbl_musteri"];
            con.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void Hesabım_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            GridDoldur();
        }
    }
}
