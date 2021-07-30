using SiparisOtomasyonu.Entities;
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
    public partial class FrmMainCustomer : Form
    {
        public FrmMainCustomer()
        {
            InitializeComponent();
        }

        public FrmMainCustomer(Customer _customer)
        {
            InitializeComponent();
            this.customer = _customer;
            categoryManagement = new CategoryManagement();
            productManagement = new ProductManagement();
            orderManagement = new OrderManagement();

        }
        Customer customer;
        CategoryManagement categoryManagement;
        ProductManagement productManagement;
        OrderManagement orderManagement;
        List<Product> products;
        private void FrmMainCustomer_Load(object sender, EventArgs e)
        {
            this.grpMusteriAdSoyad.Text = customer.CustomerName;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";
            cbCategories.DataSource = categoryManagement.GetCategories();
            cbCategories.SelectedIndex = -1;
            products = productManagement.GetProducts(Enums.FilterOrGet.Get);
            FillPanel(products);

        }

        private void FillPanel(List<Product> products)
        {
            flpProducts.Controls.Clear();
            foreach (Product item in products)
            {
                Panel panel = new Panel();
                Label productName = new Label();
                Label adet = new Label();
                Label fiyat = new Label();
                Label tutar = new Label();
                NumericUpDown nudQuantity = new NumericUpDown();
                Button btnSiparisVer = new Button();

                panel.Size = new Size(259, 168);
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.MediumTurquoise;
                panel.Controls.Add(productName);
                panel.Controls.Add(adet);
                panel.Controls.Add(fiyat);
                panel.Controls.Add(tutar);
                panel.Controls.Add(nudQuantity);
                panel.Controls.Add(btnSiparisVer);


                productName.Location = new Point(70, 0);
                productName.Text = item.ProductName;
                productName.AutoSize = false;
                productName.Size = new Size(143, 36);
                adet.Location = new Point(17, 47);
                adet.Text = "Adet : ";
                fiyat.Location = new Point(17, 91);
                fiyat.Text = "Fiyat : ";
                tutar.Location = new Point(125, 91);
                tutar.Text = item.UnitPrice.ToString() + "₺";
                nudQuantity.Location = new Point(123, 45);
                btnSiparisVer.Location = new Point(20, 113);
                btnSiparisVer.Text = "Sipariş Ver";
                btnSiparisVer.Size = new Size(223, 42);
                btnSiparisVer.BackColor = Color.White;
                btnSiparisVer.Click += BtnSiparisVer_Click;
                nudQuantity.ValueChanged += NudQuantity_ValueChanged;


                flpProducts.Controls.Add(panel);

                btnSiparisVer.Tag = item;
                nudQuantity.Tag = item;
                nudQuantity.Value = 1;
                nudQuantity.Minimum = 1;

            }
        }


        private void NudQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudQuantity = (NumericUpDown)sender;
            product = (Product)nudQuantity.Tag;
            foreach (Product item in products)
            {
                if (item.ProductID == product.ProductID)
                {
                    item.Quantity = Convert.ToInt32(nudQuantity.Value); // burada quantity'i doldurdum
                    break;
                }
            }
        }

        Product product;
        Product productToOrder; //asıl siparişe göndereceğim product
        private void BtnSiparisVer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            productToOrder = (Product)btn.Tag;
            foreach (Product item in products)
            {
                if (item.ProductID == productToOrder.ProductID && item.Quantity != 0)
                {
                    productToOrder = item;
                    break;
                }
            }
            Order order = new Order()
            {
                CustomerID = customer.CustomerID,
                OrderDate = DateTime.Now.ToString(),
                TotalPrice = product.Quantity * product.UnitPrice
            };
            orderManagement.InsertIntoOrders(order);
            orderManagement.InsertIntoOrderDetails(order, productToOrder);
            MessageBox.Show("Sipariş oluşturuldu.");

        }
        private void cbCategories_DropDownClosed(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(cbCategories.SelectedValue);
            products = productManagement.GetProducts(Enums.FilterOrGet.Filter, categoryID);
            FillPanel(products);
        }
    }
}
