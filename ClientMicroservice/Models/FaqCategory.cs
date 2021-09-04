﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class FaqCategory
    {
        public FaqCategory()
        {
            Faqs = new HashSet<Faq>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Faq> Faqs { get; set; }
    }
}
