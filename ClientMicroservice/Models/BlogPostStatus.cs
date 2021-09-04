﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BlogPostStatus
    {
        public BlogPostStatus()
        {
            BlogPosts = new HashSet<BlogPost>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }
}
