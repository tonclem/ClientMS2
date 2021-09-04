using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class SalesOrderReturn
    {
        public int Id { get; set; }
        public int ReturnReasonId { get; set; }
        public int SalesOrderId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByuserId { get; set; }
        public string Comments { get; set; }
        public int PickUpAddressId { get; set; }
        public int ChannelId { get; set; }
        public int OrderReturnStatusId { get; set; }
        public int? ApproverId { get; set; }
        public DateTime? DateApproved { get; set; }
    }
}
