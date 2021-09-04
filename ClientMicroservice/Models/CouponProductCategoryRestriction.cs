using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class CouponProductCategoryRestriction
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int ProductCategoryId { get; set; }
        public int CouponRestrictionTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual CouponRestrictionType CouponRestrictionType { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
