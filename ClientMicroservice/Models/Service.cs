using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Service
    {
        public Service()
        {
            ServiceItems = new HashSet<ServiceItem>();
            UniversalInventoryStocks = new HashSet<UniversalInventoryStock>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<ServiceItem> ServiceItems { get; set; }
        public virtual ICollection<UniversalInventoryStock> UniversalInventoryStocks { get; set; }
    }
}
