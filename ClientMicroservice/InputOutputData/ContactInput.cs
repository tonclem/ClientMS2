using System;
using System.ComponentModel.DataAnnotations;

namespace NotificationService.InputOutputData
{
    public class ContactInput
    {


        [Required]
        public string clientAuthorizationKey { get; set; }

        public string fullname { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        [EmailAddress]
        public string emailAddress { get; set; }

        [Required]
        [Phone]
        public string phoneNumber { get; set; }

        [Required]
        public string gender { get; set; }

    }
}
