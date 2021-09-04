using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class PurchaseOrderReturn
    {
        public PurchaseOrderReturn()
        {
            PurchaseOrderReturnItems = new HashSet<PurchaseOrderReturnItem>();
        }

        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ReturnReasonId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public string Comments { get; set; }
        public int PickUpAddressId { get; set; }
        public int ChannelId { get; set; }
        public int OrderReturnStatusId { get; set; }
        public int? ApproverId { get; set; }
        public DateTime? DateApproved { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual OrderReturnStatus OrderReturnStatus { get; set; }
        public virtual Address PickUpAddress { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual ReturnReason ReturnReason { get; set; }
        public virtual ICollection<PurchaseOrderReturnItem> PurchaseOrderReturnItems { get; set; }
    }
}
