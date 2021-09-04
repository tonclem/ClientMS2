using System;
using Microsoft.EntityFrameworkCore;

namespace NotificationService.Data.Data
{
    public class MyDatabaseContext : DbContext
    {

        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<NotificationService.Data.Models.LocalGovernmentArea> LocalGovernmentArea { get; set; }
        public DbSet<NotificationService.Data.Models.Role> Role { get; set; }
        public DbSet<NotificationService.Data.Models.State> State { get; set; }
        public DbSet<NotificationService.Data.Models.UserLogin> UserLogin { get; set; }
        public DbSet<NotificationService.Data.Models.UserRole> UserRole { get; set; }

        public DbSet<NotificationService.Data.Models.Coupon> Coupon { get; set; }
        public DbSet<NotificationService.Data.Models.Channel> Channel { get; set; }
        public DbSet<NotificationService.Data.Models.OrderActivity> OrderActivity { get; set; }
        public DbSet<NotificationService.Data.Models.SalesOrderReturnItem> SalesOrderReturnItem { get; set; }

        public DbSet<NotificationService.Data.Models.SalesOrder> SalesOrder { get; set; }
        public DbSet<NotificationService.Data.Models.ShoppingCartOrderItem> ShoppingCartOrderItem { get; set; }
        public DbSet<NotificationService.Data.Models.ShoppingCartOrderStatus> ShoppingCartOrderStatus { get; set; }
        public DbSet<NotificationService.Data.Models.Prescription> Prescription { get; set; }


        public DbSet<NotificationService.Data.Models.Address> Address { get; set; }
        public DbSet<NotificationService.Data.Models.User> UserData { get; set; }



        public DbSet<NotificationService.Data.Models.Country> Country { get; set; }
        public DbSet<NotificationService.Data.Models.ShoppingCartOrder> ShoppingCartOrder { get; set; }
        public DbSet<NotificationService.Data.Models.Wishlist> Wishlist { get; set; }

        public DbSet<NotificationService.Data.Models.PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<NotificationService.Data.Models.PurchaseOrderItem> PurchaseOrderItem { get; set; }
        public DbSet<NotificationService.Data.Models.ReturnReason> ReturnReason { get; set; }
        public DbSet<NotificationService.Data.Models.OrderReturnStatus> OrderReturnStatus { get; set; }
        //public DbSet<TokenServices.Core.Models.Pa> PaymentStatus { get; set; }

        public DbSet<NotificationService.Data.Models.PaymentType> PaymentType { get; set; }
        public DbSet<NotificationService.Data.Models.InventoryLevelType> InventoryLevelType { get; set; }
        public DbSet<NotificationService.Data.Models.ProductView> ProductView { get; set; }
        public DbSet<NotificationService.Data.Models.Payment> Payment { get; set; }
        public DbSet<NotificationService.Data.Models.SalesOrderReturn> SalesOrderReturn { get; set; }


        public DbSet<NotificationService.Data.Models.Product> Product { get; set; }
        public DbSet<NotificationService.Data.Models.ProductSubCategory> ProductSubCategory { get; set; }
        public DbSet<NotificationService.Data.Models.Manufacturer> Manufacturer { get; set; }

        public DbSet<NotificationService.Data.Models.SalesOrderItem> SalesOrderItem { get; set; }
        public DbSet<NotificationService.Data.Models.CouponStatus> CouponStatus { get; set; }
        public DbSet<NotificationService.Data.Models.Client> Client { get; set; }
        public DbSet<NotificationService.Data.Models.OrderStatus> OrderStatus { get; set; }

        public DbSet<NotificationService.Data.Models.CouponDiscountType> CouponDiscountType { get; set; }
        public DbSet<NotificationService.Data.Models.CouponProductCategoryRestriction> CouponProductCategoryRestriction { get; set; }
        public DbSet<NotificationService.Data.Models.CouponProductRestriction> CouponProductRestriction { get; set; }
        public DbSet<NotificationService.Data.Models.OrderActivityType> OrderActivityType { get; set; }

        public DbSet<NotificationService.Data.Models.LogisticsDeliveryOption> LogisticsDeliveryOption { get; set; }
        public DbSet<NotificationService.Data.Models.ClientOutlet> ClientOutlet { get; set; }
        public DbSet<NotificationService.Data.Models.ClientStatus> ClientStatus { get; set; }
        public DbSet<NotificationService.Data.Models.ClientType> ClientType { get; set; }

        public DbSet<NotificationService.Data.Models.ClientOutletStatus> ClientOutletStatus { get; set; }
        public DbSet<NotificationService.Data.Models.ClientOutletType> ClientOutletType { get; set; }



        public DbSet<NotificationService.Data.Models.LogisticsDeliveryType> LogisticsDeliveryType { get; set; }
        public DbSet<NotificationService.Data.Models.ClientUser> ClientUser { get; set; }
        public DbSet<NotificationService.Data.Models.DosageForm> DosageForm { get; set; }
        public DbSet<NotificationService.Data.Models.BundleItem> BundleItem { get; set; }

        public DbSet<NotificationService.Data.Models.ProductCategory> ProductCategory { get; set; }
        public DbSet<NotificationService.Data.Models.CouponRestrictionType> CouponRestrictionType { get; set; }



        public DbSet<NotificationService.Data.Models.Customer> Customer { get; set; }
        public DbSet<NotificationService.Data.Models.CustomerType> CustomerType { get; set; }
        public DbSet<NotificationService.Data.Models.StrengthUnit> StrengthUnit { get; set; }
        public DbSet<NotificationService.Data.Models.DocumentUpload> DocumentUpload { get; set; }
        public DbSet<NotificationService.Data.Models.DocumentType> DocumentType { get; set; }
        public DbSet<NotificationService.Data.Models.Service> Services { get; set; }
        public DbSet<NotificationService.Data.Models.ServiceItem> ServiceItem { get; set; }
        public DbSet<NotificationService.Data.Models.PackSize> PackSize { get; set; }
        public DbSet<NotificationService.Data.Models.SalesOrderType> SalesOrderType { get; set; }

        public DbSet<NotificationService.Data.Models.PaymentMethod> PaymentMethod { get; set; }
        public DbSet<NotificationService.Data.Models.PurchaseOrderReturn> PurchaseOrderReturn { get; set; }
        public DbSet<NotificationService.Data.Models.PurchaseOrderReturnItem> PurchaseOrderReturnItem { get; set; }
        public DbSet<NotificationService.Data.Models.ReturnCondition> ReturnCondition { get; set; }
        public DbSet<NotificationService.Data.Models.ProductReview> ProductReview { get; set; }
        public DbSet<NotificationService.Data.Models.ProductReviewStatus> ProductReviewStatus { get; set; }
        public DbSet<NotificationService.Data.Models.UniversalInventoryLevel> UniversalInventoryLevel { get; set; }
        public DbSet<NotificationService.Data.Models.UniversalInventoryStock> UniversalInventoryStock { get; set; }



        /// <summary>
        /// 
        /// </summary>

        
        public DbSet<NotificationService.Data.Models.PrivacyPolicy> PrivacyPolicy { get; set; }
        public DbSet<NotificationService.Data.Models.TermsandCondition> TermsandConditions { get; set; }
        public DbSet<NotificationService.Data.Models.RefundPolicy> RefundPolicy { get; set; }
        public DbSet<NotificationService.Data.Models.BlogCategory> BlogCategory { get; set; }
        public DbSet<NotificationService.Data.Models.BlogPost> BlogPost { get; set; }
        public DbSet<NotificationService.Data.Models.BlogPostStatus> BlogPostStatus { get; set; }
        public DbSet<NotificationService.Data.Models.Tag> Tag { get; set; }

        public DbSet<NotificationService.Data.Models.BlogPostTag> BlogPostTag { get; set; }
        public DbSet<NotificationService.Data.Models.BlogPostComment> BlogPostComment { get; set; }
        public DbSet<NotificationService.Data.Models.BlogPostCommentStatus> BlogPostCommentStatus { get; set; }
        public DbSet<NotificationService.Data.Models.BlogPostImage> BlogPostImage { get; set; }



        /// <summary>
        /// 
        /// </summary>
        public DbSet<NotificationService.Data.Models.FaqCategory> FaqCategory { get; set; }
        public DbSet<NotificationService.Data.Models.FaqStatus> FaqStatus { get; set; }
        public DbSet<NotificationService.Data.Models.Faq> Faq { get; set; }
        public DbSet<NotificationService.Data.Models.NotificationType> NotificationType { get; set; }
        public DbSet<NotificationService.Data.Models.NotificationTypeExclusion> NotificationTypeExclusions { get; set; }
        public DbSet<NotificationService.Data.Models.Notification> Notification { get; set; }
        public DbSet<NotificationService.Data.Models.NotificationDeliveryStatus> NotificationDeliveryStatus { get; set; }
        public DbSet<NotificationService.Data.Models.SystemConfiguration> SystemConfiguration { get; set; }
        public DbSet<NotificationService.Data.Models.Testimonial> Testimonial { get; set; }
        public DbSet<NotificationService.Data.Models.TestimonialStatus> TestimonialStatus { get; set; }
        public DbSet<NotificationService.Data.Models.SupportRequestStatus> SupportRequestStatus { get; set; }
        public DbSet<NotificationService.Data.Models.SupportRequest> SupportRequest { get; set; }
        public DbSet<NotificationService.Data.Models.SupportRequestReview> SupportRequestReview { get; set; }
        public DbSet<NotificationService.Data.Models.OtpStatus> OtpStatus { get; set; }
        public DbSet<NotificationService.Data.Models.Otp> Otp { get; set; }
        public DbSet<NotificationService.Data.Models.AuditLog> AuditLog { get; set; }
        public DbSet<NotificationService.Data.Models.Bank> Bank { get; set; }
        public DbSet<NotificationService.Data.Models.Ingredient> Ingredient { get; set; }
        public DbSet<NotificationService.Data.Models.ProductIngredient> ProductIngredient { get; set; }
        public DbSet<NotificationService.Data.Models.ClientContent> ClientContent { get; set; }
        public DbSet<NotificationService.Data.Models.ClientContentStatus> ClientContentStatus { get; set; }
        public DbSet<NotificationService.Data.Models.ClientContentCategory> ClientContentCategory { get; set; }
        public DbSet<NotificationService.Data.Models.ClientAuthor> ClientAuthor { get; set; }
        public DbSet<NotificationService.Data.Models.InventoryStockTake> InventoryStockTake { get; set; }
        public DbSet<NotificationService.Data.Models.InventoryStockTakeType> InventoryStockTakeType { get; set; }
        public DbSet<NotificationService.Data.Models.InventoryStockTakeStatus> InventoryStockTakeStatus { get; set; }
        public DbSet<NotificationService.Data.Models.InventoryStockTakeItem> InventoryStockTakeItems { get; set; }
        public DbSet<NotificationService.Data.Models.FollowUp> FollowUp { get; set; }
        public DbSet<NotificationService.Data.Models.FollowUpType> FollowUpType { get; set; }
        public DbSet<NotificationService.Data.Models.LayAway> LayAway { get; set; }
        public DbSet<NotificationService.Data.Models.LayAwayStatus> LayAwayStatus { get; set; }
        public DbSet<NotificationService.Data.Models.SubscriptionTier> SubscriptionTier { get; set; }
        public DbSet<NotificationService.Data.Models.SubscriptionPayment> SubscriptionPayment { get; set; }
        public DbSet<NotificationService.Data.Models.AuthorizationKey> AuthorizationKey { get; set; }
        public DbSet<NotificationService.Data.Models.AuthorizationKeyStatus> AuthorizationKeyStatus { get; set; }
        public DbSet<NotificationService.Data.Models.SubscriptionTierFeature> SubscriptionTierFeature { get; set; }



    }
}
