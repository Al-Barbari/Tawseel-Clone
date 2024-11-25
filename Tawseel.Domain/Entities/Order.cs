using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tawseel.Domain.Enum;

namespace Tawseel.Domain.Entities
{
    public class Order :RootEntity
    {        
        public int UserId { get; set; }
        public int ShopId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int OrderNumber { get; set; }
        public OrderStatus status { get; set; }     
        public decimal SubTotal { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        public string DeliveryAddress { get; set; } = string.Empty;
        public string? Notes { get; set; }

        public virtual Shop? Shop { get; set; }
        public virtual User? User { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
