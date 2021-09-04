using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ClientAuthor
    {
        public ClientAuthor()
        {
            ClientContents = new HashSet<ClientContent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Client Client { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual ICollection<ClientContent> ClientContents { get; set; }
    }
}
