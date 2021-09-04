using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BlogCategory
    {
        public BlogCategory()
        {
            BlogPosts = new HashSet<BlogPost>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? DeletedByUserId { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual User DeletedByUser { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }
}
