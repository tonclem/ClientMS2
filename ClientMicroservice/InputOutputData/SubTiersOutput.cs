using System;
using System.Collections.Generic;
using NotificationService.Data.Models;

namespace ClientMicroservice.InputOutputData
{
    public class SubTiersOutput
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public bool isDeleted { get; set; }
        public List<SubscriptionTierFeature> list { get; set; }
        
                            
    }
}
