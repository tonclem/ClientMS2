using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Bank
    {
        public Bank()
        {
            ClientOutlets = new HashSet<ClientOutlet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string BankCode { get; set; }
        public string SortCode { get; set; }
        public int? CountryId { get; set; }

        public virtual ICollection<ClientOutlet> ClientOutlets { get; set; }
    }
}
