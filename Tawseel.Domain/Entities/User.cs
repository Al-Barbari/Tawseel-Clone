using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class User : RootEntity
    {
        [Column("UserName", TypeName = "varchar(50)")]
        public string UserName { get; set; } = string.Empty;     
        [Column("UserType", TypeName = "varchar(1)")]
        public string UserType { get; set; } = string.Empty;
        // 1. Admin, 2. User, 3. Business, 4. Delivery
        [Column("PhoneNumber", TypeName = "varchar(9)")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Column("CityId")]
        public int CityId { get; set; }

        public virtual City? City { get; set; }
    }
}
