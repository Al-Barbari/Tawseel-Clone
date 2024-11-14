using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public abstract class RootEntity
    {

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Status",TypeName = "bit")]
        public bool Status { get; set; }
        [Column("IsDeleted", TypeName = "bit")]
        public bool IsDeleted { get; set; }
        [Column("CreatedAt", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("DeletedAt", TypeName = "datetime")]
        public DateTime DeletedAt { get; set; }

    }
}
