using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Item : ImageEntity
    {
        [Column("ItemCategoryId")]
        public int ItemCategoryId { get; set; }
        [Column("Price")]
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public ItemCategory? ItemCategory { get; set; }        
    }
}
