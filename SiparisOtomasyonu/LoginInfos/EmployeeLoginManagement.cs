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
    class EmployeeLoginManagement
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        DataTable dtCustomerLogin;
        public EmployeeLoginManagement()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            conn = new SqlConnection(connectionString);
            string query = $"select CONCAT(FirstName,'.',LastName) [Kullanici Adi], CONCAT(YEAR(BirthDate),'',REVERSE(City)) Password, EmployeeID from Employees";
            adapter = new SqlDataAdapter(query, conn);
            dtCustomerLogin = new DataTable();

        }

        public List<EmployeeLogin> EmployeeLoginDetails()
        {
            List<EmployeeLogin> employeeLogins = new List<EmployeeLogin>();
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(dtCustomerLogin);
            foreach (DataRow item in dtCustomerLogin.Rows)
            {
                employeeLogins.Add(new EmployeeLogin()
                {
                    UserName = item[0].ToString(),
                    Password = item[1].ToString(),
                    Id=Convert.ToInt32(item[2])
                });
            }
            return employeeLogins;
        }

        public EmployeeLogin GetEmployeeLogin(string userName,string password)
        {
            foreach (EmployeeLogin item in EmployeeLoginDetails())
            {
                if(item.UserName == userName && item.Password == password)
                {                
                    return item;                   
                }
            }
            return null;
        }
    }
}
