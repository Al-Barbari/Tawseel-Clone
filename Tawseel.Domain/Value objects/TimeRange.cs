using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Value_objects
{
    [Owned]
    public record TimeRange
    {
        [Column("OpeningHour", TypeName = "time")]
        public TimeSpan OpeningHour { get; private set; }

        [Column("ClosingHour", TypeName = "time")]
        public TimeSpan ClosingHour { get; private set; }

        private TimeRange() { }

        public TimeRange(TimeSpan openingHour, TimeSpan closingHour)
        {
            if (openingHour > closingHour)
                throw new ArgumentException("Opening hour must be earlier than closing hour.");

            OpeningHour = openingHour;
            ClosingHour = closingHour;
        }

        public bool IsWithinOperatingHours(TimeSpan time)
        {
            return time >= OpeningHour && time <= ClosingHour;
        }        
    }
}
