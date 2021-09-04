using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class Address
    {
        public Address()
        {
            ClientOutlets = new HashSet<ClientOutlet>();
            CustomerShippingAddresses = new HashSet<CustomerShippingAddress>();
            PurchaseOrderReturns = new HashSet<PurchaseOrderReturn>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrderBillingAddresses = new HashSet<SalesOrder>();
            SalesOrderShippingAddresses = new HashSet<SalesOrder>();
        }

        public int Id { get; set; }
        public int CreatorUserId { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int? LocalGovtId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Country Country { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual LocalGovernmentArea LocalGovt { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<ClientOutlet> ClientOutlets { get; set; }
        public virtual ICollection<CustomerShippingAddress> CustomerShippingAddresses { get; set; }
        public virtual ICollection<PurchaseOrderReturn> PurchaseOrderReturns { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderBillingAddresses { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderShippingAddresses { get; set; }
    }
}
