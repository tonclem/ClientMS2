using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ShoppingCartOrder
    {
        public ShoppingCartOrder()
        {
            SalesOrders = new HashSet<SalesOrder>();
            ShoppingCartOrderItems = new HashSet<ShoppingCartOrderItem>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string SessionId { get; set; }
        public int? CustomerShippingAddressId { get; set; }
        public string CustomerLocationLatitude { get; set; }
        public string CustomerLocationLongitude { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public long? SalesOrderId { get; set; }
        public int ShoppingCartOrderStatusId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerShippingAddress CustomerShippingAddress { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual ShoppingCartOrderStatus ShoppingCartOrderStatus { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<ShoppingCartOrderItem> ShoppingCartOrderItems { get; set; }
    }
}
