using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class InventoryLevelType
    {
        public InventoryLevelType()
        {
            UniversalInventoryLevels = new HashSet<UniversalInventoryLevel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UniversalInventoryLevel> UniversalInventoryLevels { get; set; }
    }
}
