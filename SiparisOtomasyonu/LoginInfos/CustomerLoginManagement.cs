using SiparisOtomasyonu.Products;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu.LoginInfos
{
    class CustomerLoginManagement
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        DataTable dtCustomerLogin;
        public CustomerLoginManagement()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            conn = new SqlConnection(connectionString);
            string query = $"select CustomerID [Sirket Adi], CONCAT(City,'/',Country) Password, ContactName, CompanyName, ContactTitle from Customers";
            adapter = new SqlDataAdapter(query, conn);
            dtCustomerLogin = new DataTable();
           
        }

        public List<CustomerLogin> CustomerLoginDetails()
        {
            List<CustomerLogin> customerLogins = new List<CustomerLogin>();
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(dtCustomerLogin);
            foreach (DataRow item in dtCustomerLogin.Rows)
            {
                customerLogins.Add(new CustomerLogin()
                {
                    CustomerID=item[0].ToString(),
                    Password=item[1].ToString(),
                    CustomerName=item[2].ToString(),
                    CompanyName=item[3].ToString(),
                    ContactTitle = item[4].ToString()
                });
            }
            return customerLogins;        
        }

        public CustomerLogin GetCustomerLogin(string userName, string password)
        {
            foreach (CustomerLogin item in CustomerLoginDetails())
            {
                if (item.CustomerID == userName && item.Password == password)
                {                  
                    return item;
                }
            }
            return null;
        }
    }
}
