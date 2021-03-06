using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ReturnReason
    {
        public ReturnReason()
        {
            PurchaseOrderReturns = new HashSet<PurchaseOrderReturn>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PurchaseOrderReturn> PurchaseOrderReturns { get; set; }
    }
}
