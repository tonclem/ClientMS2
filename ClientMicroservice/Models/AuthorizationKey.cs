using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class AuthorizationKey
    {
        public AuthorizationKey()
        {
            Clients = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public int AuthorizationKeyStatus { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
