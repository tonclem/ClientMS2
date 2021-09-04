using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            DocumentUploads = new HashSet<DocumentUpload>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DocumentUpload> DocumentUploads { get; set; }
    }
}
