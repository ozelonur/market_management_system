using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system.Classes
{
    class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Code { get; set; }
        public int companyID { get; set; }
        public int purchasePrice { get; set; }
        public int salePrice { get; set; }
        public int categoryID { get; set; }
    }
}
