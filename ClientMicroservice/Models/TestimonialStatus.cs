using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class TestimonialStatus
    {
        public TestimonialStatus()
        {
            Testimonials = new HashSet<Testimonial>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
