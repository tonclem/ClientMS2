using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ClientOutletRating
    {
        public int Id { get; set; }
        public int RaterUserId { get; set; }
        public int NumberOfStars { get; set; }
        public int ClientOutletId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Comments { get; set; }

        public virtual ClientOutlet ClientOutlet { get; set; }
        public virtual User RaterUser { get; set; }
    }
}
