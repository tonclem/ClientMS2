using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class PackSize
    {
        public PackSize()
        {
            BundleItems = new HashSet<BundleItem>();
            ServiceItems = new HashSet<ServiceItem>();
            ShoppingCartOrderItems = new HashSet<ShoppingCartOrderItem>();
            UniversalInventoryStocks = new HashSet<UniversalInventoryStock>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BundleItem> BundleItems { get; set; }
        public virtual ICollection<ServiceItem> ServiceItems { get; set; }
        public virtual ICollection<ShoppingCartOrderItem> ShoppingCartOrderItems { get; set; }
        public virtual ICollection<UniversalInventoryStock> UniversalInventoryStocks { get; set; }
    }
}
