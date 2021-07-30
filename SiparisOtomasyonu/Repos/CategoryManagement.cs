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
    class CategoryManagement
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        DataTable dtCategories;
        public CategoryManagement()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            conn = new SqlConnection(connectionString);
            string query = $"Select CategoryID, CategoryName from Categories";
            adapter = new SqlDataAdapter(query, conn);
            dtCategories = new DataTable();
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(dtCategories);
            foreach (DataRow item in dtCategories.Rows)
            {
                categories.Add(new Category()
                {
                    CategoryID=Convert.ToInt32(item[0]),
                    CategoryName=item[1].ToString()
                });
            }
            return categories;
        }
    }
}
