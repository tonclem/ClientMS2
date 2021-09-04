using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OrderFulfilmentItem
    {
        public long Id { get; set; }
        public long OrderFulfilmentId { get; set; }
        public int SalesOrderItemId { get; set; }

        public virtual OrderFulfilment OrderFulfilment { get; set; }
        public virtual SalesOrderItem SalesOrderItem { get; set; }
    }
}
