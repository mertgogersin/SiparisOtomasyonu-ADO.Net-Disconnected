using SiparisOtomasyonu.LoginInfos;
using SiparisOtomasyonu.Products;
using SiparisOtomasyonu.Repos;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public FrmLogin(GirisTipi _girisTipi)
        {
            InitializeComponent();
            this.girisTipi = _girisTipi;
            employeeLoginManagement = new EmployeeLoginManagement();
            customerLoginManagement = new CustomerLoginManagement();
        }
        GirisTipi girisTipi;
        EmployeeLoginManagement employeeLoginManagement;
        CustomerLoginManagement customerLoginManagement;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (girisTipi == GirisTipi.Employee)
            {
                lblKullaniciGirisi.Text = "Kullanıcı Adı : ";
                btnGiris.Text = "Çalışan Girişi";
                grpLoginMonitor.Text = "Çalışan Giriş Ekranı";
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            try
            {
                if (girisTipi == GirisTipi.Employee)
                {
                    Employee employeeLogin = employeeLoginManagement.GetEmployeeLogin(txtKullaniciAdi.Text, txtSifre.Text);
                    FrmMainEmployee frmMainEmployee = new FrmMainEmployee(employeeLogin);
                    this.Hide();
                    frmMainEmployee.ShowDialog();
                    this.Show();


                }
                else if(girisTipi == GirisTipi.Customer)
                {
                    Customer customerLogin = customerLoginManagement.GetCustomerLogin(txtKullaniciAdi.Text, txtSifre.Text);

                    FrmMainCustomer frmMainCustomer = new FrmMainCustomer(customerLogin);
                    this.Hide();
                    frmMainCustomer.ShowDialog();
                    this.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
