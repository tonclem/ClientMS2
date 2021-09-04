using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class NotificationTypeExclusion
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int NotificationTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual NotificationType NotificationType { get; set; }
        public virtual User User { get; set; }
    }
}
