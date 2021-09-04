using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class ClientOutlet
    {
        public ClientOutlet()
        {
            Bundles = new HashSet<Bundle>();
            ClientOutletRatings = new HashSet<ClientOutletRating>();
            ClientUsers = new HashSet<ClientUser>();
            Customers = new HashSet<Customer>();
            InventoryStockTakes = new HashSet<InventoryStockTake>();
            OrderFulfilments = new HashSet<OrderFulfilment>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrders = new HashSet<SalesOrder>();
            UniversalInventoryStocks = new HashSet<UniversalInventoryStock>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public int? AddressId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? BankId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankAccountName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonPhoneNumber { get; set; }
        public string ContactPersonEmail { get; set; }
        public string ContactPersonTitle { get; set; }
        public string ContactPersonGender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool? SubscribedToPromotions { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int? ClientOutletTypeId { get; set; }
        public int ClientOutletStatusId { get; set; }
        public bool IsDefault { get; set; }

        
        public virtual Address Address { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientOutletStatus ClientOutletStatus { get; set; }
        public virtual ClientOutletType ClientOutletType { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual ICollection<Bundle> Bundles { get; set; }
        public virtual ICollection<ClientOutletRating> ClientOutletRatings { get; set; }
        public virtual ICollection<ClientUser> ClientUsers { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<InventoryStockTake> InventoryStockTakes { get; set; }
        public virtual ICollection<OrderFulfilment> OrderFulfilments { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<UniversalInventoryStock> UniversalInventoryStocks { get; set; }
    }
}
