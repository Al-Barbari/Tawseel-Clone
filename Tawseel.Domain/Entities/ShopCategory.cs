using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class ShopCategory : ImageEntity
    {        
        public ICollection<Shop> Shops { get; set; } = new List<Shop>();
    }
}
