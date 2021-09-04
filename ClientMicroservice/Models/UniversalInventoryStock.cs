using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class UniversalInventoryStock
    {
        public UniversalInventoryStock()
        {
            InventoryStockTakeItems = new HashSet<InventoryStockTakeItem>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            UniversalInventoryLevels = new HashSet<UniversalInventoryLevel>();
        }

        public int Id { get; set; }
        public int? ClientOutletId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
        public int? PackSizeId { get; set; }
        public int? ReorderLevel { get; set; }
        public int? ReorderQuantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public decimal? MarkUp { get; set; }
        public int? LargestSellingUnit { get; set; }
        public int? NextSellingUnit { get; set; }
        public int? DefaultSellingUnit { get; set; }
        public decimal? CostPricePerUnit { get; set; }
        public int SellAsUnitId { get; set; }

        public virtual ClientOutlet ClientOutlet { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual PackSize PackSize { get; set; }
        public virtual Product Product { get; set; }
        public virtual SellAsUnit SellAsUnit { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<InventoryStockTakeItem> InventoryStockTakeItems { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<UniversalInventoryLevel> UniversalInventoryLevels { get; set; }
    }
}
