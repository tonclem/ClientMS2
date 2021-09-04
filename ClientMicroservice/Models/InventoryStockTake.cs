using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class InventoryStockTake
    {
        public InventoryStockTake()
        {
            InventoryStockTakeItems = new HashSet<InventoryStockTakeItem>();
        }

        public int Id { get; set; }
        public int ClientOutletId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int InventoryStockTakeTypeId { get; set; }
        public int InventoryStockTakeStatusId { get; set; }
        public string Description { get; set; }

        public virtual ClientOutlet ClientOutlet { get; set; }
        public virtual InventoryStockTakeStatus InventoryStockTakeStatus { get; set; }
        public virtual InventoryStockTakeType InventoryStockTakeType { get; set; }
        public virtual ICollection<InventoryStockTakeItem> InventoryStockTakeItems { get; set; }
    }
}
