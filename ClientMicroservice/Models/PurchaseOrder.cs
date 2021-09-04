using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            PurchaseOrderReturns = new HashSet<PurchaseOrderReturn>();
            UniversalInventoryLevels = new HashSet<UniversalInventoryLevel>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int? BuyerClientId { get; set; }
        public int? BuyerClientOutletId { get; set; }
        public int? ShippingAddressId { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public int OrderStatusId { get; set; }
        public int ChannelId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? DeliveryFee { get; set; }
        public string PoNumber { get; set; }
        public DateTime? DateReceived { get; set; }

        public virtual Client BuyerClient { get; set; }
        public virtual ClientOutlet BuyerClientOutlet { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<PurchaseOrderReturn> PurchaseOrderReturns { get; set; }
        public virtual ICollection<UniversalInventoryLevel> UniversalInventoryLevels { get; set; }
    }
}
