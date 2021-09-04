using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Wishlist
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? BundleItemId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int ChannelId { get; set; }

        public virtual BundleItem BundleItem { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
