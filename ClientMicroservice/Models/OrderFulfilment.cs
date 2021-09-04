using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OrderFulfilment
    {
        public OrderFulfilment()
        {
            OrderFulfilmentItems = new HashSet<OrderFulfilmentItem>();
            OrderFulfilmentTrackers = new HashSet<OrderFulfilmentTracker>();
        }

        public long Id { get; set; }
        public long SalesOrderId { get; set; }
        public int ClientOutletId { get; set; }
        public string TrackingNumber { get; set; }
        public string Comments { get; set; }
        public short OrderFulfilmentStatusId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDelivered { get; set; }

        public virtual ClientOutlet ClientOutlet { get; set; }
        public virtual OrderFulfilmentStatus OrderFulfilmentStatus { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual ICollection<OrderFulfilmentItem> OrderFulfilmentItems { get; set; }
        public virtual ICollection<OrderFulfilmentTracker> OrderFulfilmentTrackers { get; set; }
    }
}
