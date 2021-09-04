using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            CouponProductCategoryRestrictions = new HashSet<CouponProductCategoryRestriction>();
            ProductSubCategories = new HashSet<ProductSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<CouponProductCategoryRestriction> CouponProductCategoryRestrictions { get; set; }
        public virtual ICollection<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
