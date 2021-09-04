using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ShoppingCartOrderItem
    {
        public int Id { get; set; }
        public int ShoppingCartOrderId { get; set; }
        public int ProductId { get; set; }
        public int? BundleItemId { get; set; }
        public int Quantity { get; set; }
        public int? PackSizeId { get; set; }
        public decimal? MaxUnitPrice { get; set; }
        public decimal? ModUnitPrice { get; set; }
        public decimal? MinUnitPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int ChannelId { get; set; }

        public virtual BundleItem BundleItem { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual PackSize PackSize { get; set; }
        public virtual Product Product { get; set; }
        public virtual ShoppingCartOrder ShoppingCartOrder { get; set; }
    }
}
