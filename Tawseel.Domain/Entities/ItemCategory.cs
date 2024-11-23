using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class ItemCategory : ImageEntity
    {
        [Column("ShopId")]
        public int ShopId { get; set; }
        public Shop? Shop { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
