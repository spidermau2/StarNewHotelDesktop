using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarNewHotelDesktop.DAO
{
    interface ICRUD<out list, out obj>
    {
        list Get();
        obj Get(int id);
        bool Post(object item);
        bool Put(object item);
        bool Delete();
    }
}
