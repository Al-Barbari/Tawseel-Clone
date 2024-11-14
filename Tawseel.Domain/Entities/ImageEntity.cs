using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class ImageEntity : NamedEntity
    {
        [Column("ImageUrl", TypeName = "varchar(255)")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
