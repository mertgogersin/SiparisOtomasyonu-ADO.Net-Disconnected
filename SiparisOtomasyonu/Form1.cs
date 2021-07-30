using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalisanGirisi_Click(object sender, EventArgs e)
        {            
            FrmLogin frmLoginCalisan = new FrmLogin(GirisTipi.Employee);
            this.Hide();
            frmLoginCalisan.ShowDialog();
            this.Show();
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            FrmLogin frmLoginMusteri = new FrmLogin(GirisTipi.Customer);
            this.Hide();
            frmLoginMusteri.ShowDialog();
            this.Show();
        }
    }
}
