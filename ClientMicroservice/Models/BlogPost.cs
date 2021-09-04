using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BlogPost
    {
        public BlogPost()
        {
            BlogPostComments = new HashSet<BlogPostComment>();
            BlogPostImages = new HashSet<BlogPostImage>();
            BlogPostTags = new HashSet<BlogPostTag>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string HtmlText { get; set; }
        public DateTime DatePublished { get; set; }
        public int? Likes { get; set; }
        public int BlogPostStatusId { get; set; }
        public int BlogCategoryId { get; set; }
        public int MainImageDocumentUploadId { get; set; }
        public string Highlight { get; set; }

        public virtual BlogCategory BlogCategory { get; set; }
        public virtual BlogPostStatus BlogPostStatus { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual ICollection<BlogPostComment> BlogPostComments { get; set; }
        public virtual ICollection<BlogPostImage> BlogPostImages { get; set; }
        public virtual ICollection<BlogPostTag> BlogPostTags { get; set; }
    }
}
