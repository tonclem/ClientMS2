using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ahadevdbContext : DbContext
    {
        public ahadevdbContext()
        {
        }

        public ahadevdbContext(DbContextOptions<ahadevdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AuditActivityType> AuditActivityTypes { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<AuthorizationKey> AuthorizationKeys { get; set; }
        public virtual DbSet<AuthorizationKeyStatus> AuthorizationKeyStatuses { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BlogCategory> BlogCategories { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<BlogPostComment> BlogPostComments { get; set; }
        public virtual DbSet<BlogPostCommentStatus> BlogPostCommentStatuses { get; set; }
        public virtual DbSet<BlogPostImage> BlogPostImages { get; set; }
        public virtual DbSet<BlogPostStatus> BlogPostStatuses { get; set; }
        public virtual DbSet<BlogPostTag> BlogPostTags { get; set; }
        public virtual DbSet<Bundle> Bundles { get; set; }
        public virtual DbSet<BundleCategory> BundleCategories { get; set; }
        public virtual DbSet<BundleItem> BundleItems { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientAuthor> ClientAuthors { get; set; }
        public virtual DbSet<ClientContent> ClientContents { get; set; }
        public virtual DbSet<ClientContentCategory> ClientContentCategories { get; set; }
        public virtual DbSet<ClientContentStatus> ClientContentStatuses { get; set; }
        public virtual DbSet<ClientOutlet> ClientOutlets { get; set; }
        public virtual DbSet<ClientOutletRating> ClientOutletRatings { get; set; }
        public virtual DbSet<ClientOutletStatus> ClientOutletStatuses { get; set; }
        public virtual DbSet<ClientOutletType> ClientOutletTypes { get; set; }
        public virtual DbSet<ClientStatus> ClientStatuses { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<ClientUser> ClientUsers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CouponDiscountType> CouponDiscountTypes { get; set; }
        public virtual DbSet<CouponProductCategoryRestriction> CouponProductCategoryRestrictions { get; set; }
        public virtual DbSet<CouponProductRestriction> CouponProductRestrictions { get; set; }
        public virtual DbSet<CouponRestrictionType> CouponRestrictionTypes { get; set; }
        public virtual DbSet<CouponStatus> CouponStatuses { get; set; }
        public virtual DbSet<CurrentInventoryView> CurrentInventoryViews { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerShippingAddress> CustomerShippingAddresses { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<DocumentUpload> DocumentUploads { get; set; }
        public virtual DbSet<DosageForm> DosageForms { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<FaqCategory> FaqCategories { get; set; }
        public virtual DbSet<FaqStatus> FaqStatuses { get; set; }
        public virtual DbSet<FollowUp> FollowUps { get; set; }
        public virtual DbSet<FollowUpType> FollowUpTypes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<InventoryLevelType> InventoryLevelTypes { get; set; }
        public virtual DbSet<InventoryStockTake> InventoryStockTakes { get; set; }
        public virtual DbSet<InventoryStockTakeItem> InventoryStockTakeItems { get; set; }
        public virtual DbSet<InventoryStockTakeItemStatus> InventoryStockTakeItemStatuses { get; set; }
        public virtual DbSet<InventoryStockTakeStatus> InventoryStockTakeStatuses { get; set; }
        public virtual DbSet<InventoryStockTakeType> InventoryStockTakeTypes { get; set; }
        public virtual DbSet<LayAway> LayAways { get; set; }
        public virtual DbSet<LayAwayStatus> LayAwayStatuses { get; set; }
        public virtual DbSet<LocalGovernmentArea> LocalGovernmentAreas { get; set; }
        public virtual DbSet<LogisticsDeliveryOption> LogisticsDeliveryOptions { get; set; }
        public virtual DbSet<LogisticsDeliveryType> LogisticsDeliveryTypes { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<MyMedicineAnalytic> MyMedicineAnalytics { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationDeliveryStatus> NotificationDeliveryStatuses { get; set; }
        public virtual DbSet<NotificationType> NotificationTypes { get; set; }
        public virtual DbSet<NotificationTypeExclusion> NotificationTypeExclusions { get; set; }
        public virtual DbSet<OrderActivity> OrderActivities { get; set; }
        public virtual DbSet<OrderActivityType> OrderActivityTypes { get; set; }
        public virtual DbSet<OrderFulfilment> OrderFulfilments { get; set; }
        public virtual DbSet<OrderFulfilmentItem> OrderFulfilmentItems { get; set; }
        public virtual DbSet<OrderFulfilmentStatus> OrderFulfilmentStatuses { get; set; }
        public virtual DbSet<OrderFulfilmentTracker> OrderFulfilmentTrackers { get; set; }
        public virtual DbSet<OrderItemAction> OrderItemActions { get; set; }
        public virtual DbSet<OrderItemCondition> OrderItemConditions { get; set; }
        public virtual DbSet<OrderReturnStatus> OrderReturnStatuses { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Otp> Otps { get; set; }
        public virtual DbSet<OtpStatus> OtpStatuses { get; set; }
        public virtual DbSet<PackSize> PackSizes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PaymentProvider> PaymentProviders { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionStatus> PrescriptionStatuses { get; set; }
        public virtual DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductIngredient> ProductIngredients { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductReviewStatus> ProductReviewStatuses { get; set; }
        public virtual DbSet<ProductStatus> ProductStatuses { get; set; }
        public virtual DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public virtual DbSet<ProductView> ProductViews { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual DbSet<PurchaseOrderReturn> PurchaseOrderReturns { get; set; }
        public virtual DbSet<PurchaseOrderReturnItem> PurchaseOrderReturnItems { get; set; }
        public virtual DbSet<RefundPolicy> RefundPolicies { get; set; }
        public virtual DbSet<ReturnCondition> ReturnConditions { get; set; }
        public virtual DbSet<ReturnReason> ReturnReasons { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; }
        public virtual DbSet<SalesOrderReturn> SalesOrderReturns { get; set; }
        public virtual DbSet<SalesOrderReturnItem> SalesOrderReturnItems { get; set; }
        public virtual DbSet<SalesOrderType> SalesOrderTypes { get; set; }
        public virtual DbSet<SellAsUnit> SellAsUnits { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceItem> ServiceItems { get; set; }
        public virtual DbSet<ShoppingCartOrder> ShoppingCartOrders { get; set; }
        public virtual DbSet<ShoppingCartOrderItem> ShoppingCartOrderItems { get; set; }
        public virtual DbSet<ShoppingCartOrderStatus> ShoppingCartOrderStatuses { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StrengthUnit> StrengthUnits { get; set; }
        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }
        public virtual DbSet<SubscriptionTier> SubscriptionTiers { get; set; }
        public virtual DbSet<SubscriptionTierFeature> SubscriptionTierFeatures { get; set; }
        public virtual DbSet<SupportRequest> SupportRequests { get; set; }
        public virtual DbSet<SupportRequestReview> SupportRequestReviews { get; set; }
        public virtual DbSet<SupportRequestStatus> SupportRequestStatuses { get; set; }
        public virtual DbSet<SystemConfiguration> SystemConfigurations { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TermsandCondition> TermsandConditions { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<TestimonialStatus> TestimonialStatuses { get; set; }
        public virtual DbSet<UniversalInventoryLevel> UniversalInventoryLevels { get; set; }
        public virtual DbSet<UniversalInventoryStock> UniversalInventoryStocks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserStatus> UserStatuses { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
///#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=aha-dev-db;Integrated Security=True; MultipleActiveResultSets=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(200)
                    .HasColumnName("latitude");

                entity.Property(e => e.LocalGovtId).HasColumnName("localGovtId");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(200)
                    .HasColumnName("longitude");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("number");

                entity.Property(e => e.StateId).HasColumnName("stateId");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("street");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Country");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_User");

                entity.HasOne(d => d.LocalGovt)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.LocalGovtId)
                    .HasConstraintName("FK_Address_LocalGovernmentArea");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_State");
            });

            modelBuilder.Entity<AuditActivityType>(entity =>
            {
                entity.ToTable("AuditActivityType");

                entity.HasIndex(e => e.Name, "IX_AuditActivityType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("AuditLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasColumnName("activity");

                entity.Property(e => e.AuditActivityTypeId).HasColumnName("auditActivityTypeId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.AuditActivityType)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.AuditActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditLog_AuditActivityType");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditLog_Channel");
            });

            modelBuilder.Entity<AuthorizationKey>(entity =>
            {
                entity.ToTable("AuthorizationKey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorizationKeyStatus).HasColumnName("authorizationKeyStatus");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("key");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");
            });

            modelBuilder.Entity<AuthorizationKeyStatus>(entity =>
            {
                entity.ToTable("AuthorizationKeyStatus");

                entity.HasIndex(e => e.Name, "IX_AuthorizationKeyStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.HasIndex(e => e.Name, "IX_Bank_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(10)
                    .HasColumnName("bankCode");

                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.SortCode)
                    .HasMaxLength(50)
                    .HasColumnName("sortCode");
            });

            modelBuilder.Entity<BlogCategory>(entity =>
            {
                entity.ToTable("BlogCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DeletedByUserId).HasColumnName("deletedByUserId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.BlogCategoryCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogCategory_User");

                entity.HasOne(d => d.DeletedByUser)
                    .WithMany(p => p.BlogCategoryDeletedByUsers)
                    .HasForeignKey(d => d.DeletedByUserId)
                    .HasConstraintName("FK_BlogCategory_UserDeleting");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.BlogCategoryModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_BlogCategory_UserModifying");
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.ToTable("BlogPost");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("author");

                entity.Property(e => e.BlogCategoryId).HasColumnName("blogCategoryId");

                entity.Property(e => e.BlogPostStatusId).HasColumnName("blogPostStatusId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DatePublished).HasColumnName("datePublished");

                entity.Property(e => e.Highlight)
                    .IsRequired()
                    .HasColumnName("highlight");

                entity.Property(e => e.HtmlText)
                    .IsRequired()
                    .HasColumnName("htmlText");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.MainImageDocumentUploadId).HasColumnName("mainImageDocumentUploadId");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("title");

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.BlogPosts)
                    .HasForeignKey(d => d.BlogCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPost_BlogCategory");

                entity.HasOne(d => d.BlogPostStatus)
                    .WithMany(p => p.BlogPosts)
                    .HasForeignKey(d => d.BlogPostStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPost_BlogPostStatus");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.BlogPosts)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPost_User");
            });

            modelBuilder.Entity<BlogPostComment>(entity =>
            {
                entity.ToTable("BlogPostComment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");

                entity.Property(e => e.BlogPostCommentStatusId).HasColumnName("blogPostCommentStatusId");

                entity.Property(e => e.BlogPostId).HasColumnName("blogPostId");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Commenter)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("commenter");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateApproved).HasColumnName("dateApproved");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.HasOne(d => d.BlogPostCommentStatus)
                    .WithMany(p => p.BlogPostComments)
                    .HasForeignKey(d => d.BlogPostCommentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostComment_BlogPostCommentStatus");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostComments)
                    .HasForeignKey(d => d.BlogPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostComment_BlogPost");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.BlogPostComments)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_BlogPostComment_User");
            });

            modelBuilder.Entity<BlogPostCommentStatus>(entity =>
            {
                entity.ToTable("BlogPostCommentStatus");

                entity.HasIndex(e => e.Name, "IX_BlogPostCommentStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BlogPostImage>(entity =>
            {
                entity.ToTable("BlogPostImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BlogPostId).HasColumnName("blogPostId");

                entity.Property(e => e.DocumentUploadId).HasColumnName("documentUploadId");

                entity.Property(e => e.PlaceHolder)
                    .IsRequired()
                    .HasColumnName("placeHolder");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostImages)
                    .HasForeignKey(d => d.BlogPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostImage_BlogPost");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.BlogPostImages)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostImage_DocumentUpload");
            });

            modelBuilder.Entity<BlogPostStatus>(entity =>
            {
                entity.ToTable("BlogPostStatus");

                entity.HasIndex(e => e.Name, "IX_BlogPostStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BlogPostTag>(entity =>
            {
                entity.ToTable("BlogPostTag");

                entity.HasIndex(e => new { e.BlogPostId, e.TagId }, "IX_BlogPostTag_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BlogPostId).HasColumnName("blogPostId");

                entity.Property(e => e.TagId).HasColumnName("tagId");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostTags)
                    .HasForeignKey(d => d.BlogPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostTag_BlogPost");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.BlogPostTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostTag_Tag");
            });

            modelBuilder.Entity<Bundle>(entity =>
            {
                entity.ToTable("Bundle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BundleCategoryId).HasColumnName("bundleCategoryId");

                entity.Property(e => e.ClientOutletId).HasColumnName("clientOutletId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.CurrentCost)
                    .HasColumnType("money")
                    .HasColumnName("currentCost");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DeletedByUserId).HasColumnName("deletedByUserId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DocumentUploadId).HasColumnName("documentUploadId");

                entity.Property(e => e.Highlight)
                    .IsRequired()
                    .HasColumnName("highlight");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.HasOne(d => d.BundleCategory)
                    .WithMany(p => p.Bundles)
                    .HasForeignKey(d => d.BundleCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bundle_BundleCategory");

                entity.HasOne(d => d.ClientOutlet)
                    .WithMany(p => p.Bundles)
                    .HasForeignKey(d => d.ClientOutletId)
                    .HasConstraintName("FK_Bundle_ClientOutlet");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.BundleCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bundle_User");

                entity.HasOne(d => d.DeletedByUser)
                    .WithMany(p => p.BundleDeletedByUsers)
                    .HasForeignKey(d => d.DeletedByUserId)
                    .HasConstraintName("FK_Bundle_UserDeleting");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.Bundles)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bundle_DocumentUpload");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.BundleModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_Bundle_UserModifying");
            });

            modelBuilder.Entity<BundleCategory>(entity =>
            {
                entity.ToTable("BundleCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DeletedByUserId).HasColumnName("deletedByUserId");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.DocumentUploadId).HasColumnName("documentUploadId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.BundleCategoryCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BundleCategory_User");

                entity.HasOne(d => d.DeletedByUser)
                    .WithMany(p => p.BundleCategoryDeletedByUsers)
                    .HasForeignKey(d => d.DeletedByUserId)
                    .HasConstraintName("FK_BundleCategory_UserDeleting");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.BundleCategories)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BundleCategory_DocumentUpload");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.BundleCategoryModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_BundleCategory_UserModifing");
            });

            modelBuilder.Entity<BundleItem>(entity =>
            {
                entity.ToTable("BundleItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BundleId).HasColumnName("bundleId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.PackSizeId).HasColumnName("packSizeId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Bundle)
                    .WithMany(p => p.BundleItems)
                    .HasForeignKey(d => d.BundleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BundleItem_Bundle");

                entity.HasOne(d => d.PackSize)
                    .WithMany(p => p.BundleItems)
                    .HasForeignKey(d => d.PackSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BundleItem_PackSize");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BundleItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BundleItem_Product");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("Channel");

                entity.HasIndex(e => e.Name, "IX_Channel")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalDate).HasColumnName("approvalDate");

                entity.Property(e => e.ApprovalUserId).HasColumnName("approvalUserId");

                entity.Property(e => e.AuthorizationKeyId).HasColumnName("authorizationKeyId");

                entity.Property(e => e.BusinessLicenseDocumentUploadId).HasColumnName("businessLicenseDocumentUploadId");

                entity.Property(e => e.BusinessLicenseNumber)
                    .HasMaxLength(200)
                    .HasColumnName("businessLicenseNumber");

                entity.Property(e => e.ClientStatusId).HasColumnName("clientStatusId");

                entity.Property(e => e.ClientTypeId).HasColumnName("clientTypeId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsWithinAhanetwork).HasColumnName("isWithinAHANetwork");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.SubscriptionTierId).HasColumnName("subscriptionTierId");

                entity.HasOne(d => d.AuthorizationKey)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.AuthorizationKeyId)
                    .HasConstraintName("FK_Client_AuthorizationKey");

                entity.HasOne(d => d.BusinessLicenseDocumentUpload)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.BusinessLicenseDocumentUploadId)
                    .HasConstraintName("FK_Client_DocumentUpload");

                entity.HasOne(d => d.ClientStatus)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClientStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_ClientStatus");

                entity.HasOne(d => d.ClientType)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClientTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_ClientType");

                entity.HasOne(d => d.SubscriptionTier)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.SubscriptionTierId)
                    .HasConstraintName("FK_Client_SubscriptionTier");
            });

            modelBuilder.Entity<ClientAuthor>(entity =>
            {
                entity.ToTable("ClientAuthor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientAuthors)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientAuthor_Client");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.ClientAuthors)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientAuthor_User");
            });

            modelBuilder.Entity<ClientContent>(entity =>
            {
                entity.ToTable("ClientContent");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body");

                entity.Property(e => e.ClientAuthorId).HasColumnName("clientAuthorId");

                entity.Property(e => e.ClientContentCategoryId).HasColumnName("clientContentCategoryId");

                entity.Property(e => e.ClientContentStatusId).HasColumnName("clientContentStatusId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DatePublished).HasColumnName("datePublished");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("title");

                entity.HasOne(d => d.ClientAuthor)
                    .WithMany(p => p.ClientContents)
                    .HasForeignKey(d => d.ClientAuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientContent_ClientAuthor");

                entity.HasOne(d => d.ClientContentCategory)
                    .WithMany(p => p.ClientContents)
                    .HasForeignKey(d => d.ClientContentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientContent_ClientContentCategory");

                entity.HasOne(d => d.ClientContentStatus)
                    .WithMany(p => p.ClientContents)
                    .HasForeignKey(d => d.ClientContentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientContent_ClientContentStatus");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientContents)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientContent_Client");
            });

            modelBuilder.Entity<ClientContentCategory>(entity =>
            {
                entity.ToTable("ClientContentCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ClientContentStatus>(entity =>
            {
                entity.ToTable("ClientContentStatus");

                entity.HasIndex(e => e.Name, "IX_ClientContentStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ClientOutlet>(entity =>
            {
                entity.ToTable("ClientOutlet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(50)
                    .HasColumnName("bankAccountName");

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(20)
                    .HasColumnName("bankAccountNumber");

                entity.Property(e => e.BankId).HasColumnName("bankId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.ClientOutletStatusId).HasColumnName("clientOutletStatusId");

                entity.Property(e => e.ClientOutletTypeId).HasColumnName("clientOutletTypeId");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .HasColumnName("contactPerson");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(100)
                    .HasColumnName("contactPersonEmail");

                entity.Property(e => e.ContactPersonGender)
                    .HasMaxLength(50)
                    .HasColumnName("contactPersonGender");

                entity.Property(e => e.ContactPersonPhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("contactPersonPhoneNumber");

                entity.Property(e => e.ContactPersonTitle)
                    .HasMaxLength(100)
                    .HasColumnName("contactPersonTitle");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.SubscribedToPromotions).HasColumnName("subscribedToPromotions");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ClientOutlets)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ClientOutlet_Address");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.ClientOutlets)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_ClientOutlet_Bank");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientOutlets)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientOutlet_Client");

                entity.HasOne(d => d.ClientOutletStatus)
                    .WithMany(p => p.ClientOutlets)
                    .HasForeignKey(d => d.ClientOutletStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientOutlet_ClientOutletStatus");

                entity.HasOne(d => d.ClientOutletType)
                    .WithMany(p => p.ClientOutlets)
                    .HasForeignKey(d => d.ClientOutletTypeId)
                    .HasConstraintName("FK_ClientOutlet_ClientOutletType");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.ClientOutlets)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_ClientOutlet_User");
            });

            modelBuilder.Entity<ClientOutletRating>(entity =>
            {
                entity.ToTable("ClientOutletRating");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientOutletId).HasColumnName("clientOutletId");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1000)
                    .HasColumnName("comments");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.NumberOfStars).HasColumnName("numberOfStars");

                entity.Property(e => e.RaterUserId).HasColumnName("raterUserId");

                entity.HasOne(d => d.ClientOutlet)
                    .WithMany(p => p.ClientOutletRatings)
                    .HasForeignKey(d => d.ClientOutletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientOutletRating_ClientOutlet");

                entity.HasOne(d => d.RaterUser)
                    .WithMany(p => p.ClientOutletRatings)
                    .HasForeignKey(d => d.RaterUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientOutletRating_User");
            });

            modelBuilder.Entity<ClientOutletStatus>(entity =>
            {
                entity.ToTable("ClientOutletStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ClientOutletType>(entity =>
            {
                entity.ToTable("ClientOutletType");

                entity.HasIndex(e => e.Name, "IX_ClientOutletType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ClientStatus>(entity =>
            {
                entity.ToTable("ClientStatus");

                entity.HasIndex(e => e.Name, "IX_ClientStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.ToTable("ClientType");

                entity.HasIndex(e => e.Name, "IX_ClientType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ClientUser>(entity =>
            {
                entity.ToTable("ClientUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientOutletId).HasColumnName("clientOutletId");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.ClientOutlet)
                    .WithMany(p => p.ClientUsers)
                    .HasForeignKey(d => d.ClientOutletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientUser_ClientOutlet");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClientUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientUser_User");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.HasIndex(e => e.Name, "IX_Country_Unique_Countries")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("countryCode");

                entity.Property(e => e.DialingCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dialingCode");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("couponCode");

                entity.Property(e => e.CouponDiscountTypeId).HasColumnName("couponDiscountTypeId");

                entity.Property(e => e.CouponStatusId).HasColumnName("couponStatusId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateExpiry).HasColumnName("dateExpiry");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DeletedByUserId).HasColumnName("deletedByUserId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaximumItems).HasColumnName("maximumItems");

                entity.Property(e => e.MaximumSpend).HasColumnName("maximumSpend");

                entity.Property(e => e.MaximumUsePerUser).HasColumnName("maximumUsePerUser");

                entity.Property(e => e.MaximumUses).HasColumnName("maximumUses");

                entity.Property(e => e.MinimumSpend).HasColumnName("minimumSpend");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.CouponDiscountType)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.CouponDiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupon_CouponDiscountType");

                entity.HasOne(d => d.CouponStatus)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.CouponStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupon_CouponStatus");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.CouponCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupon_User");

                entity.HasOne(d => d.DeletedByUser)
                    .WithMany(p => p.CouponDeletedByUsers)
                    .HasForeignKey(d => d.DeletedByUserId)
                    .HasConstraintName("FK_Coupon_UserDeleting");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.CouponModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_Coupon_UserModifying");
            });

            modelBuilder.Entity<CouponDiscountType>(entity =>
            {
                entity.ToTable("CouponDiscountType");

                entity.HasIndex(e => e.Name, "IX_CouponDiscountType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CouponProductCategoryRestriction>(entity =>
            {
                entity.ToTable("CouponProductCategoryRestriction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CouponId).HasColumnName("couponId");

                entity.Property(e => e.CouponRestrictionTypeId).HasColumnName("couponRestrictionTypeId");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ProductCategoryId).HasColumnName("productCategoryId");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponProductCategoryRestrictions)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponProductCategoryRestriction_Coupon");

                entity.HasOne(d => d.CouponRestrictionType)
                    .WithMany(p => p.CouponProductCategoryRestrictions)
                    .HasForeignKey(d => d.CouponRestrictionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponProductCategoryRestriction_CouponRestrictionType");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.CouponProductCategoryRestrictions)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponProductCategoryRestriction_ProductCategory");
            });

            modelBuilder.Entity<CouponProductRestriction>(entity =>
            {
                entity.ToTable("CouponProductRestriction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CouponId).HasColumnName("couponId");

                entity.Property(e => e.CouponRestrictionTypeId).HasColumnName("couponRestrictionTypeId");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponProductRestrictions)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponProductRestriction_Coupon");

                entity.HasOne(d => d.CouponRestrictionType)
                    .WithMany(p => p.CouponProductRestrictions)
                    .HasForeignKey(d => d.CouponRestrictionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponProductRestriction_CouponRestrictionType");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CouponProductRestrictions)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponProductRestriction_Product");
            });

            modelBuilder.Entity<CouponRestrictionType>(entity =>
            {
                entity.ToTable("CouponRestrictionType");

                entity.HasIndex(e => e.Name, "IX_CouponRestrictionType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CouponStatus>(entity =>
            {
                entity.ToTable("CouponStatus");

                entity.HasIndex(e => e.Name, "IX_CouponStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CurrentInventoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CurrentInventoryView");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("clientName");

                entity.Property(e => e.ClientStatusId).HasColumnName("clientStatusId");

                entity.Property(e => e.ClientStatusName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("clientStatusName");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivateReward)
                    .HasMaxLength(50)
                    .HasColumnName("activateReward");

                entity.Property(e => e.Birthday).HasColumnName("birthday");

                entity.Property(e => e.BloodType)
                    .HasMaxLength(50)
                    .HasColumnName("bloodType");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.ClientOutletId).HasColumnName("clientOutletId");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("companyName");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.CustomerTypeId).HasColumnName("customerTypeId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.HeightMetres).HasColumnName("heightMetres");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("lastname");

                entity.Property(e => e.Middlename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("middlename");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.PurchaseLimit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("purchaseLimit");

                entity.Property(e => e.SendBirthdayEmail).HasColumnName("sendBirthdayEmail");

                entity.Property(e => e.SendPromoDetails).HasColumnName("sendPromoDetails");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.WeightKg).HasColumnName("weightKg");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Customer_Client");

                entity.HasOne(d => d.ClientOutlet)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ClientOutletId)
                    .HasConstraintName("FK_Customer_ClientOutlet");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_CustomerType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Customer_User");
            });

            modelBuilder.Entity<CustomerShippingAddress>(entity =>
            {
                entity.ToTable("CustomerShippingAddress");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerShippingAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerShippingAddress_Address");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerShippingAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerShippingAddress_Customer");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("CustomerType");

                entity.HasIndex(e => e.Name, "IX_CustomerType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType");

                entity.HasIndex(e => e.Name, "IX_DocumentType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DocumentUpload>(entity =>
            {
                entity.ToTable("DocumentUpload");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CloudPath)
                    .IsRequired()
                    .HasColumnName("cloudPath");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DocumentTypeId).HasColumnName("documentTypeId");

                entity.Property(e => e.LocalPath)
                    .IsRequired()
                    .HasColumnName("localPath");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasColumnName("title");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.DocumentUploads)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentUpload_User");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.DocumentUploads)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentUpload_DocumentType");
            });

            modelBuilder.Entity<DosageForm>(entity =>
            {
                entity.ToTable("DosageForm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedUserId).HasColumnName("modifiedUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.DosageFormCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DosageForm_User_Creator");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.DosageFormModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK_DosageForm_User_Modifier");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("Faq");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnName("answer");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.FaqCategoryId).HasColumnName("faqCategoryId");

                entity.Property(e => e.FaqStatusId).HasColumnName("faqStatusId");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question");

                entity.HasOne(d => d.FaqCategory)
                    .WithMany(p => p.Faqs)
                    .HasForeignKey(d => d.FaqCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Faq_FaqCategory");

                entity.HasOne(d => d.FaqStatus)
                    .WithMany(p => p.Faqs)
                    .HasForeignKey(d => d.FaqStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Faq_FaqStatus");
            });

            modelBuilder.Entity<FaqCategory>(entity =>
            {
                entity.ToTable("FaqCategory");

                entity.HasIndex(e => e.Name, "IX_FaqCategory_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FaqStatus>(entity =>
            {
                entity.ToTable("FaqStatus");

                entity.HasIndex(e => e.Name, "IX_FaqStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FollowUp>(entity =>
            {
                entity.ToTable("FollowUp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BloodPressure)
                    .HasMaxLength(500)
                    .HasColumnName("bloodPressure");

                entity.Property(e => e.Bmi).HasColumnName("bmi");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.DateFollowUp).HasColumnName("dateFollowUp");

                entity.Property(e => e.FollowUpTypeId).HasColumnName("followUpTypeId");

                entity.Property(e => e.HeartRate).HasColumnName("heartRate");

                entity.Property(e => e.Respiration).HasColumnName("respiration");

                entity.Property(e => e.SalesOderId).HasColumnName("salesOderId");

                entity.Property(e => e.TemperatureCelcius).HasColumnName("temperatureCelcius");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("title");

                entity.HasOne(d => d.FollowUpType)
                    .WithMany(p => p.FollowUps)
                    .HasForeignKey(d => d.FollowUpTypeId)
                    .HasConstraintName("FK_FollowUp_FollowUpType");
            });

            modelBuilder.Entity<FollowUpType>(entity =>
            {
                entity.ToTable("FollowUpType");

                entity.HasIndex(e => e.Name, "IX_FollowUpType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient");

                entity.HasIndex(e => e.Name, "IX_Ingredient_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<InventoryLevelType>(entity =>
            {
                entity.ToTable("InventoryLevelType");

                entity.HasIndex(e => e.Name, "IX_InventoryLevelType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<InventoryStockTake>(entity =>
            {
                entity.ToTable("InventoryStockTake");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientOutletId).HasColumnName("clientOutletId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.InventoryStockTakeStatusId).HasColumnName("inventoryStockTakeStatusId");

                entity.Property(e => e.InventoryStockTakeTypeId).HasColumnName("inventoryStockTakeTypeId");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.HasOne(d => d.ClientOutlet)
                    .WithMany(p => p.InventoryStockTakes)
                    .HasForeignKey(d => d.ClientOutletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryStockTake_ClientOutlet");

                entity.HasOne(d => d.InventoryStockTakeStatus)
                    .WithMany(p => p.InventoryStockTakes)
                    .HasForeignKey(d => d.InventoryStockTakeStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryStockTake_InventoryStockTakeStatus");

                entity.HasOne(d => d.InventoryStockTakeType)
                    .WithMany(p => p.InventoryStockTakes)
                    .HasForeignKey(d => d.InventoryStockTakeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryStockTake_InventoryStockTakeType");
            });

            modelBuilder.Entity<InventoryStockTakeItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualQuantity).HasColumnName("actualQuantity");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ExpectedQuantity).HasColumnName("expectedQuantity");

                entity.Property(e => e.InventoryStockTakeId).HasColumnName("inventoryStockTakeId");

                entity.Property(e => e.InventoryStockTakeItemStatusId).HasColumnName("inventoryStockTakeItemStatusId");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.UniversalInventoryStockId).HasColumnName("universalInventoryStockId");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InventoryStockTakeItemCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryStockTakeItems_User");

                entity.HasOne(d => d.InventoryStockTake)
                    .WithMany(p => p.InventoryStockTakeItems)
                    .HasForeignKey(d => d.InventoryStockTakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryStockTakeItems_InventoryStockTake");

                entity.HasOne(d => d.InventoryStockTakeItemStatus)
                    .WithMany(p => p.InventoryStockTakeItems)
                    .HasForeignKey(d => d.InventoryStockTakeItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryStockTakeItems_InventoryStockTakeItemStatus");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.InventoryStockTakeItemModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_InventoryStockTakeItems_UserModifying");

                entity.HasOne(d => d.UniversalInventoryStock)
                    .WithMany(p => p.InventoryStockTakeItems)
                    .HasForeignKey(d => d.UniversalInventoryStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryStockTakeItems_UniversalInventoryStock");
            });

            modelBuilder.Entity<InventoryStockTakeItemStatus>(entity =>
            {
                entity.ToTable("InventoryStockTakeItemStatus");

                entity.HasIndex(e => e.Name, "IX_InventoryStockTakeItemStatus")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<InventoryStockTakeStatus>(entity =>
            {
                entity.ToTable("InventoryStockTakeStatus");

                entity.HasIndex(e => e.Name, "IX_InventoryStockTakeStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<InventoryStockTakeType>(entity =>
            {
                entity.ToTable("InventoryStockTakeType");

                entity.HasIndex(e => e.Name, "IX_InventoryStockTakeType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LayAway>(entity =>
            {
                entity.ToTable("LayAway");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateEnd).HasColumnName("dateEnd");

                entity.Property(e => e.DateStart).HasColumnName("dateStart");

                entity.Property(e => e.LayAwayStatusId).HasColumnName("layAwayStatusId");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.HasOne(d => d.LayAwayStatus)
                    .WithMany(p => p.LayAways)
                    .HasForeignKey(d => d.LayAwayStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayAway_LayAwayStatus");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.LayAways)
                    .HasForeignKey(d => d.SalesOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayAway_SalesOrder");
            });

            modelBuilder.Entity<LayAwayStatus>(entity =>
            {
                entity.ToTable("LayAwayStatus");

                entity.HasIndex(e => e.Name, "IX_LayAwayStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LocalGovernmentArea>(entity =>
            {
                entity.ToTable("LocalGovernmentArea");

                entity.HasIndex(e => new { e.StateId, e.Name }, "IX_LocalGovernmentArea_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(200)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(200)
                    .HasColumnName("longitude");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.StateId).HasColumnName("stateId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.LocalGovernmentAreas)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocalGovernmentArea_State");
            });

            modelBuilder.Entity<LogisticsDeliveryOption>(entity =>
            {
                entity.ToTable("LogisticsDeliveryOption");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Fee)
                    .HasColumnType("money")
                    .HasColumnName("fee");

                entity.Property(e => e.LgaId).HasColumnName("lgaId");

                entity.Property(e => e.LogisticDeliveryTypeId).HasColumnName("logisticDeliveryTypeId");

                entity.Property(e => e.MaxDuration).HasColumnName("maxDuration");

                entity.Property(e => e.MinDuration).HasColumnName("minDuration");

                entity.Property(e => e.StateId).HasColumnName("stateId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LogisticsDeliveryOptions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogisticsDeliveryOption_Client");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.LogisticsDeliveryOptions)
                    .HasForeignKey(d => d.LgaId)
                    .HasConstraintName("FK_LogisticsDeliveryOption_LocalGovernmentArea");

                entity.HasOne(d => d.LogisticDeliveryType)
                    .WithMany(p => p.LogisticsDeliveryOptions)
                    .HasForeignKey(d => d.LogisticDeliveryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogisticsDeliveryOption_LogisticsDeliveryType");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.LogisticsDeliveryOptions)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogisticsDeliveryOption_State");
            });

            modelBuilder.Entity<LogisticsDeliveryType>(entity =>
            {
                entity.ToTable("LogisticsDeliveryType");

                entity.HasIndex(e => e.Name, "IX_LogisticsDeliveryType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<MyMedicineAnalytic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageEngagementTime)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("averageEngagementTime");

                entity.Property(e => e.BounceRate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("bounceRate");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.NumberOfActiveUsers).HasColumnName("numberOfActiveUsers");

                entity.Property(e => e.NumberOfNewUsers).HasColumnName("numberOfNewUsers");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.NotificationDeliveryStatusId).HasColumnName("notificationDeliveryStatusId");

                entity.Property(e => e.NotificationTypeId).HasColumnName("notificationTypeId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Sender)
                    .HasMaxLength(100)
                    .HasColumnName("sender");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.NotificationDeliveryStatus)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationDeliveryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_NotificationDeliveryStatus");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_NotificationType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<NotificationDeliveryStatus>(entity =>
            {
                entity.ToTable("NotificationDeliveryStatus");

                entity.HasIndex(e => e.Name, "IX_NotificationDeliveryStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.ToTable("NotificationType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailTemplateId)
                    .HasMaxLength(200)
                    .HasColumnName("emailTemplateId");

                entity.Property(e => e.InAppNotificationBodyTemplate).HasColumnName("inAppNotificationBodyTemplate");

                entity.Property(e => e.IsCompulsory).HasColumnName("isCompulsory");

                entity.Property(e => e.IsEmailNotification).HasColumnName("isEmailNotification");

                entity.Property(e => e.IsInAppNotification).HasColumnName("isInAppNotification");

                entity.Property(e => e.IsSmsnotification).HasColumnName("isSMSNotification");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.SmsBodyTemplate).HasColumnName("smsBodyTemplate");
            });

            modelBuilder.Entity<NotificationTypeExclusion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.NotificationTypeId).HasColumnName("notificationTypeId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.NotificationTypeExclusions)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationTypeExclusions_Customer");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.NotificationTypeExclusions)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationTypeExclusions_NotificationType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationTypeExclusions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationTypeExclusions_User");
            });

            modelBuilder.Entity<OrderActivity>(entity =>
            {
                entity.ToTable("OrderActivity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.OrderActivityTypeId).HasColumnName("orderActivityTypeId");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.OrderActivityType)
                    .WithMany(p => p.OrderActivities)
                    .HasForeignKey(d => d.OrderActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderActivity_OrderActivityType");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.OrderActivities)
                    .HasForeignKey(d => d.SalesOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderActivity_SalesOrder");
            });

            modelBuilder.Entity<OrderActivityType>(entity =>
            {
                entity.ToTable("OrderActivityType");

                entity.HasIndex(e => e.Name, "IX_OrderActivityType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OrderFulfilment>(entity =>
            {
                entity.ToTable("OrderFulfilment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientOutletId).HasColumnName("clientOutletId");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("comments");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDelivered).HasColumnName("dateDelivered");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.OrderFulfilmentStatusId).HasColumnName("orderFulfilmentStatusId");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .HasColumnName("trackingNumber");

                entity.HasOne(d => d.ClientOutlet)
                    .WithMany(p => p.OrderFulfilments)
                    .HasForeignKey(d => d.ClientOutletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFulfilment_ClientOutlet");

                entity.HasOne(d => d.OrderFulfilmentStatus)
                    .WithMany(p => p.OrderFulfilments)
                    .HasForeignKey(d => d.OrderFulfilmentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFulfilment_OrderFulfilmentStatus");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.OrderFulfilments)
                    .HasForeignKey(d => d.SalesOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFulfilment_SalesOrder");
            });

            modelBuilder.Entity<OrderFulfilmentItem>(entity =>
            {
                entity.ToTable("OrderFulfilmentItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderFulfilmentId).HasColumnName("orderFulfilmentId");

                entity.Property(e => e.SalesOrderItemId).HasColumnName("salesOrderItemId");

                entity.HasOne(d => d.OrderFulfilment)
                    .WithMany(p => p.OrderFulfilmentItems)
                    .HasForeignKey(d => d.OrderFulfilmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFulfilmentItem_OrderFulfilment");

                entity.HasOne(d => d.SalesOrderItem)
                    .WithMany(p => p.OrderFulfilmentItems)
                    .HasForeignKey(d => d.SalesOrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFulfilmentItem_SalesOrderItem");
            });

            modelBuilder.Entity<OrderFulfilmentStatus>(entity =>
            {
                entity.ToTable("OrderFulfilmentStatus");

                entity.HasIndex(e => e.Name, "IX_OrderFulfilmentStatus_UniqueKeyConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OrderFulfilmentTracker>(entity =>
            {
                entity.ToTable("OrderFulfilmentTracker");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.OrderFulfilmentId).HasColumnName("orderFulfilmentId");

                entity.Property(e => e.OrderFulfilmentStatusId).HasColumnName("orderFulfilmentStatusId");

                entity.HasOne(d => d.OrderFulfilment)
                    .WithMany(p => p.OrderFulfilmentTrackers)
                    .HasForeignKey(d => d.OrderFulfilmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFulfilmentTracker_OrderFulfilment");

                entity.HasOne(d => d.OrderFulfilmentStatus)
                    .WithMany(p => p.OrderFulfilmentTrackers)
                    .HasForeignKey(d => d.OrderFulfilmentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFulfilmentTracker_OrderFulfilmentStatus");
            });

            modelBuilder.Entity<OrderItemAction>(entity =>
            {
                entity.ToTable("OrderItemAction");

                entity.HasIndex(e => e.Name, "IX_OrderItemAction")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OrderItemCondition>(entity =>
            {
                entity.ToTable("OrderItemCondition");

                entity.HasIndex(e => e.Name, "IX_OrderItemCondition_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OrderReturnStatus>(entity =>
            {
                entity.ToTable("OrderReturnStatus");

                entity.HasIndex(e => e.Name, "IX_OrderReturnStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.HasIndex(e => e.Name, "IX_OrderStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Otp>(entity =>
            {
                entity.ToTable("Otp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateExpiry).HasColumnName("dateExpiry");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.OtpStatusId).HasColumnName("otpStatusId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.ReferenceId).HasColumnName("referenceId");

                entity.Property(e => e.ValidationAttempts).HasColumnName("validationAttempts");

                entity.HasOne(d => d.OtpStatus)
                    .WithMany(p => p.Otps)
                    .HasForeignKey(d => d.OtpStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Otp_OtpStatus");
            });

            modelBuilder.Entity<OtpStatus>(entity =>
            {
                entity.ToTable("OtpStatus");

                entity.HasIndex(e => e.Name, "IX_OtpStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PackSize>(entity =>
            {
                entity.ToTable("PackSize");

                entity.HasIndex(e => e.Name, "IX_PackSize_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.DateApproved).HasColumnName("dateApproved");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.Fees)
                    .HasColumnType("money")
                    .HasColumnName("fees");

                entity.Property(e => e.LayawayId).HasColumnName("layawayId");

                entity.Property(e => e.PaymentMethodId).HasColumnName("paymentMethodId");

                entity.Property(e => e.PaymentStatusId).HasColumnName("paymentStatusId");

                entity.Property(e => e.PaymentTypeId).HasColumnName("paymentTypeId");

                entity.Property(e => e.Reference)
                    .HasMaxLength(200)
                    .HasColumnName("reference");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Channel");

                entity.HasOne(d => d.Layaway)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.LayawayId)
                    .HasConstraintName("FK_Payment_LayAway");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_PaymentMethod");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_PaymentStatus");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_PaymentType");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.SalesOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_SalesOrder");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod");

                entity.HasIndex(e => e.Name, "IX_PaymentMethod_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PaymentProvider>(entity =>
            {
                entity.ToTable("PaymentProvider");

                entity.HasIndex(e => e.Name, "IX_PaymentProvider_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.ToTable("PaymentStatus");

                entity.HasIndex(e => e.Name, "IX_PaymentStatus")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.HasIndex(e => e.Name, "IX_PaymentType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.ToTable("Prescription");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DocumentUploadId).HasColumnName("documentUploadId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.PrescriptionStatusId).HasColumnName("prescriptionStatusId");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prescription_DocumentUpload");

                entity.HasOne(d => d.PrescriptionStatus)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.PrescriptionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prescription_PrescriptionStatus");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.SalesOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prescription_SalesOrder");
            });

            modelBuilder.Entity<PrescriptionStatus>(entity =>
            {
                entity.ToTable("PrescriptionStatus");

                entity.HasIndex(e => e.Name, "IX_PrescriptionStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PrivacyPolicy>(entity =>
            {
                entity.ToTable("PrivacyPolicy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.HtmlText).HasColumnName("htmlText");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalComment)
                    .HasMaxLength(500)
                    .HasColumnName("approvalComment");

                entity.Property(e => e.ApprovalDate).HasColumnName("approvalDate");

                entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");

                entity.Property(e => e.BarCodeNumber)
                    .HasMaxLength(200)
                    .HasColumnName("barCodeNumber");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("brandName");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DocumentUploadId).HasColumnName("documentUploadId");

                entity.Property(e => e.DosageFormId).HasColumnName("dosageFormId");

                entity.Property(e => e.GenericName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("genericName");

                entity.Property(e => e.Highlight)
                    .IsRequired()
                    .HasColumnName("highlight");

                entity.Property(e => e.HowToUse).HasColumnName("howToUse");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturerId");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfSachetsPerPack).HasColumnName("numberOfSachetsPerPack");

                entity.Property(e => e.Precautions).HasColumnName("precautions");

                entity.Property(e => e.ProductStatusId).HasColumnName("productStatusId");

                entity.Property(e => e.ProductSubCategoryId).HasColumnName("productSubCategoryId");

                entity.Property(e => e.RequiresPrescription).HasColumnName("requiresPrescription");

                entity.Property(e => e.SideEffects).HasColumnName("sideEffects");

                entity.Property(e => e.Storage).HasColumnName("storage");

                entity.Property(e => e.Strength).HasColumnName("strength");

                entity.Property(e => e.StrengthUnitId).HasColumnName("strengthUnitId");

                entity.Property(e => e.UniversalProductCode)
                    .HasMaxLength(50)
                    .HasColumnName("universalProductCode");

                entity.Property(e => e.Warning).HasColumnName("warning");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_User");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_DocumentUpload");

                entity.HasOne(d => d.DosageForm)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DosageFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_DosageForm");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Manufacturer");

                entity.HasOne(d => d.ProductStatus)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductStatus");

                entity.HasOne(d => d.ProductSubCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductSubCategory");

                entity.HasOne(d => d.StrengthUnit)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StrengthUnitId)
                    .HasConstraintName("FK_Product_StrengthUnit");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ProductIngredient>(entity =>
            {
                entity.ToTable("ProductIngredient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IngredientId).HasColumnName("ingredientId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Strength).HasColumnName("strength");

                entity.Property(e => e.StrengthUnitId).HasColumnName("strengthUnitId");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.ProductIngredients)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductIngredient_Ingredient");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductIngredients)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductIngredient_Product");

                entity.HasOne(d => d.StrengthUnit)
                    .WithMany(p => p.ProductIngredients)
                    .HasForeignKey(d => d.StrengthUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductIngredient_StrengthUnit");
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.ToTable("ProductReview");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproverId).HasColumnName("approverId");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateApproved).HasColumnName("dateApproved");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ProductReviewStatusId).HasColumnName("productReviewStatusId");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductReview_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductReview_Product");

                entity.HasOne(d => d.ProductReviewStatus)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductReviewStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductReview_ProductReviewStatus");
            });

            modelBuilder.Entity<ProductReviewStatus>(entity =>
            {
                entity.ToTable("ProductReviewStatus");

                entity.HasIndex(e => e.Name, "IX_ProductReviewStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ProductStatus>(entity =>
            {
                entity.ToTable("ProductStatus");

                entity.HasIndex(e => e.Name, "IX_ProductStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ProductSubCategory>(entity =>
            {
                entity.ToTable("ProductSubCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedUserId).HasColumnName("modifiedUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.ProductCategoryId).HasColumnName("productCategoryId");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductSubCategories)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSubCategory_ProductCategory");
            });

            modelBuilder.Entity<ProductView>(entity =>
            {
                entity.ToTable("ProductView");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.DateViewed).HasColumnName("dateViewed");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ProductViews)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductView_Channel");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductViews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductView_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProductViews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductView_User");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.ToTable("PurchaseOrder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuyerClientId).HasColumnName("buyerClientId");

                entity.Property(e => e.BuyerClientOutletId).HasColumnName("buyerClientOutletId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DateReceived).HasColumnName("dateReceived");

                entity.Property(e => e.DeliveryCharge)
                    .HasColumnType("money")
                    .HasColumnName("deliveryCharge");

                entity.Property(e => e.DeliveryFee)
                    .HasColumnType("money")
                    .HasColumnName("deliveryFee");

                entity.Property(e => e.Discount)
                    .HasColumnType("money")
                    .HasColumnName("discount");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.OrderStatusId).HasColumnName("orderStatusId");

                entity.Property(e => e.PoNumber)
                    .HasMaxLength(50)
                    .HasColumnName("poNumber");

                entity.Property(e => e.ShippingAddressId).HasColumnName("shippingAddressId");

                entity.Property(e => e.Tax)
                    .HasColumnType("money")
                    .HasColumnName("tax");

                entity.HasOne(d => d.BuyerClient)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.BuyerClientId)
                    .HasConstraintName("FK_PurchaseOrder_Client");

                entity.HasOne(d => d.BuyerClientOutlet)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.BuyerClientOutletId)
                    .HasConstraintName("FK_PurchaseOrder_ClientOutlet");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Channel");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_User");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_OrderStatus");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("FK_PurchaseOrder_Address");
            });

            modelBuilder.Entity<PurchaseOrderItem>(entity =>
            {
                entity.ToTable("PurchaseOrderItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(50)
                    .HasColumnName("batchNumber");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.OrderItemActionId).HasColumnName("orderItemActionId");

                entity.Property(e => e.OrderItemConditionId).HasColumnName("orderItemConditionId");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("purchaseOrderId");

                entity.Property(e => e.QuantityAccepted).HasColumnName("quantityAccepted");

                entity.Property(e => e.QuantityOrdered).HasColumnName("quantityOrdered");

                entity.Property(e => e.QuantityReceived).HasColumnName("quantityReceived");

                entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");

                entity.Property(e => e.UniversalStockId).HasColumnName("universalStockId");

                entity.HasOne(d => d.OrderItemAction)
                    .WithMany(p => p.PurchaseOrderItems)
                    .HasForeignKey(d => d.OrderItemActionId)
                    .HasConstraintName("FK_PurchaseOrderItem_OrderItemAction");

                entity.HasOne(d => d.OrderItemCondition)
                    .WithMany(p => p.PurchaseOrderItems)
                    .HasForeignKey(d => d.OrderItemConditionId)
                    .HasConstraintName("FK_PurchaseOrderItem_OrderItemCondition");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderItems)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderItem_PurchaseOrder");

                entity.HasOne(d => d.UniversalStock)
                    .WithMany(p => p.PurchaseOrderItems)
                    .HasForeignKey(d => d.UniversalStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderItem_UniversalInventoryStock");
            });

            modelBuilder.Entity<PurchaseOrderReturn>(entity =>
            {
                entity.ToTable("PurchaseOrderReturn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproverId).HasColumnName("approverId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateApproved).HasColumnName("dateApproved");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.OrderReturnStatusId).HasColumnName("orderReturnStatusId");

                entity.Property(e => e.PickUpAddressId).HasColumnName("pickUpAddressId");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("purchaseOrderId");

                entity.Property(e => e.ReturnReasonId).HasColumnName("returnReasonId");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.PurchaseOrderReturns)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturn_Channel");

                entity.HasOne(d => d.OrderReturnStatus)
                    .WithMany(p => p.PurchaseOrderReturns)
                    .HasForeignKey(d => d.OrderReturnStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturn_OrderReturnStatus");

                entity.HasOne(d => d.PickUpAddress)
                    .WithMany(p => p.PurchaseOrderReturns)
                    .HasForeignKey(d => d.PickUpAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturn_Address");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderReturns)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturn_PurchaseOrder");

                entity.HasOne(d => d.ReturnReason)
                    .WithMany(p => p.PurchaseOrderReturns)
                    .HasForeignKey(d => d.ReturnReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturn_ReturnReason");
            });

            modelBuilder.Entity<PurchaseOrderReturnItem>(entity =>
            {
                entity.ToTable("PurchaseOrderReturnItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.OrderReturnId).HasColumnName("orderReturnId");

                entity.Property(e => e.PurchaseOrderItemId).HasColumnName("purchaseOrderItemId");

                entity.Property(e => e.ReturnConditionId).HasColumnName("returnConditionId");

                entity.Property(e => e.ReturnQuantity).HasColumnName("returnQuantity");

                entity.HasOne(d => d.OrderReturn)
                    .WithMany(p => p.PurchaseOrderReturnItems)
                    .HasForeignKey(d => d.OrderReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturnItem_PurchaseOrderReturn");

                entity.HasOne(d => d.PurchaseOrderItem)
                    .WithMany(p => p.PurchaseOrderReturnItems)
                    .HasForeignKey(d => d.PurchaseOrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturnItem_PurchaseOrderItem");

                entity.HasOne(d => d.ReturnCondition)
                    .WithMany(p => p.PurchaseOrderReturnItems)
                    .HasForeignKey(d => d.ReturnConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderReturnItem_ReturnCondition");
            });

            modelBuilder.Entity<RefundPolicy>(entity =>
            {
                entity.ToTable("RefundPolicy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.HtmlText).HasColumnName("htmlText");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");
            });

            modelBuilder.Entity<ReturnCondition>(entity =>
            {
                entity.ToTable("ReturnCondition");

                entity.HasIndex(e => e.Name, "IX_ReturnCondition_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ReturnReason>(entity =>
            {
                entity.ToTable("ReturnReason");

                entity.HasIndex(e => e.Name, "IX_ReturnReason_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.HasIndex(e => e.RoleName, "IX_Role_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.ToTable("SalesOrder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproverId).HasColumnName("approverId");

                entity.Property(e => e.BillingAddressId).HasColumnName("billingAddressId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.CouponId).HasColumnName("couponId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DateApproved).HasColumnName("dateApproved");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DeletedByUserId).HasColumnName("deletedByUserId");

                entity.Property(e => e.DeliveryCharge).HasColumnName("deliveryCharge");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LogisticDeliverOptionId).HasColumnName("logisticDeliverOptionId");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.OrderStatusId).HasColumnName("orderStatusId");

                entity.Property(e => e.ReceiptNumber)
                    .HasMaxLength(100)
                    .HasColumnName("receiptNumber");

                entity.Property(e => e.SalesOrderTypeId).HasColumnName("salesOrderTypeId");

                entity.Property(e => e.SellerClientId).HasColumnName("sellerClientId");

                entity.Property(e => e.SellerClientOutletId).HasColumnName("sellerClientOutletId");

                entity.Property(e => e.SellerClientUserId).HasColumnName("sellerClientUserId");

                entity.Property(e => e.ShippingAddressId).HasColumnName("shippingAddressId");

                entity.Property(e => e.ShoppingCartOrderId).HasColumnName("shoppingCartOrderId");

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.UniqueOrderId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("uniqueOrderID");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.SalesOrderBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrder_Address_Billing");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrder_Channel");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_SalesOrder_Coupon");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.SalesOrderCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrder_CreatorUser");

                entity.HasOne(d => d.DeletedByUser)
                    .WithMany(p => p.SalesOrderDeletedByUsers)
                    .HasForeignKey(d => d.DeletedByUserId)
                    .HasConstraintName("FK_SalesOrder_UserDeleting");

                entity.HasOne(d => d.LogisticDeliverOption)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.LogisticDeliverOptionId)
                    .HasConstraintName("FK_SalesOrder_LogisticsDeliveryOption");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.SalesOrderModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_SalesOrder_UserModifying");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrder_OrderStatus");

                entity.HasOne(d => d.SalesOrderType)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.SalesOrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrder_SalesOrderType");

                entity.HasOne(d => d.SellerClient)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.SellerClientId)
                    .HasConstraintName("FK_SalesOrder_Client_Seller");

                entity.HasOne(d => d.SellerClientOutlet)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.SellerClientOutletId)
                    .HasConstraintName("FK_SalesOrder_ClientOutlet");

                entity.HasOne(d => d.SellerClientUser)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.SellerClientUserId)
                    .HasConstraintName("FK_SalesOrder_ClientUser");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.SalesOrderShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrder_Address_Shipping");

                entity.HasOne(d => d.ShoppingCartOrder)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.ShoppingCartOrderId)
                    .HasConstraintName("FK_SalesOrder_ShoppingCartOrder");
            });

            modelBuilder.Entity<SalesOrderItem>(entity =>
            {
                entity.ToTable("SalesOrderItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BundleItemId).HasColumnName("bundleItemId");

                entity.Property(e => e.CouponDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("couponDiscount");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.PackSizeId).HasColumnName("packSizeId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.Property(e => e.SellerClientOutletId).HasColumnName("sellerClientOutletId");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("money")
                    .HasColumnName("unitPrice");

                entity.Property(e => e.UniversalInventoryStockId).HasColumnName("universalInventoryStockId");
            });

            modelBuilder.Entity<SalesOrderReturn>(entity =>
            {
                entity.ToTable("SalesOrderReturn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproverId).HasColumnName("approverId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateApproved).HasColumnName("dateApproved");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByuserId).HasColumnName("modifiedByuserId");

                entity.Property(e => e.OrderReturnStatusId).HasColumnName("orderReturnStatusId");

                entity.Property(e => e.PickUpAddressId).HasColumnName("pickUpAddressId");

                entity.Property(e => e.ReturnReasonId).HasColumnName("returnReasonId");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");
            });

            modelBuilder.Entity<SalesOrderReturnItem>(entity =>
            {
                entity.ToTable("SalesOrderReturnItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.OrderReturnId).HasColumnName("orderReturnId");

                entity.Property(e => e.ReturnConditionId).HasColumnName("returnConditionId");

                entity.Property(e => e.ReturnQuantity).HasColumnName("returnQuantity");

                entity.Property(e => e.SalesOrderItemId).HasColumnName("salesOrderItemId");
            });

            modelBuilder.Entity<SalesOrderType>(entity =>
            {
                entity.ToTable("SalesOrderType");

                entity.HasIndex(e => e.Name, "IX_SalesOrderType_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SellAsUnit>(entity =>
            {
                entity.ToTable("SellAsUnit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<ServiceItem>(entity =>
            {
                entity.ToTable("ServiceItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.PackSizeId).HasColumnName("packSizeId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ServiceId).HasColumnName("serviceId");

                entity.HasOne(d => d.PackSize)
                    .WithMany(p => p.ServiceItems)
                    .HasForeignKey(d => d.PackSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceItem_PackSize");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ServiceItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ServiceItem_Product");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceItems)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceItem_Services");
            });

            modelBuilder.Entity<ShoppingCartOrder>(entity =>
            {
                entity.ToTable("ShoppingCartOrder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.CustomerLocationLatitude)
                    .HasMaxLength(200)
                    .HasColumnName("customerLocationLatitude");

                entity.Property(e => e.CustomerLocationLongitude)
                    .HasMaxLength(200)
                    .HasColumnName("customerLocationLongitude");

                entity.Property(e => e.CustomerShippingAddressId).HasColumnName("customerShippingAddressId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .HasColumnName("sessionId");

                entity.Property(e => e.ShoppingCartOrderStatusId).HasColumnName("shoppingCartOrderStatusId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShoppingCartOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ShoppingCartOrder_Customer");

                entity.HasOne(d => d.CustomerShippingAddress)
                    .WithMany(p => p.ShoppingCartOrders)
                    .HasForeignKey(d => d.CustomerShippingAddressId)
                    .HasConstraintName("FK_ShoppingCartOrder_CustomerShippingAddress");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.ShoppingCartOrders)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_ShoppingCartOrder_SalesOrder");

                entity.HasOne(d => d.ShoppingCartOrderStatus)
                    .WithMany(p => p.ShoppingCartOrders)
                    .HasForeignKey(d => d.ShoppingCartOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartOrder_ShoppingCartOrderStatus");
            });

            modelBuilder.Entity<ShoppingCartOrderItem>(entity =>
            {
                entity.ToTable("ShoppingCartOrderItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BundleItemId).HasColumnName("bundleItemId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.MaxUnitPrice)
                    .HasColumnType("money")
                    .HasColumnName("maxUnitPrice");

                entity.Property(e => e.MinUnitPrice)
                    .HasColumnType("money")
                    .HasColumnName("minUnitPrice");

                entity.Property(e => e.ModUnitPrice)
                    .HasColumnType("money")
                    .HasColumnName("modUnitPrice");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.PackSizeId).HasColumnName("packSizeId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ShoppingCartOrderId).HasColumnName("shoppingCartOrderId");

                entity.HasOne(d => d.BundleItem)
                    .WithMany(p => p.ShoppingCartOrderItems)
                    .HasForeignKey(d => d.BundleItemId)
                    .HasConstraintName("FK_ShoppingCartOrderItem_BundleItem");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ShoppingCartOrderItems)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartOrderItem_Channel");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.ShoppingCartOrderItemCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartOrderItem_User");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.ShoppingCartOrderItemModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_ShoppingCartOrderItem_UserModifying");

                entity.HasOne(d => d.PackSize)
                    .WithMany(p => p.ShoppingCartOrderItems)
                    .HasForeignKey(d => d.PackSizeId)
                    .HasConstraintName("FK_ShoppingCartOrderItem_PackSize");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartOrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartOrderItem_Product");

                entity.HasOne(d => d.ShoppingCartOrder)
                    .WithMany(p => p.ShoppingCartOrderItems)
                    .HasForeignKey(d => d.ShoppingCartOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartOrderItem_ShoppingCartOrder");
            });

            modelBuilder.Entity<ShoppingCartOrderStatus>(entity =>
            {
                entity.ToTable("ShoppingCartOrderStatus");

                entity.HasIndex(e => e.Name, "IX_ShoppingCartOrderStatus")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State");

                entity.HasIndex(e => new { e.Id, e.Name }, "IX_State_Unique_Country_State")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(200)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(200)
                    .HasColumnName("longitude");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_State_Country");
            });

            modelBuilder.Entity<StrengthUnit>(entity =>
            {
                entity.ToTable("StrengthUnit");

                entity.HasIndex(e => e.Name, "IX_StrengthUnit_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SubscriptionPayment>(entity =>
            {
                entity.ToTable("SubscriptionPayment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.DateApproved).HasColumnName("dateApproved");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.Fees)
                    .HasColumnType("money")
                    .HasColumnName("fees");

                entity.Property(e => e.PaymentMethodId).HasColumnName("paymentMethodId");

                entity.Property(e => e.PaymentStatusId).HasColumnName("paymentStatusId");

                entity.Property(e => e.PaymentTypeId).HasColumnName("paymentTypeId");

                entity.Property(e => e.Reference)
                    .HasMaxLength(200)
                    .HasColumnName("reference");

                entity.Property(e => e.SubscriptionTierId).HasColumnName("subscriptionTierId");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionPayment_Channel");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionPayment_Client");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionPayment_PaymentMethod");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionPayment_PaymentStatus");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionPayment_PaymentType");

                entity.HasOne(d => d.SubscriptionTier)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.SubscriptionTierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionPayment_SubscriptionTier");
            });

            modelBuilder.Entity<SubscriptionTier>(entity =>
            {
                entity.ToTable("SubscriptionTier");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<SubscriptionTierFeature>(entity =>
            {
                entity.ToTable("SubscriptionTierFeature");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.SubscriptionTierId).HasColumnName("subscriptionTierId");

                entity.HasOne(d => d.SubscriptionTier)
                    .WithMany(p => p.SubscriptionTierFeatures)
                    .HasForeignKey(d => d.SubscriptionTierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionTierFeature_SubscriptionTier");
            });

            modelBuilder.Entity<SupportRequest>(entity =>
            {
                entity.ToTable("SupportRequest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DateResolved).HasColumnName("dateResolved");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnName("details");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("subject");

                entity.Property(e => e.SupportRequestStatusId).HasColumnName("supportRequestStatusId");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("username");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.SupportRequests)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportRequest_Channel");

                entity.HasOne(d => d.SupportRequestStatus)
                    .WithMany(p => p.SupportRequests)
                    .HasForeignKey(d => d.SupportRequestStatusId)
                    .HasConstraintName("FK_SupportRequest_SupportRequestStatus");
            });

            modelBuilder.Entity<SupportRequestReview>(entity =>
            {
                entity.ToTable("SupportRequestReview");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.SupportRequestId).HasColumnName("supportRequestId");

                entity.HasOne(d => d.SupportRequest)
                    .WithMany(p => p.SupportRequestReviews)
                    .HasForeignKey(d => d.SupportRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportRequestReview_SupportRequest");
            });

            modelBuilder.Entity<SupportRequestStatus>(entity =>
            {
                entity.ToTable("SupportRequestStatus");

                entity.HasIndex(e => e.Name, "IX_SupportRequestStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SystemConfiguration>(entity =>
            {
                entity.ToTable("SystemConfiguration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.HasIndex(e => e.Name, "IX_Tag_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DeletedByUserId).HasColumnName("deletedByUserId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.TagCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tag_User");

                entity.HasOne(d => d.DeletedByUser)
                    .WithMany(p => p.TagDeletedByUsers)
                    .HasForeignKey(d => d.DeletedByUserId)
                    .HasConstraintName("FK_Tag_UserDeleting");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.TagModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_Tag_UserModifying");
            });

            modelBuilder.Entity<TermsandCondition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.HtmlText)
                    .IsRequired()
                    .HasColumnName("htmlText");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("Testimonial");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("customerName");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DateOfTestimonial).HasColumnName("dateOfTestimonial");

                entity.Property(e => e.DocumentUploadId).HasColumnName("documentUploadId");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.TestimonialStatusId).HasColumnName("testimonialStatusId");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Testimonial_DocumentUpload");

                entity.HasOne(d => d.TestimonialStatus)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.TestimonialStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Testimonial_TestimonialStatus");
            });

            modelBuilder.Entity<TestimonialStatus>(entity =>
            {
                entity.ToTable("TestimonialStatus");

                entity.HasIndex(e => e.Name, "IX_TestimonialStatus_UniqueConstraint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<UniversalInventoryLevel>(entity =>
            {
                entity.ToTable("UniversalInventoryLevel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchNumber).HasColumnName("batchNumber");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateExpiry).HasColumnName("dateExpiry");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.InventoryLevelTypeId).HasColumnName("inventoryLevelTypeId");

                entity.Property(e => e.ModifiedById).HasColumnName("modifiedById");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("purchaseOrderId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalesOrderId).HasColumnName("salesOrderId");

                entity.Property(e => e.UniversalStockId).HasColumnName("universalStockId");

                entity.HasOne(d => d.InventoryLevelType)
                    .WithMany(p => p.UniversalInventoryLevels)
                    .HasForeignKey(d => d.InventoryLevelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UniversalInventoryLevel_InventoryLevelType");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.UniversalInventoryLevels)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_UniversalInventoryLevel_PurchaseOrder");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.UniversalInventoryLevels)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_UniversalInventoryLevel_SalesOrder");

                entity.HasOne(d => d.UniversalStock)
                    .WithMany(p => p.UniversalInventoryLevels)
                    .HasForeignKey(d => d.UniversalStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UniversalInventoryLevel_UniversalInventoryStock");
            });

            modelBuilder.Entity<UniversalInventoryStock>(entity =>
            {
                entity.ToTable("UniversalInventoryStock");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientOutletId).HasColumnName("clientOutletId");

                entity.Property(e => e.CostPricePerUnit)
                    .HasColumnType("money")
                    .HasColumnName("costPricePerUnit");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.DefaultSellingUnit).HasColumnName("defaultSellingUnit");

                entity.Property(e => e.LargestSellingUnit).HasColumnName("largestSellingUnit");

                entity.Property(e => e.MarkUp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("markUp");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.NextSellingUnit).HasColumnName("nextSellingUnit");

                entity.Property(e => e.PackSizeId).HasColumnName("packSizeId");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ReorderLevel).HasColumnName("reorderLevel");

                entity.Property(e => e.ReorderQuantity).HasColumnName("reorderQuantity");

                entity.Property(e => e.SellAsUnitId).HasColumnName("sellAsUnitId");

                entity.Property(e => e.ServiceId).HasColumnName("serviceId");

                entity.HasOne(d => d.ClientOutlet)
                    .WithMany(p => p.UniversalInventoryStocks)
                    .HasForeignKey(d => d.ClientOutletId)
                    .HasConstraintName("FK_UniversalInventoryStock_ClientOutlet");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.UniversalInventoryStockCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UniversalInventoryStock_User");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.UniversalInventoryStockModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_UniversalInventoryStock_UserModifying");

                entity.HasOne(d => d.PackSize)
                    .WithMany(p => p.UniversalInventoryStocks)
                    .HasForeignKey(d => d.PackSizeId)
                    .HasConstraintName("FK_UniversalInventoryStock_PackSize");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UniversalInventoryStocks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_UniversalInventoryStock_Product");

                entity.HasOne(d => d.SellAsUnit)
                    .WithMany(p => p.UniversalInventoryStocks)
                    .HasForeignKey(d => d.SellAsUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UniversalInventoryStock_SellAsUnit");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.UniversalInventoryStocks)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_UniversalInventoryStock_Services");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateDeleted).HasColumnName("dateDeleted");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.EmailConfirmationToken).HasColumnName("emailConfirmationToken");

                entity.Property(e => e.EmailConfirmationTokenExpiry).HasColumnName("emailConfirmationTokenExpiry");

                entity.Property(e => e.EmailConfirmed).HasColumnName("emailConfirmed");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("lastname");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(100)
                    .HasColumnName("middlename");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("password");

                entity.Property(e => e.PasswordResetToken).HasColumnName("passwordResetToken");

                entity.Property(e => e.PasswordResetTokenExpiry).HasColumnName("passwordResetTokenExpiry");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.UserStatus)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserStatus");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("UserLogin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.DateLogin).HasColumnName("dateLogin");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogin_Channel");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogin_User");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_User");
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.ToTable("UserStatus");

                entity.HasIndex(e => e.Name, "IX_UserStatus")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("Wishlist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BundleItemId).HasColumnName("bundleItemId");

                entity.Property(e => e.ChannelId).HasColumnName("channelId");

                entity.Property(e => e.CreatorUserId).HasColumnName("creatorUserId");

                entity.Property(e => e.DateCreated).HasColumnName("dateCreated");

                entity.Property(e => e.DateModified).HasColumnName("dateModified");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("modifiedByUserId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.HasOne(d => d.BundleItem)
                    .WithMany(p => p.Wishlists)
                    .HasForeignKey(d => d.BundleItemId)
                    .HasConstraintName("FK_Wishlist_BundleItem");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.Wishlists)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wishlist_Channel");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.WishlistCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wishlist_User");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.WishlistModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_Wishlist_UserModifying");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Wishlists)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wishlist_Product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
