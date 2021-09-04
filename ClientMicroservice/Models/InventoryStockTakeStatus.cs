using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class InventoryStockTakeStatus
    {
        public InventoryStockTakeStatus()
        {
            InventoryStockTakes = new HashSet<InventoryStockTake>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InventoryStockTake> InventoryStockTakes { get; set; }
    }
}
