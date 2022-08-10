
namespace VTDGP_uygulama
{
    partial class rapor_goster
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.siparis_rapor1 = new VTDGP_uygulama.siparis_rapor();
            this.mydbDataSet11 = new VTDGP_uygulama.mydbDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.siparis_rapor1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1013, 674);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // mydbDataSet11
            // 
            this.mydbDataSet11.DataSetName = "mydbDataSet1";
            this.mydbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapor_goster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 674);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "rapor_goster";
            this.Text = "rapor_goster";
            this.Load += new System.EventHandler(this.rapor_goster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private siparis_rapor siparis_rapor1;
        private mydbDataSet1 mydbDataSet11;
    }
}