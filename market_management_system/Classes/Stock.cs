using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system.Classes
{
    class Stock
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int UnitPrice { get; set; }
        public float Tax { get; set; }
        public int Piece { get; set; }
    }
}
