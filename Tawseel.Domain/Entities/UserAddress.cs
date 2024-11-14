using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class UserAddress : RootEntity
    {
        [Column("UserId")]
        public int UserId { get; set; }
        [Column("CityId")]
        public int CityId { get; set; }
        [Column("AddressId")]
        public int AddressId { get; set; }     
        
        public virtual User? User { get; set; }
        public virtual City? City { get; set; }
        public virtual Address? Address { get; set; }
    }
}
