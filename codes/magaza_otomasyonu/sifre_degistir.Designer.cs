
namespace VTDGP_uygulama
{
    partial class sifre_degistir
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
            this.textBox_EskiSifre = new System.Windows.Forms.TextBox();
            this.textBox_YeniSifre = new System.Windows.Forms.TextBox();
            this.textBox_YeniSifreOnay = new System.Windows.Forms.TextBox();
            this.textBox_Captcha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_mesaj = new System.Windows.Forms.Label();
            this.label_captcha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_EskiSifre
            // 
            this.textBox_EskiSifre.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EskiSifre.Location = new System.Drawing.Point(259, 62);
            this.textBox_EskiSifre.Name = "textBox_EskiSifre";
            this.textBox_EskiSifre.Size = new System.Drawing.Size(188, 28);
            this.textBox_EskiSifre.TabIndex = 0;
            // 
            // textBox_YeniSifre
            // 
            this.textBox_YeniSifre.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_YeniSifre.Location = new System.Drawing.Point(259, 116);
            this.textBox_YeniSifre.Name = "textBox_YeniSifre";
            this.textBox_YeniSifre.Size = new System.Drawing.Size(188, 28);
            this.textBox_YeniSifre.TabIndex = 1;
            // 
            // textBox_YeniSifreOnay
            // 
            this.textBox_YeniSifreOnay.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_YeniSifreOnay.Location = new System.Drawing.Point(259, 171);
            this.textBox_YeniSifreOnay.Name = "textBox_YeniSifreOnay";
            this.textBox_YeniSifreOnay.Size = new System.Drawing.Size(188, 28);
            this.textBox_YeniSifreOnay.TabIndex = 2;
            // 
            // textBox_Captcha
            // 
            this.textBox_Captcha.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Captcha.Location = new System.Drawing.Point(259, 228);
            this.textBox_Captcha.Name = "textBox_Captcha";
            this.textBox_Captcha.Size = new System.Drawing.Size(109, 28);
            this.textBox_Captcha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre (Tekrar):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_mesaj
            // 
            this.label_mesaj.AutoSize = true;
            this.label_mesaj.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mesaj.Location = new System.Drawing.Point(50, 433);
            this.label_mesaj.Name = "label_mesaj";
            this.label_mesaj.Size = new System.Drawing.Size(59, 20);
            this.label_mesaj.TabIndex = 8;
            this.label_mesaj.Text = "label4";
            // 
            // label_captcha
            // 
            this.label_captcha.AutoSize = true;
            this.label_captcha.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_captcha.Location = new System.Drawing.Point(50, 231);
            this.label_captcha.Name = "label_captcha";
            this.label_captcha.Size = new System.Drawing.Size(122, 20);
            this.label_captcha.TabIndex = 9;
            this.label_captcha.Text = "label_captcha";
            // 
            // sifre_degistir
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(497, 479);
            this.Controls.Add(this.label_captcha);
            this.Controls.Add(this.label_mesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Captcha);
            this.Controls.Add(this.textBox_YeniSifreOnay);
            this.Controls.Add(this.textBox_YeniSifre);
            this.Controls.Add(this.textBox_EskiSifre);
            this.Name = "sifre_degistir";
            this.Text = "Şifre Değiştirme";
            this.Load += new System.EventHandler(this.SifreDeğistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_EskiSifre;
        private System.Windows.Forms.TextBox textBox_YeniSifre;
        private System.Windows.Forms.TextBox textBox_YeniSifreOnay;
        private System.Windows.Forms.TextBox textBox_Captcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_mesaj;
        private System.Windows.Forms.Label label_captcha;
    }
}