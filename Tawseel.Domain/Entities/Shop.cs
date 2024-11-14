using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Shop : ImageEntity
    {
        public int AddressId { get; set; }
        public int ShopCategoryId { get; set; }
        [Column("OpeningHour", TypeName = "time")]
        public TimeSpan OpeningHour { get; set; }

        [Column("ClosingHour", TypeName = "time")]
        public TimeSpan ClosingHour { get; set; }

        public virtual Address? Address { get; set; }   
        public virtual ShopCategory? ShopCategory { get; set; }
        public ICollection<ItemCategory> ItemCategories { get; set; } = new List<ItemCategory>();
    }
}
