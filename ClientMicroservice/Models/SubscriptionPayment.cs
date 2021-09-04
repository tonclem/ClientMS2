using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SubscriptionPayment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int SubscriptionTierId { get; set; }
        public int PaymentTypeId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fees { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Reference { get; set; }
        public int ChannelId { get; set; }
        public int PaymentStatusId { get; set; }
        public int PaymentMethodId { get; set; }
        public int? ApproverUserId { get; set; }
        public DateTime? DateApproved { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual Client Client { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PaymentStatus PaymentStatus { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual SubscriptionTier SubscriptionTier { get; set; }
    }
}
