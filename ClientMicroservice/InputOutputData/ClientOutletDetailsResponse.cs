using System;
namespace NotificationService.InputOutputData
{
    public class ClientOutletDetailsResponse
    {

       public int clientId { get; set; }
       public string clientName { get; set; }
        public string clientType { get; set; }
        public int outletId { get; set; }
        public string outletName { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }

        public string contactPerson { get; set; }
        public string contactPersonPhoneNumber { get; set; }
        public string contactPersonEmailAddress { get; set; }
        public string streetNumber { get; set; }
        public string streetName { get; set; }
        public string state { get; set; }

        public string country { get; set; }
        public string lga { get; set; }
        public string city { get; set; }
        public bool subscribedToPromotions { get; set; }

    }
}
