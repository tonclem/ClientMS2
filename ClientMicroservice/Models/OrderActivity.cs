using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OrderActivity
    {
        public int Id { get; set; }
        public long SalesOrderId { get; set; }
        public int OrderActivityTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public int? UserId { get; set; }
        public string Comments { get; set; }

        public virtual OrderActivityType OrderActivityType { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
