using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class InventoryStockTakeItem
    {
        public int Id { get; set; }
        public int InventoryStockTakeId { get; set; }
        public int UniversalInventoryStockId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int ExpectedQuantity { get; set; }
        public int ActualQuantity { get; set; }
        public int InventoryStockTakeItemStatusId { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual InventoryStockTake InventoryStockTake { get; set; }
        public virtual InventoryStockTakeItemStatus InventoryStockTakeItemStatus { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual UniversalInventoryStock UniversalInventoryStock { get; set; }
    }
}
