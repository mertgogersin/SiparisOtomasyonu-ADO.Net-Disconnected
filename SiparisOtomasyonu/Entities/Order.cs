using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu.Entities
{
    class Order
    {
        public int OrderID { get; set; }
        public int EmployeeID { get; set; }
        public string CustomerID { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public double TotalPrice { get; set; }
    }
}
