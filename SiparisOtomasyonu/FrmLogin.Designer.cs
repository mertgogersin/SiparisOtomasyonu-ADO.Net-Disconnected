
namespace SiparisOtomasyonu
{
    partial class FrmLogin
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
            this.grpLoginMonitor = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciGirisi = new System.Windows.Forms.Label();
            this.grpLoginMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoginMonitor
            // 
            this.grpLoginMonitor.Controls.Add(this.btnGiris);
            this.grpLoginMonitor.Controls.Add(this.txtSifre);
            this.grpLoginMonitor.Controls.Add(this.txtKullaniciAdi);
            this.grpLoginMonitor.Controls.Add(this.lblSifre);
            this.grpLoginMonitor.Controls.Add(this.lblKullaniciGirisi);
            this.grpLoginMonitor.Location = new System.Drawing.Point(13, 13);
            this.grpLoginMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.grpLoginMonitor.Name = "grpLoginMonitor";
            this.grpLoginMonitor.Padding = new System.Windows.Forms.Padding(4);
            this.grpLoginMonitor.Size = new System.Drawing.Size(376, 239);
            this.grpLoginMonitor.TabIndex = 1;
            this.grpLoginMonitor.TabStop = false;
            this.grpLoginMonitor.Text = "Müşteri Giriş Ekranı";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(43, 160);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(289, 44);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Müşteri Girişi";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(129, 110);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(203, 24);
            this.txtSifre.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(128, 52);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(204, 24);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(72, 113);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(50, 18);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre : ";
            // 
            // lblKullaniciGirisi
            // 
            this.lblKullaniciGirisi.AutoSize = true;
            this.lblKullaniciGirisi.Location = new System.Drawing.Point(24, 55);
            this.lblKullaniciGirisi.Name = "lblKullaniciGirisi";
            this.lblKullaniciGirisi.Size = new System.Drawing.Size(82, 18);
            this.lblKullaniciGirisi.TabIndex = 0;
            this.lblKullaniciGirisi.Text = "Şirket Adı : ";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.grpLoginMonitor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.grpLoginMonitor.ResumeLayout(false);
            this.grpLoginMonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginMonitor;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciGirisi;
    }
}