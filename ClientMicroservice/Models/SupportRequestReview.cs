using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SupportRequestReview
    {
        public int Id { get; set; }
        public int SupportRequestId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public string Comments { get; set; }

        public virtual SupportRequest SupportRequest { get; set; }
    }
}
