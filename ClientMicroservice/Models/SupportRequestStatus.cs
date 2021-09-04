using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SupportRequestStatus
    {
        public SupportRequestStatus()
        {
            SupportRequests = new HashSet<SupportRequest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SupportRequest> SupportRequests { get; set; }
    }
}
