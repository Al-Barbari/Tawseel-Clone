using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class OrderDetails : RootEntity
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ItemPrice { get; set; }
        public int Discount { get; set; }
        public decimal TotalPrice { get; set; }


        public virtual Order? Order { get; set; }
        public virtual Item? Item { get; set; }
    }
}
