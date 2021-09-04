using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BlogPostCommentStatus
    {
        public BlogPostCommentStatus()
        {
            BlogPostComments = new HashSet<BlogPostComment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BlogPostComment> BlogPostComments { get; set; }
    }
}
