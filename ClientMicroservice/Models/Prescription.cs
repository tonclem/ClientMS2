using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Prescription
    {
        public int Id { get; set; }
        public long SalesOrderId { get; set; }
        public int DocumentUploadId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int PrescriptionStatusId { get; set; }

        public virtual DocumentUpload DocumentUpload { get; set; }
        public virtual PrescriptionStatus PrescriptionStatus { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
