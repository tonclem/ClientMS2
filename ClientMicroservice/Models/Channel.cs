using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Channel
    {
        public Channel()
        {
            AuditLogs = new HashSet<AuditLog>();
            Payments = new HashSet<Payment>();
            ProductViews = new HashSet<ProductView>();
            PurchaseOrderReturns = new HashSet<PurchaseOrderReturn>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrders = new HashSet<SalesOrder>();
            ShoppingCartOrderItems = new HashSet<ShoppingCartOrderItem>();
            SubscriptionPayments = new HashSet<SubscriptionPayment>();
            SupportRequests = new HashSet<SupportRequest>();
            UserLogins = new HashSet<UserLogin>();
            Wishlists = new HashSet<Wishlist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ProductView> ProductViews { get; set; }
        public virtual ICollection<PurchaseOrderReturn> PurchaseOrderReturns { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<ShoppingCartOrderItem> ShoppingCartOrderItems { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
        public virtual ICollection<SupportRequest> SupportRequests { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
