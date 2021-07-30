using SiparisOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu.Repos
{
    class OrderDetailManagement
    {
        SqlConnection conn;
        DataTable dtOrderDetails;
        SqlDataAdapter adapterOrderDetail;
        public OrderDetailManagement()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            conn = new SqlConnection(connectionString);
            query = $" Select c.CustomerID,c.CompanyName,c.ContactTitle,o.OrderDate,p.ProductName,od.Quantity,(od.Quantity*od.UnitPrice*(1-od.Discount)) Price,o.OrderID from Customers c join Orders o on o.CustomerID=c.CustomerID join[Order Details] od on od.OrderID = o.OrderID join Products p on p.ProductID = od.ProductID where o.EmployeeID is NULL";
            adapterOrderDetail = new SqlDataAdapter(query, conn);
            dtOrderDetails = new DataTable();
            adapterOrderDetail.Fill(dtOrderDetails);
        }
        string query = string.Empty;
        public List<OrderDetail> GetWaitingOrder()
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
       
            foreach (DataRow item in dtOrderDetails.Rows)
            {
                orderDetails.Add(new OrderDetail()
                {
                    CustomerID = item[0].ToString(),
                    CompanyName = item[1].ToString(),
                    ContactTitle = item[2].ToString(),
                    OrderDate = item[3].ToString(),
                    ProductName = item[4].ToString(),
                    Quantity = Convert.ToInt32(item[5]),
                    Price = Convert.ToInt32(item[6]),
                    OrderID = Convert.ToInt32(item[7])
                });
            }
            return orderDetails;
        }

        public OrderDetail GetOrderDetailByOrderID(int orderID)
        {
            foreach (OrderDetail item in GetWaitingOrder())
            {
                if (item.OrderID == orderID)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
