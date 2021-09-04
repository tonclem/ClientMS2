using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Sender { get; set; }
        public int NotificationDeliveryStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public int NotificationTypeId { get; set; }

        public virtual NotificationDeliveryStatus NotificationDeliveryStatus { get; set; }
        public virtual NotificationType NotificationType { get; set; }
        public virtual User User { get; set; }
    }
}
