using System;
namespace ClientMicroservice.InputOutputData
{
    public class NonNetworkMemInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string ClientName { get; set; }
        public int ClientTypeId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public int SubscriptionTierId { get; set; }
        


    }
}
