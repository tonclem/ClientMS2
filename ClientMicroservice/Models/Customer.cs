using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerShippingAddresses = new HashSet<CustomerShippingAddress>();
            NotificationTypeExclusions = new HashSet<NotificationTypeExclusion>();
            ShoppingCartOrders = new HashSet<ShoppingCartOrder>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int? UserId { get; set; }
        public DateTime? Birthday { get; set; }
        public int? ClientId { get; set; }
        public int? CreatorUserId { get; set; }
        public long? ModifiedByUserId { get; set; }
        public string BloodType { get; set; }
        public double? HeightMetres { get; set; }
        public double? WeightKg { get; set; }
        public short CustomerTypeId { get; set; }
        public string Gender { get; set; }
        public string CompanyName { get; set; }
        public bool? SendPromoDetails { get; set; }
        public bool? SendBirthdayEmail { get; set; }
        public string ActivateReward { get; set; }
        public decimal? PurchaseLimit { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ClientOutletId { get; set; }

        public virtual Client Client { get; set; }
        public virtual ClientOutlet ClientOutlet { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CustomerShippingAddress> CustomerShippingAddresses { get; set; }
        public virtual ICollection<NotificationTypeExclusion> NotificationTypeExclusions { get; set; }
        public virtual ICollection<ShoppingCartOrder> ShoppingCartOrders { get; set; }
    }
}
