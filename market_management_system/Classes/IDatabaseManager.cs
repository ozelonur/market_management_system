using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system
{
    interface IDatabaseManager<T, K> where T : class
    {
        List<T> GetAll();
        bool Save(T item);
        bool Update(T item);
        bool Delete(T item);

    }
}
