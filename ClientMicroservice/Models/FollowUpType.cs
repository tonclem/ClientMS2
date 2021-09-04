using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class FollowUpType
    {
        public FollowUpType()
        {
            FollowUps = new HashSet<FollowUp>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FollowUp> FollowUps { get; set; }
    }
}
