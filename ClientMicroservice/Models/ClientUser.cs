using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ClientUser
    {
        public ClientUser()
        {
            SalesOrders = new HashSet<SalesOrder>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClientOutletId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ClientOutlet ClientOutlet { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
