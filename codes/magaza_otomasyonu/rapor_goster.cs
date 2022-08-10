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
    public partial class rapor_goster : Form
    {
        public rapor_goster()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        public DataSet ds;
        public static string SqlCon = @"Data Source=.;Initial Catalog=mydb;Integrated Security=True";

        public void raporDoldur(string sql)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds);
            siparis_rapor1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = siparis_rapor1;
            con.Close();
        }

        private void rapor_goster_Load(object sender, EventArgs e)
        {
            raporDoldur($"select * from tbl_islemler where email = '{login.kullanicimSession}'");
        }
    }
}
