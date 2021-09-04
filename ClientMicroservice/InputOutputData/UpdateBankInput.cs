using System;
using System.ComponentModel.DataAnnotations;

namespace NotificationService.InputOutputData
{
    public class UpdateBankInput
    {
        [Required]
        public string clientAuthorizationKey { get; set; }
        [Required]
        public int clientOutletId { get; set; }
        [Required]
        public int bankId { get; set; }
        [Required]
        public string bankAccountNumber { get; set; }
        [Required]
        public string bankAccountName { get; set; }
      

    }
}
