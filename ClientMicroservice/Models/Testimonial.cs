using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Testimonial
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime DateOfTestimonial { get; set; }
        public string CustomerName { get; set; }
        public int DocumentUploadId { get; set; }
        public string Message { get; set; }
        public int TestimonialStatusId { get; set; }

        public virtual DocumentUpload DocumentUpload { get; set; }
        public virtual TestimonialStatus TestimonialStatus { get; set; }
    }
}
