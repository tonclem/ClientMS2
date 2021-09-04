using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DialingCode { get; set; }
        public string CountryCode { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
