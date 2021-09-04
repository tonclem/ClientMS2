using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SubscriptionTier
    {
        public SubscriptionTier()
        {
            Clients = new HashSet<Client>();
            SubscriptionPayments = new HashSet<SubscriptionPayment>();
            SubscriptionTierFeatures = new HashSet<SubscriptionTierFeature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
        public virtual ICollection<SubscriptionTierFeature> SubscriptionTierFeatures { get; set; }
    }
}
