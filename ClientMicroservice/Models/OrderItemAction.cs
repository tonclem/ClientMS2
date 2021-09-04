using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OrderItemAction
    {
        public OrderItemAction()
        {
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
