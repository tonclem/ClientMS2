using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class InventoryStockTakeItemStatus
    {
        public InventoryStockTakeItemStatus()
        {
            InventoryStockTakeItems = new HashSet<InventoryStockTakeItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InventoryStockTakeItem> InventoryStockTakeItems { get; set; }
    }
}
