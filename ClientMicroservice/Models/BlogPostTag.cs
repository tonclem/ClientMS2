using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BlogPostTag
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public int TagId { get; set; }

        public virtual BlogPost BlogPost { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
