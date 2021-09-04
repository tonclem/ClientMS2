using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class UniversalInventoryLevel
    {
        public int Id { get; set; }
        public int UniversalStockId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int? BatchNumber { get; set; }
        public int? ModifiedById { get; set; }
        public long? SalesOrderId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int InventoryLevelTypeId { get; set; }
        public string Notes { get; set; }
        public DateTime DateExpiry { get; set; }

        public virtual InventoryLevelType InventoryLevelType { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual UniversalInventoryStock UniversalStock { get; set; }
    }
}
