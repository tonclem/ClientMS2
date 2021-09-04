using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BlogPostComment
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string Comment { get; set; }
        public string Commenter { get; set; }
        public int BlogPostCommentStatusId { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? ApproverUserId { get; set; }

        public virtual BlogPost BlogPost { get; set; }
        public virtual BlogPostCommentStatus BlogPostCommentStatus { get; set; }
        public virtual User CreatorUser { get; set; }
    }
}
