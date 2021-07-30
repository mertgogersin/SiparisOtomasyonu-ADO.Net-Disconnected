using SiparisOtomasyonu.Enums;
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
    class ProductManagement
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        DataTable dtProducts;
        public ProductManagement()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            conn = new SqlConnection(connectionString);

        }
        string query = string.Empty;
        public List<Product> GetProducts(FilterOrGet type, int categoryID = 0)
        {
            List<Product> products = new List<Product>();
            switch (type)
            {
                case FilterOrGet.Filter:
                    query = $"Select ProductID, ProductName, UnitPrice, CategoryID from Products Where CategoryID =@categoryID";
                    adapter = new SqlDataAdapter(query, conn);
                     dtProducts = new DataTable();
                    adapter.SelectCommand.Parameters.AddWithValue("@categoryID", categoryID);
                    break;
                case FilterOrGet.Get:
                    query = $"Select ProductID, ProductName, UnitPrice, CategoryID from Products";
                    adapter = new SqlDataAdapter(query, conn);
                     dtProducts = new DataTable();
                    break;
            }
            commandBuilder = new SqlCommandBuilder(adapter);
            
            adapter.Fill(dtProducts);
            foreach (DataRow item in dtProducts.Rows)
            {
                products.Add(new Product()
                {
                    ProductID = Convert.ToInt32(item[0]),
                    ProductName = item[1].ToString(),
                    UnitPrice = Convert.ToInt32(item[2]),
                    CategoryID = Convert.ToInt32(item[3])
                });
            }
            return products;
        }


    }
}
