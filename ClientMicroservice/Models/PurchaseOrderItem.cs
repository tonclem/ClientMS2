using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class PurchaseOrderItem
    {
        public PurchaseOrderItem()
        {
            PurchaseOrderReturnItems = new HashSet<PurchaseOrderReturnItem>();
        }

        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int UniversalStockId { get; set; }
        public int QuantityOrdered { get; set; }
        public int? QuantityReceived { get; set; }
        public int? QuantityAccepted { get; set; }
        public double UnitPrice { get; set; }
        public string BatchNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int? OrderItemActionId { get; set; }
        public int? OrderItemConditionId { get; set; }

        public virtual OrderItemAction OrderItemAction { get; set; }
        public virtual OrderItemCondition OrderItemCondition { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual UniversalInventoryStock UniversalStock { get; set; }
        public virtual ICollection<PurchaseOrderReturnItem> PurchaseOrderReturnItems { get; set; }
    }
}
