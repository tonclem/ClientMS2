using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            NotificationTypeExclusions = new HashSet<NotificationTypeExclusion>();
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailTemplateId { get; set; }
        public string SmsBodyTemplate { get; set; }
        public string InAppNotificationBodyTemplate { get; set; }
        public bool IsSmsnotification { get; set; }
        public bool IsEmailNotification { get; set; }
        public bool IsInAppNotification { get; set; }
        public bool IsCompulsory { get; set; }

        public virtual ICollection<NotificationTypeExclusion> NotificationTypeExclusions { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
