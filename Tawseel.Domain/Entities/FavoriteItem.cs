using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class FavoriteItem : RootEntity
    {
        public int ItemId { get; set; }
        public virtual Item? Item { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
