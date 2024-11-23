using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class NamedEntity : RootEntity
    {
        [Column("Name", TypeName = "varchar(100)")]
        public string ArabicName { get; set; } = string.Empty; 
    }
}
