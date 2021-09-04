using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OrderActivityType
    {
        public OrderActivityType()
        {
            OrderActivities = new HashSet<OrderActivity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrderActivity> OrderActivities { get; set; }
    }
}
