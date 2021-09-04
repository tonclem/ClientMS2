using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class AuditActivityType
    {
        public AuditActivityType()
        {
            AuditLogs = new HashSet<AuditLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
}
