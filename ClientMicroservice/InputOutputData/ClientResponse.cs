using System;
namespace NotificationService.InputOutputData
{
    public class ClientResponse
    {
        public int clientId { get; set; }
        public string clientName { get; set; }
        public string clientType { get; set; }
        public int numOfOutlets { get; set; }
        public string defaultPhoneNumber { get; set; }
        public string defaultEmailAddress { get; set; }
        public string defaultContactPerson { get; set; }
        public string businessLicenseNumber { get; set; }
        public string defaultStreetNumber { get; set; }
        public string defaultStreetName { get; set; }
        public string defaultState { get; set; }
        public string defaultCountry { get; set; }
        public string defaultLga { get; set; }
        public string defaultCity { get; set; }


    }
}
