using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            BundleItems = new HashSet<BundleItem>();
            CouponProductRestrictions = new HashSet<CouponProductRestriction>();
            ProductIngredients = new HashSet<ProductIngredient>();
            ProductReviews = new HashSet<ProductReview>();
            ProductViews = new HashSet<ProductView>();
            ServiceItems = new HashSet<ServiceItem>();
            ShoppingCartOrderItems = new HashSet<ShoppingCartOrderItem>();
            UniversalInventoryStocks = new HashSet<UniversalInventoryStock>();
            Wishlists = new HashSet<Wishlist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string GenericName { get; set; }
        public int ManufacturerId { get; set; }
        public int DosageFormId { get; set; }
        public int DocumentUploadId { get; set; }
        public string Highlight { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
        public string BarCodeNumber { get; set; }
        public string UniversalProductCode { get; set; }
        public string HowToUse { get; set; }
        public string Precautions { get; set; }
        public string Storage { get; set; }
        public string Warning { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductSubCategoryId { get; set; }
        public int? ApproverUserId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string ApprovalComment { get; set; }
        public int? Strength { get; set; }
        public int? StrengthUnitId { get; set; }
        public short ProductStatusId { get; set; }
        public bool? RequiresPrescription { get; set; }
        public int? NumberOfSachetsPerPack { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual DocumentUpload DocumentUpload { get; set; }
        public virtual DosageForm DosageForm { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ProductStatus ProductStatus { get; set; }
        public virtual ProductSubCategory ProductSubCategory { get; set; }
        public virtual StrengthUnit StrengthUnit { get; set; }
        public virtual ICollection<BundleItem> BundleItems { get; set; }
        public virtual ICollection<CouponProductRestriction> CouponProductRestrictions { get; set; }
        public virtual ICollection<ProductIngredient> ProductIngredients { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductView> ProductViews { get; set; }
        public virtual ICollection<ServiceItem> ServiceItems { get; set; }
        public virtual ICollection<ShoppingCartOrderItem> ShoppingCartOrderItems { get; set; }
        public virtual ICollection<UniversalInventoryStock> UniversalInventoryStocks { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
