using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Payments = new HashSet<Payment>();
            SubscriptionPayments = new HashSet<SubscriptionPayment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
    }
}
