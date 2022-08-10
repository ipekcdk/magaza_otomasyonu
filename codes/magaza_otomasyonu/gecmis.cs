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
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from tbl_islemler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_islemler");

            dataGridView1.DataSource = ds.Tables["tbl_islemler"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islemler_uye a = new islemler_uye();
            this.Hide();
            a.Show();
        }

        private void gecmis_Load(object sender, EventArgs e)
        {
            GridDoldur();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
