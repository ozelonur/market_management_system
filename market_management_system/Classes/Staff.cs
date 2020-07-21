using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system.Classes
{
    class Staff
    {
        public int ID { get; set; }
        public string StaffName { get; set; }
        public string StaffSurName { get; set; }
        public string StaffIDNumber { get; set; }
        public string StaffMobilePhone { get; set; }
        public string StaffHomePhone { get; set; }
        public string StaffAddress { get; set; }
        public int StaffSalary { get; set; }
        public int StaffCheckoutNumber { get; set; }
        public string StaffDateStart { get; set; }
        public string StaffDateQuit { get; set; }

    }
}
