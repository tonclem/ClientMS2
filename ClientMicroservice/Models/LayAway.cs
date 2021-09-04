using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class LayAway
    {
        public LayAway()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public long SalesOrderId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int LayAwayStatusId { get; set; }

        public virtual LayAwayStatus LayAwayStatus { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
