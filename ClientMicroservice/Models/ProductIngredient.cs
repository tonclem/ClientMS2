using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ProductIngredient
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        public int Strength { get; set; }
        public int StrengthUnitId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Product Product { get; set; }
        public virtual StrengthUnit StrengthUnit { get; set; }
    }
}
