using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class NotificationDeliveryStatus
    {
        public NotificationDeliveryStatus()
        {
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
