using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ReturnCondition
    {
        public ReturnCondition()
        {
            PurchaseOrderReturnItems = new HashSet<PurchaseOrderReturnItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PurchaseOrderReturnItem> PurchaseOrderReturnItems { get; set; }
    }
}
