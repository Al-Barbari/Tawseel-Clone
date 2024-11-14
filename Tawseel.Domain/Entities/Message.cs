using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Message : NamedEntity
    {
        [Column(TypeName = "varchar(510)")]
        public string Content { get; set; } = string.Empty;
        [Column(TypeName = "varchar(1)")]
        public string MessageType { get; set; } = string.Empty; // 1. Error, 2. Success
        public string? ErrorCode { get; set; } = string.Empty; // Error Code
    }
}
