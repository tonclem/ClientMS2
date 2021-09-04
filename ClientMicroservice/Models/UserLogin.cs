using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class UserLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public DateTime DateLogin { get; set; }
        public bool Success { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual User User { get; set; }
    }
}
