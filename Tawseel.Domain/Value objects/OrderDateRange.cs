using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Value_objects
{
    public record OrderDateRange
    {

        public DateTime OrderDate { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public OrderDateRange(DateTime orderDate, DateTime deliveryDate)
        {
            if (deliveryDate <= orderDate)
                throw new ArgumentException("Delivery date must be after the order date.");

            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
        }
    }
}
