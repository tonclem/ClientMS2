using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OrderFulfilmentStatus
    {
        public OrderFulfilmentStatus()
        {
            OrderFulfilmentTrackers = new HashSet<OrderFulfilmentTracker>();
            OrderFulfilments = new HashSet<OrderFulfilment>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrderFulfilmentTracker> OrderFulfilmentTrackers { get; set; }
        public virtual ICollection<OrderFulfilment> OrderFulfilments { get; set; }
    }
}
