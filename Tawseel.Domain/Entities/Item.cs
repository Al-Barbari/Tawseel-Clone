using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Item : ImageEntity
    {
        public int ItemCategoryId { get; set; }
        public decimal Price { get; set; }
        public ItemCategory? ItemCategory { get; set; }        
    }
}
