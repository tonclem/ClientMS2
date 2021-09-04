using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class PrescriptionStatus
    {
        public PrescriptionStatus()
        {
            Prescriptions = new HashSet<Prescription>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
