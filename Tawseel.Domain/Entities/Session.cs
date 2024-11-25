using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Session : RootEntity
    {

        [Column("serialNumber", TypeName = "varchar(50)")]
        public string SerialNumber { get; set; } = string.Empty;
        [Column("deviceModel", TypeName = "varchar(50)")]
        public string DeviceModel { get; set; } = string.Empty;
        [Column("brand", TypeName = "varchar(50)")]
        public string Brand { get; set; } = string.Empty;
        [Column("productName", TypeName = "varchar(50)")]
        public string ProductName { get; set; } = string.Empty;
        [Column("androidVersion", TypeName = "varchar(50)")]
        public string AndroidVersion { get; set; } = string.Empty;
        [Column("model", TypeName = "varchar(50)")]
        public string Model { get; set; } = string.Empty;
        [Column("osBuildId", TypeName = "varchar(50)")]
        public string OSBuildId { get; set; } = string.Empty;
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
