using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
            BlogCategoryCreatorUsers = new HashSet<BlogCategory>();
            BlogCategoryDeletedByUsers = new HashSet<BlogCategory>();
            BlogCategoryModifiedByUsers = new HashSet<BlogCategory>();
            BlogPostComments = new HashSet<BlogPostComment>();
            BlogPosts = new HashSet<BlogPost>();
            BundleCategoryCreatorUsers = new HashSet<BundleCategory>();
            BundleCategoryDeletedByUsers = new HashSet<BundleCategory>();
            BundleCategoryModifiedByUsers = new HashSet<BundleCategory>();
            BundleCreatorUsers = new HashSet<Bundle>();
            BundleDeletedByUsers = new HashSet<Bundle>();
            BundleModifiedByUsers = new HashSet<Bundle>();
            ClientAuthors = new HashSet<ClientAuthor>();
            ClientOutletRatings = new HashSet<ClientOutletRating>();
            ClientOutlets = new HashSet<ClientOutlet>();
            ClientUsers = new HashSet<ClientUser>();
            CouponCreatorUsers = new HashSet<Coupon>();
            CouponDeletedByUsers = new HashSet<Coupon>();
            CouponModifiedByUsers = new HashSet<Coupon>();
            Customers = new HashSet<Customer>();
            DocumentUploads = new HashSet<DocumentUpload>();
            DosageFormCreatorUsers = new HashSet<DosageForm>();
            DosageFormModifiedUsers = new HashSet<DosageForm>();
            InventoryStockTakeItemCreatorUsers = new HashSet<InventoryStockTakeItem>();
            InventoryStockTakeItemModifiedByUsers = new HashSet<InventoryStockTakeItem>();
            NotificationTypeExclusions = new HashSet<NotificationTypeExclusion>();
            Notifications = new HashSet<Notification>();
            ProductReviews = new HashSet<ProductReview>();
            ProductViews = new HashSet<ProductView>();
            Products = new HashSet<Product>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrderCreatorUsers = new HashSet<SalesOrder>();
            SalesOrderDeletedByUsers = new HashSet<SalesOrder>();
            SalesOrderModifiedByUsers = new HashSet<SalesOrder>();
            ShoppingCartOrderItemCreatorUsers = new HashSet<ShoppingCartOrderItem>();
            ShoppingCartOrderItemModifiedByUsers = new HashSet<ShoppingCartOrderItem>();
            TagCreatorUsers = new HashSet<Tag>();
            TagDeletedByUsers = new HashSet<Tag>();
            TagModifiedByUsers = new HashSet<Tag>();
            UniversalInventoryStockCreatorUsers = new HashSet<UniversalInventoryStock>();
            UniversalInventoryStockModifiedByUsers = new HashSet<UniversalInventoryStock>();
            UserLogins = new HashSet<UserLogin>();
            UserRoles = new HashSet<UserRole>();
            WishlistCreatorUsers = new HashSet<Wishlist>();
            WishlistModifiedByUsers = new HashSet<Wishlist>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public bool IsDeleted { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordResetToken { get; set; }
        public DateTime? PasswordResetTokenExpiry { get; set; }
        public DateTime DateCreated { get; set; }
        public string EmailConfirmationToken { get; set; }
        public DateTime? EmailConfirmationTokenExpiry { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int UserStatusId { get; set; }

        public virtual UserStatus UserStatus { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<BlogCategory> BlogCategoryCreatorUsers { get; set; }
        public virtual ICollection<BlogCategory> BlogCategoryDeletedByUsers { get; set; }
        public virtual ICollection<BlogCategory> BlogCategoryModifiedByUsers { get; set; }
        public virtual ICollection<BlogPostComment> BlogPostComments { get; set; }
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public virtual ICollection<BundleCategory> BundleCategoryCreatorUsers { get; set; }
        public virtual ICollection<BundleCategory> BundleCategoryDeletedByUsers { get; set; }
        public virtual ICollection<BundleCategory> BundleCategoryModifiedByUsers { get; set; }
        public virtual ICollection<Bundle> BundleCreatorUsers { get; set; }
        public virtual ICollection<Bundle> BundleDeletedByUsers { get; set; }
        public virtual ICollection<Bundle> BundleModifiedByUsers { get; set; }
        public virtual ICollection<ClientAuthor> ClientAuthors { get; set; }
        public virtual ICollection<ClientOutletRating> ClientOutletRatings { get; set; }
        public virtual ICollection<ClientOutlet> ClientOutlets { get; set; }
        public virtual ICollection<ClientUser> ClientUsers { get; set; }
        public virtual ICollection<Coupon> CouponCreatorUsers { get; set; }
        public virtual ICollection<Coupon> CouponDeletedByUsers { get; set; }
        public virtual ICollection<Coupon> CouponModifiedByUsers { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<DocumentUpload> DocumentUploads { get; set; }
        public virtual ICollection<DosageForm> DosageFormCreatorUsers { get; set; }
        public virtual ICollection<DosageForm> DosageFormModifiedUsers { get; set; }
        public virtual ICollection<InventoryStockTakeItem> InventoryStockTakeItemCreatorUsers { get; set; }
        public virtual ICollection<InventoryStockTakeItem> InventoryStockTakeItemModifiedByUsers { get; set; }
        public virtual ICollection<NotificationTypeExclusion> NotificationTypeExclusions { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductView> ProductViews { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderCreatorUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderDeletedByUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderModifiedByUsers { get; set; }
        public virtual ICollection<ShoppingCartOrderItem> ShoppingCartOrderItemCreatorUsers { get; set; }
        public virtual ICollection<ShoppingCartOrderItem> ShoppingCartOrderItemModifiedByUsers { get; set; }
        public virtual ICollection<Tag> TagCreatorUsers { get; set; }
        public virtual ICollection<Tag> TagDeletedByUsers { get; set; }
        public virtual ICollection<Tag> TagModifiedByUsers { get; set; }
        public virtual ICollection<UniversalInventoryStock> UniversalInventoryStockCreatorUsers { get; set; }
        public virtual ICollection<UniversalInventoryStock> UniversalInventoryStockModifiedByUsers { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Wishlist> WishlistCreatorUsers { get; set; }
        public virtual ICollection<Wishlist> WishlistModifiedByUsers { get; set; }
    }
}
