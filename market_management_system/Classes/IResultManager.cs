using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system.Classes
{
    interface IResultManager<T,K> where T : class
    {
        List<T> GetAllSpecified();
    }
}
