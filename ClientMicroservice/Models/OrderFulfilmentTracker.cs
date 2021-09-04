using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OrderFulfilmentTracker
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public long OrderFulfilmentId { get; set; }
        public short OrderFulfilmentStatusId { get; set; }
        public string Comments { get; set; }

        public virtual OrderFulfilment OrderFulfilment { get; set; }
        public virtual OrderFulfilmentStatus OrderFulfilmentStatus { get; set; }
    }
}
