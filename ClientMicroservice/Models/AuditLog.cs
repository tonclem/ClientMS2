using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class AuditLog
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int ChannelId { get; set; }
        public int UserId { get; set; }
        public string Activity { get; set; }
        public int AuditActivityTypeId { get; set; }

        public virtual AuditActivityType AuditActivityType { get; set; }
        public virtual Channel Channel { get; set; }
    }
}
