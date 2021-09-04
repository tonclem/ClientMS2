using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ProductReview
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public int ProductReviewStatusId { get; set; }
        public int? ApproverId { get; set; }
        public DateTime? DateApproved { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductReviewStatus ProductReviewStatus { get; set; }
    }
}
