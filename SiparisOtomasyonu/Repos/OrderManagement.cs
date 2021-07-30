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
    class OrderManagement
    {
        SqlConnection conn;
        SqlCommandBuilder commandBuilder;
        public OrderManagement()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            conn = new SqlConnection(connectionString);
        }

        public void InsertIntoOrders(Order order)
        {
            string query = "Select * From Orders";
            SqlDataAdapter adapterOrder = new SqlDataAdapter(query, conn);
            DataTable dtOrders = new DataTable();
            adapterOrder.Fill(dtOrders);
            commandBuilder = new SqlCommandBuilder(adapterOrder);


            DataRow dataRow = dtOrders.NewRow();
            dataRow[1] = order.CustomerID;
            dataRow[3] = order.OrderDate;
            dtOrders.Rows.Add(dataRow);
            adapterOrder.Update(dtOrders);
        }

        public void InsertIntoOrderDetails(Order order, Product product)
        {
            string query = "Select * From [Order Details]";
            SqlDataAdapter adapterDetails = new SqlDataAdapter(query, conn);
            DataTable dtOrderDetails = new DataTable();
            adapterDetails.Fill(dtOrderDetails);

            commandBuilder = new SqlCommandBuilder(adapterDetails);


            DataRow dataRow = dtOrderDetails.NewRow();
            dataRow[0] = GetOrderID();
            dataRow[1] = product.ProductID;
            dataRow[2] = product.UnitPrice;
            dataRow[3] = product.Quantity;
            dtOrderDetails.Rows.Add(dataRow);
            adapterDetails.Update(dtOrderDetails);

        }

        private int GetOrderID()
        {
            int orderID = 0;
            string query = $"Select MAX(OrderID) from Orders";
            SqlDataAdapter adapterOrder = new SqlDataAdapter(query, conn);
            DataTable dtorders = new DataTable();
            adapterOrder.Fill(dtorders);
            commandBuilder = new SqlCommandBuilder(adapterOrder);

            DataTable dt = new DataTable();
            adapterOrder.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                orderID = Convert.ToInt32(item[0]);
            }
            return orderID;
        }


        public void UpdateWaitingOrder(int orderId, int employeeID)
        {
            string query = $"Select * from Orders Where OrderID = {orderId} ";
            SqlDataAdapter adapterOrder = new SqlDataAdapter(query, conn);
            DataTable dtorders = new DataTable();
            adapterOrder.Fill(dtorders);
            commandBuilder = new SqlCommandBuilder(adapterOrder);
            commandBuilder = new SqlCommandBuilder();

            DataRow row = null;
            foreach (DataRow item in dtorders.Rows)
            {
                row = item;
            }
            row[2] = employeeID;
            row[4] = DateTime.Now;

            adapterOrder.Update(dtorders);
        }

    }
}
