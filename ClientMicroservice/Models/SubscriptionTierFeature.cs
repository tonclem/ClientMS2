using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SubscriptionTierFeature
    {
        public int Id { get; set; }
        public int SubscriptionTierId { get; set; }
        public string Description { get; set; }

        public virtual SubscriptionTier SubscriptionTier { get; set; }
    }
}
