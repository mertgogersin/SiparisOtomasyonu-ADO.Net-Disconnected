using SiparisOtomasyonu.Entities;
using SiparisOtomasyonu.LoginInfos;
using SiparisOtomasyonu.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class FrmMainEmployee : Form
    {
        public FrmMainEmployee()
        {
            InitializeComponent();
        }

        public FrmMainEmployee(Employee _employee)
        {
            InitializeComponent();
            this.employee = _employee;
            orderDetailManagement = new OrderDetailManagement();
            orderManagement = new OrderManagement();
        }
        Employee employee;
        OrderDetailManagement orderDetailManagement;
        OrderManagement orderManagement;
        List<OrderDetail> orderDetails;
        private void FrmMainEmployee_Load(object sender, EventArgs e)
        {
            orderDetails = orderDetailManagement.GetWaitingOrder();
            FillList();

        }

        private void lstWaitinOrders_DoubleClick(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(lstWaitingOrders.SelectedItems[0].Tag);
       
            orderManagement.UpdateWaitingOrder(orderID, employee.Id);

            MessageBox.Show("Sipariş onaylandı.");
            lstWaitingOrders.SelectedItems[0].Remove();
        }

        private void FillList()
        {
            int i = 0;
            foreach (OrderDetail item in orderDetails)
            {
                lstWaitingOrders.Items.Add(item.CustomerID);
                lstWaitingOrders.Items[i].SubItems.Add(item.CompanyName);
                lstWaitingOrders.Items[i].SubItems.Add(item.ContactTitle);
                lstWaitingOrders.Items[i].SubItems.Add(item.OrderDate);
                lstWaitingOrders.Items[i].SubItems.Add(item.ProductName);
                lstWaitingOrders.Items[i].SubItems.Add(item.Quantity.ToString());
                lstWaitingOrders.Items[i].SubItems.Add(item.Price.ToString());
                lstWaitingOrders.Items[i].Tag = item.OrderID;
                i++;
            }
        }


    }
}
