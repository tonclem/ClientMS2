using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Bundle
    {
        public Bundle()
        {
            BundleItems = new HashSet<BundleItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int DocumentUploadId { get; set; }
        public int BundleCategoryId { get; set; }
        public string Description { get; set; }
        public string Highlight { get; set; }
        public decimal? CurrentCost { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ClientOutletId { get; set; }
        public decimal? Price { get; set; }
        public int? DeletedByUserId { get; set; }

        public virtual BundleCategory BundleCategory { get; set; }
        public virtual ClientOutlet ClientOutlet { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual User DeletedByUser { get; set; }
        public virtual DocumentUpload DocumentUpload { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual ICollection<BundleItem> BundleItems { get; set; }
    }
}
