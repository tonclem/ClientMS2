using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class LogisticsDeliveryType
    {
        public LogisticsDeliveryType()
        {
            LogisticsDeliveryOptions = new HashSet<LogisticsDeliveryOption>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LogisticsDeliveryOption> LogisticsDeliveryOptions { get; set; }
    }
}
