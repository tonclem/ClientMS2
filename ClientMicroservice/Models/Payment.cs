using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public long SalesOrderId { get; set; }
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
        public int? LayawayId { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual LayAway Layaway { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PaymentStatus PaymentStatus { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
