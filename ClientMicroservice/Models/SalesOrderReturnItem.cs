using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SalesOrderReturnItem
    {
        public int Id { get; set; }
        public int OrderReturnId { get; set; }
        public int ReturnQuantity { get; set; }
        public int SalesOrderItemId { get; set; }
        public int ReturnConditionId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
    }
}
