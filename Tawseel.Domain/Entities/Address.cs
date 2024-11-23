using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Address : NamedEntity
    {
        [Column("Latitude")]
        public decimal Latitude { get; set; }
        [Column("Longitude")]
        public decimal Longitude { get; set; }          
    }
}
