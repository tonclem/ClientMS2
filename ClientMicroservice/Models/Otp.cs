using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Otp
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime DateExpiry { get; set; }
        public string Code { get; set; }
        public int? ReferenceId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ValidationAttempts { get; set; }
        public int OtpStatusId { get; set; }

        public virtual OtpStatus OtpStatus { get; set; }
    }
}
