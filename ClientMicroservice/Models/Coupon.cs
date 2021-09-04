using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponProductCategoryRestrictions = new HashSet<CouponProductCategoryRestriction>();
            CouponProductRestrictions = new HashSet<CouponProductRestriction>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        public int Id { get; set; }
        public string CouponCode { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public int CouponDiscountTypeId { get; set; }
        public int CouponStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateExpiry { get; set; }
        public double? MinimumSpend { get; set; }
        public double? MaximumSpend { get; set; }
        public int? MaximumUses { get; set; }
        public int? MaximumUsePerUser { get; set; }
        public int? MaximumItems { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? DeletedByUserId { get; set; }

        public virtual CouponDiscountType CouponDiscountType { get; set; }
        public virtual CouponStatus CouponStatus { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual User DeletedByUser { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual ICollection<CouponProductCategoryRestriction> CouponProductCategoryRestrictions { get; set; }
        public virtual ICollection<CouponProductRestriction> CouponProductRestrictions { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
