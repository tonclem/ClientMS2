using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class State
    {
        public State()
        {
            Addresses = new HashSet<Address>();
            LocalGovernmentAreas = new HashSet<LocalGovernmentArea>();
            LogisticsDeliveryOptions = new HashSet<LogisticsDeliveryOption>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<LocalGovernmentArea> LocalGovernmentAreas { get; set; }
        public virtual ICollection<LogisticsDeliveryOption> LogisticsDeliveryOptions { get; set; }
    }
}
