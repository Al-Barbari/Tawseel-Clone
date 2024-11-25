using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class UserSubscription : RootEntity
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }

        public virtual Subscription? Subscription { get; set; }
        public virtual User? User { get; set; }
    }
}
