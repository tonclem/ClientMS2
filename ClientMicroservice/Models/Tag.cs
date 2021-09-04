using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Tag
    {
        public Tag()
        {
            BlogPostTags = new HashSet<BlogPostTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? DeletedByUserId { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual User DeletedByUser { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual ICollection<BlogPostTag> BlogPostTags { get; set; }
    }
}
