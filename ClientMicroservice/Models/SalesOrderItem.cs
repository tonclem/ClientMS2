using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SalesOrderItem
    {
        public SalesOrderItem()
        {
            OrderFulfilmentItems = new HashSet<OrderFulfilmentItem>();
        }

        public int Id { get; set; }
        public int SalesOrderId { get; set; }
        public int UniversalInventoryStockId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int? PackSizeId { get; set; }
        public int? BundleItemId { get; set; }
        public decimal? CouponDiscount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int? SellerClientOutletId { get; set; }

        public virtual ICollection<OrderFulfilmentItem> OrderFulfilmentItems { get; set; }
    }
}
