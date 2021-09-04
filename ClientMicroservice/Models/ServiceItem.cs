using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ServiceItem
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }
        public int PackSizeId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? CreatorUserId { get; set; }
        public int ModifiedByUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual PackSize PackSize { get; set; }
        public virtual Product Product { get; set; }
        public virtual Service Service { get; set; }
    }
}
