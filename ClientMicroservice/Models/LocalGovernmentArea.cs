using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class LocalGovernmentArea
    {
        public LocalGovernmentArea()
        {
            Addresses = new HashSet<Address>();
            LogisticsDeliveryOptions = new HashSet<LogisticsDeliveryOption>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<LogisticsDeliveryOption> LogisticsDeliveryOptions { get; set; }
    }
}
