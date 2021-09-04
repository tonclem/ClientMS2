using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BlogPostImage
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public int DocumentUploadId { get; set; }
        public string PlaceHolder { get; set; }

        public virtual BlogPost BlogPost { get; set; }
        public virtual DocumentUpload DocumentUpload { get; set; }
    }
}
