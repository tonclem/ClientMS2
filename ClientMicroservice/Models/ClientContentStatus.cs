using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ClientContentStatus
    {
        public ClientContentStatus()
        {
            ClientContents = new HashSet<ClientContent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClientContent> ClientContents { get; set; }
    }
}
