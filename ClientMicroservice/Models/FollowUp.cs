using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class FollowUp
    {
        public int Id { get; set; }
        public int SalesOderId { get; set; }
        public DateTime DateFollowUp { get; set; }
        public double? TemperatureCelcius { get; set; }
        public string BloodPressure { get; set; }
        public int? HeartRate { get; set; }
        public int? Respiration { get; set; }
        public double? Bmi { get; set; }
        public string Comment { get; set; }
        public string Title { get; set; }
        public int? FollowUpTypeId { get; set; }

        public virtual FollowUpType FollowUpType { get; set; }
    }
}
