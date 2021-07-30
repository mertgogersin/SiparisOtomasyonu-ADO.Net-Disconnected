
namespace SiparisOtomasyonu
{
    partial class Form1
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
            this.btnCalisanGirisi = new System.Windows.Forms.Button();
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalisanGirisi
            // 
            this.btnCalisanGirisi.Location = new System.Drawing.Point(39, 29);
            this.btnCalisanGirisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalisanGirisi.Name = "btnCalisanGirisi";
            this.btnCalisanGirisi.Size = new System.Drawing.Size(393, 75);
            this.btnCalisanGirisi.TabIndex = 0;
            this.btnCalisanGirisi.Text = "Çalışan Girişi";
            this.btnCalisanGirisi.UseVisualStyleBackColor = true;
            this.btnCalisanGirisi.Click += new System.EventHandler(this.btnCalisanGirisi_Click);
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.Location = new System.Drawing.Point(39, 132);
            this.btnMusteriGirisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.Size = new System.Drawing.Size(393, 75);
            this.btnMusteriGirisi.TabIndex = 1;
            this.btnMusteriGirisi.Text = "Müşteri Girişi";
            this.btnMusteriGirisi.UseVisualStyleBackColor = true;
            this.btnMusteriGirisi.Click += new System.EventHandler(this.btnMusteriGirisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 255);
            this.Controls.Add(this.btnMusteriGirisi);
            this.Controls.Add(this.btnCalisanGirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalisanGirisi;
        private System.Windows.Forms.Button btnMusteriGirisi;
    }
}

