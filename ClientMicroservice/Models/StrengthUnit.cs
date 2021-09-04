using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class StrengthUnit
    {
        public StrengthUnit()
        {
            ProductIngredients = new HashSet<ProductIngredient>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductIngredient> ProductIngredients { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
