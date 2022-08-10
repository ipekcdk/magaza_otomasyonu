
namespace VTDGP_uygulama
{
    partial class islemler_uye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_tutar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_fiyat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_urun = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_beden = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_kategori = new System.Windows.Forms.Label();
            this.label_stok = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapBilgilerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 699);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_tutar);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_fiyat);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(778, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 268);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satın Alma İşlemleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(31, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Satın Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Işlem Tutar:";
            // 
            // label_tutar
            // 
            this.label_tutar.AutoSize = true;
            this.label_tutar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tutar.Location = new System.Drawing.Point(206, 141);
            this.label_tutar.Name = "label_tutar";
            this.label_tutar.Size = new System.Drawing.Size(116, 23);
            this.label_tutar.TabIndex = 8;
            this.label_tutar.Text = "label_tutar";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz...",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(210, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birim Fiyat:";
            // 
            // label_fiyat
            // 
            this.label_fiyat.AutoSize = true;
            this.label_fiyat.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fiyat.Location = new System.Drawing.Point(211, 39);
            this.label_fiyat.Name = "label_fiyat";
            this.label_fiyat.Size = new System.Drawing.Size(111, 23);
            this.label_fiyat.TabIndex = 12;
            this.label_fiyat.Text = "label_fiyat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_urun);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_beden);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_kategori);
            this.groupBox1.Controls.Add(this.label_stok);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(809, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 235);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stok:";
            // 
            // label_urun
            // 
            this.label_urun.AutoSize = true;
            this.label_urun.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_urun.Location = new System.Drawing.Point(163, 45);
            this.label_urun.Name = "label_urun";
            this.label_urun.Size = new System.Drawing.Size(138, 23);
            this.label_urun.TabIndex = 7;
            this.label_urun.Text = "Ürün seçiniz.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Beden:";
            // 
            // label_beden
            // 
            this.label_beden.AutoSize = true;
            this.label_beden.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_beden.Location = new System.Drawing.Point(163, 138);
            this.label_beden.Name = "label_beden";
            this.label_beden.Size = new System.Drawing.Size(128, 23);
            this.label_beden.TabIndex = 14;
            this.label_beden.Text = "label_beden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kategori:";
            // 
            // label_kategori
            // 
            this.label_kategori.AutoSize = true;
            this.label_kategori.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kategori.Location = new System.Drawing.Point(163, 91);
            this.label_kategori.Name = "label_kategori";
            this.label_kategori.Size = new System.Drawing.Size(147, 23);
            this.label_kategori.TabIndex = 15;
            this.label_kategori.Text = "label_kategori";
            // 
            // label_stok
            // 
            this.label_stok.AutoSize = true;
            this.label_stok.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stok.Location = new System.Drawing.Point(165, 184);
            this.label_stok.Name = "label_stok";
            this.label_stok.Size = new System.Drawing.Size(109, 23);
            this.label_stok.TabIndex = 16;
            this.label_stok.Text = "label_stok";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 597);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 103);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Ara";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(379, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapBilgilerimToolStripMenuItem,
            this.geçmişSiparişlerToolStripMenuItem,
            this.faturaAlToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapBilgilerimToolStripMenuItem
            // 
            this.hesapBilgilerimToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.hesapBilgilerimToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesapBilgilerimToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hesapBilgilerimToolStripMenuItem.Name = "hesapBilgilerimToolStripMenuItem";
            this.hesapBilgilerimToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.hesapBilgilerimToolStripMenuItem.Text = "Hesap Bilgilerim";
            this.hesapBilgilerimToolStripMenuItem.Click += new System.EventHandler(this.hesapBilgilerimToolStripMenuItem_Click_1);
            // 
            // geçmişSiparişlerToolStripMenuItem
            // 
            this.geçmişSiparişlerToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.geçmişSiparişlerToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geçmişSiparişlerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.geçmişSiparişlerToolStripMenuItem.Name = "geçmişSiparişlerToolStripMenuItem";
            this.geçmişSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(210, 27);
            this.geçmişSiparişlerToolStripMenuItem.Text = "Geçmiş Siparislerim";
            this.geçmişSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.geçmişSiparişlerToolStripMenuItem_Click);
            // 
            // faturaAlToolStripMenuItem
            // 
            this.faturaAlToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.faturaAlToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faturaAlToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.faturaAlToolStripMenuItem.Name = "faturaAlToolStripMenuItem";
            this.faturaAlToolStripMenuItem.Size = new System.Drawing.Size(158, 27);
            this.faturaAlToolStripMenuItem.Text = "Fatura Yazdır";
            this.faturaAlToolStripMenuItem.Click += new System.EventHandler(this.faturaAlToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDeğiştirToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.işlemlerToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.işlemlerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.işlemlerToolStripMenuItem.Text = "Ayarlar";
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.şifreDeğiştirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.BackColor = System.Drawing.Color.Peru;
            this.çıkışToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // islemler_uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "islemler_uye";
            this.Text = "Üye İşlemleri";
            this.Load += new System.EventHandler(this.Islemler_Uye_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_urun;
        private System.Windows.Forms.Label label_tutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_fiyat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem geçmişSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapBilgilerimToolStripMenuItem;
        private System.Windows.Forms.Label label_beden;
        private System.Windows.Forms.Label label_kategori;
        private System.Windows.Forms.Label label_stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem faturaAlToolStripMenuItem;
    }
}