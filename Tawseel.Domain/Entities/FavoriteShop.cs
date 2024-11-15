using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class FavoriteShop : RootEntity
    {
        public int ShopId { get; set; }
        public virtual Shop? Shop { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
