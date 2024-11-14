using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Subscription : NamedEntity
    {
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        [Column("DurationInMonths", TypeName = "varchar(15)")]
        public string DurationInMonths { get; set; } = string.Empty;
        public int NumberOfOrders { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Description { get; set; } = string.Empty;
    }
}
