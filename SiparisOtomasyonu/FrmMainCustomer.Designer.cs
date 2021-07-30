
namespace SiparisOtomasyonu
{
    partial class FrmMainCustomer
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
            this.grpMusteriAdSoyad = new System.Windows.Forms.GroupBox();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMusteriAdSoyad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMusteriAdSoyad
            // 
            this.grpMusteriAdSoyad.Controls.Add(this.flpProducts);
            this.grpMusteriAdSoyad.Controls.Add(this.cbCategories);
            this.grpMusteriAdSoyad.Controls.Add(this.label1);
            this.grpMusteriAdSoyad.Location = new System.Drawing.Point(13, 13);
            this.grpMusteriAdSoyad.Name = "grpMusteriAdSoyad";
            this.grpMusteriAdSoyad.Size = new System.Drawing.Size(826, 782);
            this.grpMusteriAdSoyad.TabIndex = 0;
            this.grpMusteriAdSoyad.TabStop = false;
            this.grpMusteriAdSoyad.Text = "groupBox1";
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Location = new System.Drawing.Point(6, 61);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(802, 715);
            this.flpProducts.TabIndex = 2;
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(205, 29);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(231, 26);
            this.cbCategories.TabIndex = 1;
            this.cbCategories.DropDownClosed += new System.EventHandler(this.cbCategories_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoriler : ";
            // 
            // FrmMainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 807);
            this.Controls.Add(this.grpMusteriAdSoyad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainCustomer";
            this.Text = "FrmMainCustomer";
            this.Load += new System.EventHandler(this.FrmMainCustomer_Load);
            this.grpMusteriAdSoyad.ResumeLayout(false);
            this.grpMusteriAdSoyad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteriAdSoyad;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
    }
}