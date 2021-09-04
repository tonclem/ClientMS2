using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class PurchaseOrderReturnItem
    {
        public int Id { get; set; }
        public int OrderReturnId { get; set; }
        public int ReturnQuantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int PurchaseOrderItemId { get; set; }
        public int ReturnConditionId { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual PurchaseOrderReturn OrderReturn { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
        public virtual ReturnCondition ReturnCondition { get; set; }
    }
}
