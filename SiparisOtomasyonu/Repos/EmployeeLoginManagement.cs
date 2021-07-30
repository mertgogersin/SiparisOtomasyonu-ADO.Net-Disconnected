using SiparisOtomasyonu.LoginInfos;
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

        public List<Employee> EmployeeLoginDetails()
        {
            List<Employee> employeeLogins = new List<Employee>();
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(dtCustomerLogin);
            foreach (DataRow item in dtCustomerLogin.Rows)
            {
                employeeLogins.Add(new Employee()
                {
                    UserName = item[0].ToString(),
                    Password = item[1].ToString(),
                    Id = Convert.ToInt32(item[2])
                });
            }
            return employeeLogins;
        }

        public Employee GetEmployeeLogin(string userName, string password)
        {
            Employee employee = null;
            foreach (Employee item in EmployeeLoginDetails())
            {
                if (item.UserName == userName && item.Password == password)
                {
                    employee = item;
                }
            }
            if (employee == null)
            {
                throw new Exception("Lütfen giriş bilgilerinizi kontrol edin.");
            }
            return employee;
        }
    }
}
