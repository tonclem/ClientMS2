using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class DosageForm
    {
        public DosageForm()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
