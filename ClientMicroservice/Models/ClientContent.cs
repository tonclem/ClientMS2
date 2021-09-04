using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ClientContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ClientId { get; set; }
        public int ClientAuthorId { get; set; }
        public int ClientContentCategoryId { get; set; }
        public DateTime? DatePublished { get; set; }
        public string Body { get; set; }
        public int ClientContentStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Client Client { get; set; }
        public virtual ClientAuthor ClientAuthor { get; set; }
        public virtual ClientContentCategory ClientContentCategory { get; set; }
        public virtual ClientContentStatus ClientContentStatus { get; set; }
    }
}
