using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Enum
{
    public enum OrderStatus
    {
        Pending = 1,
        Confirmed,
        Shipped,
        Delivered,
        Cancelled
    }
}
