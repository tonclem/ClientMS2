using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            LayAways = new HashSet<LayAway>();
            OrderActivities = new HashSet<OrderActivity>();
            OrderFulfilments = new HashSet<OrderFulfilment>();
            Payments = new HashSet<Payment>();
            Prescriptions = new HashSet<Prescription>();
            ShoppingCartOrders = new HashSet<ShoppingCartOrder>();
            UniversalInventoryLevels = new HashSet<UniversalInventoryLevel>();
        }

        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int BillingAddressId { get; set; }
        public int ShippingAddressId { get; set; }
        public double? DeliveryCharge { get; set; }
        public int? SellerClientUserId { get; set; }
        public int? SellerClientId { get; set; }
        public int? SellerClientOutletId { get; set; }
        public int OrderStatusId { get; set; }
        public int? CouponId { get; set; }
        public int? LogisticDeliverOptionId { get; set; }
        public int ChannelId { get; set; }
        public int? ApproverId { get; set; }
        public DateTime? DateApproved { get; set; }
        public double? Tax { get; set; }
        public int CustomerId { get; set; }
        public bool IsDeleted { get; set; }
        public string UniqueOrderId { get; set; }
        public string ReceiptNumber { get; set; }
        public int SalesOrderTypeId { get; set; }
        public int? ShoppingCartOrderId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? DeletedByUserId { get; set; }

        public virtual Address BillingAddress { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual Coupon Coupon { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual User DeletedByUser { get; set; }
        public virtual LogisticsDeliveryOption LogisticDeliverOption { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual SalesOrderType SalesOrderType { get; set; }
        public virtual Client SellerClient { get; set; }
        public virtual ClientOutlet SellerClientOutlet { get; set; }
        public virtual ClientUser SellerClientUser { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual ShoppingCartOrder ShoppingCartOrder { get; set; }
        public virtual ICollection<LayAway> LayAways { get; set; }
        public virtual ICollection<OrderActivity> OrderActivities { get; set; }
        public virtual ICollection<OrderFulfilment> OrderFulfilments { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<ShoppingCartOrder> ShoppingCartOrders { get; set; }
        public virtual ICollection<UniversalInventoryLevel> UniversalInventoryLevels { get; set; }
    }
}
