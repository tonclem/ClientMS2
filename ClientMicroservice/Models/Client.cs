using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Client
    {
        public Client()
        {
            ClientAuthors = new HashSet<ClientAuthor>();
            ClientContents = new HashSet<ClientContent>();
            ClientOutlets = new HashSet<ClientOutlet>();
            Customers = new HashSet<Customer>();
            LogisticsDeliveryOptions = new HashSet<LogisticsDeliveryOption>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrders = new HashSet<SalesOrder>();
            SubscriptionPayments = new HashSet<SubscriptionPayment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int ClientTypeId { get; set; }
        public int ClientStatusId { get; set; }
        public string BusinessLicenseNumber { get; set; }
        public int? BusinessLicenseDocumentUploadId { get; set; }
        public bool IsWithinAhanetwork { get; set; }
        public int? SubscriptionTierId { get; set; }
        public int? AuthorizationKeyId { get; set; }
        public int? ApprovalUserId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool IsApproved { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AuthorizationKey AuthorizationKey { get; set; }
        public virtual DocumentUpload BusinessLicenseDocumentUpload { get; set; }
        public virtual ClientStatus ClientStatus { get; set; }
        public virtual ClientType ClientType { get; set; }
        public virtual SubscriptionTier SubscriptionTier { get; set; }
        public virtual ICollection<ClientAuthor> ClientAuthors { get; set; }
        public virtual ICollection<ClientContent> ClientContents { get; set; }
        public virtual ICollection<ClientOutlet> ClientOutlets { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<LogisticsDeliveryOption> LogisticsDeliveryOptions { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
    }
}
