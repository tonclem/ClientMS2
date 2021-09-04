using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ShoppingCartOrderStatus
    {
        public ShoppingCartOrderStatus()
        {
            ShoppingCartOrders = new HashSet<ShoppingCartOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ShoppingCartOrder> ShoppingCartOrders { get; set; }
    }
}
