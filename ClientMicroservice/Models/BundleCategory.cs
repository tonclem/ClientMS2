using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BundleCategory
    {
        public BundleCategory()
        {
            Bundles = new HashSet<Bundle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int DocumentUploadId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string Description { get; set; }
        public int? DeletedByUserId { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual User DeletedByUser { get; set; }
        public virtual DocumentUpload DocumentUpload { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual ICollection<Bundle> Bundles { get; set; }
    }
}
