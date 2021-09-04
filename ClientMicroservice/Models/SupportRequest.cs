using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SupportRequest
    {
        public SupportRequest()
        {
            SupportRequestReviews = new HashSet<SupportRequestReview>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime? DateResolved { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public int? OrderId { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public int? SupportRequestStatusId { get; set; }
        public int ChannelId { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual SupportRequestStatus SupportRequestStatus { get; set; }
        public virtual ICollection<SupportRequestReview> SupportRequestReviews { get; set; }
    }
}
