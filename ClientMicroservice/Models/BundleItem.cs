using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class BundleItem
    {
        public BundleItem()
        {
            ShoppingCartOrderItems = new HashSet<ShoppingCartOrderItem>();
            Wishlists = new HashSet<Wishlist>();
        }

        public int Id { get; set; }
        public int BundleId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int PackSizeId { get; set; }

        public virtual Bundle Bundle { get; set; }
        public virtual PackSize PackSize { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ShoppingCartOrderItem> ShoppingCartOrderItems { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
