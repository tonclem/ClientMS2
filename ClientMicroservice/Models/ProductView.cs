using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ProductView
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime DateViewed { get; set; }
        public int ChannelId { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
