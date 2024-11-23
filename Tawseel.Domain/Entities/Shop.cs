using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tawseel.Domain.Value_objects;

namespace Tawseel.Domain.Entities
{
    public class Shop : ImageEntity
    {
        [Column("AddressId")]
        public int AddressId { get; set; }

        [Column("ShopCategoryId")]
        public int ShopCategoryId { get; set; }
        public TimeRange OperatingHours { get; private set; } = new TimeRange(TimeSpan.Zero, TimeSpan.Zero);

        public virtual Address? Address { get; set; }   
        public virtual ShopCategory? ShopCategory { get; set; }
        public ICollection<ItemCategory> ItemCategories { get; set; } = new List<ItemCategory>();

        public void SetOperatingHours(TimeSpan openingHour, TimeSpan closingHour)
        {
            OperatingHours = new TimeRange(openingHour, closingHour);
        }
    }
}
