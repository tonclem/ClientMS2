using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ClientOutletStatus
    {
        public ClientOutletStatus()
        {
            ClientOutlets = new HashSet<ClientOutlet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClientOutlet> ClientOutlets { get; set; }
    }
}
