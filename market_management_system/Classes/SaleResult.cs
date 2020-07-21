using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system.Classes
{
    class SaleResult
    {
        public int ID { get; set; }
        public string BillNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurName { get; set; }
        public string IDNumber { get; set; }
        public string ProductName { get; set; }
        public int salePrice { get; set; }
        public int Piece { get; set; }
        public int TotalAmount { get; set; }
        public int CheckOutNumber { get; set; }
        public string Date { get; set; }
    }
}
