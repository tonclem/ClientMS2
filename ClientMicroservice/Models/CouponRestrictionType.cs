using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class CouponRestrictionType
    {
        public CouponRestrictionType()
        {
            CouponProductCategoryRestrictions = new HashSet<CouponProductCategoryRestriction>();
            CouponProductRestrictions = new HashSet<CouponProductRestriction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CouponProductCategoryRestriction> CouponProductCategoryRestrictions { get; set; }
        public virtual ICollection<CouponProductRestriction> CouponProductRestrictions { get; set; }
    }
}
