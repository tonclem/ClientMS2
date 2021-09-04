using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class CouponStatus
    {
        public CouponStatus()
        {
            Coupons = new HashSet<Coupon>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}
