using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDGP_uygulama
{
    public partial class kayit_secenek : Form
    {
        public kayit_secenek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayit_yonetici a = new kayit_yonetici();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit_musteri x = new kayit_musteri();
            this.Hide();
            x.Show();
        }

        private void kayit_secenek_Load(object sender, EventArgs e)
        {

        }
    }
}
