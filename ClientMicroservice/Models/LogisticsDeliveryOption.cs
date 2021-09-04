using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class LogisticsDeliveryOption
    {
        public LogisticsDeliveryOption()
        {
            SalesOrders = new HashSet<SalesOrder>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int LogisticDeliveryTypeId { get; set; }
        public string Description { get; set; }
        public decimal Fee { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public int StateId { get; set; }
        public int? LgaId { get; set; }

        public virtual Client Client { get; set; }
        public virtual LocalGovernmentArea Lga { get; set; }
        public virtual LogisticsDeliveryType LogisticDeliveryType { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
