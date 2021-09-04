using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class CustomerShippingAddress
    {
        public CustomerShippingAddress()
        {
            ShoppingCartOrders = new HashSet<ShoppingCartOrder>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDefault { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<ShoppingCartOrder> ShoppingCartOrders { get; set; }
    }
}
