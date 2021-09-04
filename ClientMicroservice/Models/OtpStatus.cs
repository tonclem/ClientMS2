using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class OtpStatus
    {
        public OtpStatus()
        {
            Otps = new HashSet<Otp>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Otp> Otps { get; set; }
    }
}
