using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Faq
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int FaqStatusId { get; set; }
        public int FaqCategoryId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual FaqCategory FaqCategory { get; set; }
        public virtual FaqStatus FaqStatus { get; set; }
    }
}
