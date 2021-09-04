using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class MyMedicineAnalytic
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int? NumberOfActiveUsers { get; set; }
        public int? NumberOfNewUsers { get; set; }
        public decimal? BounceRate { get; set; }
        public decimal? AverageEngagementTime { get; set; }
    }
}
