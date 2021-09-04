using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class CurrentInventoryView
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ClientStatusId { get; set; }
        public string ClientStatusName { get; set; }
    }
}
