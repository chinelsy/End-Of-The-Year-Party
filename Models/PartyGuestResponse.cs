using System.ComponentModel.DataAnnotations;

namespace EndOfTheYearParty.Models
{
    public class PartyGuestResponse
    {
       [Required(ErrorMessage = "Please enter your FullName")]
        public string FullName { get; set; }
       
        [Required(ErrorMessage = "Please enter your correct email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter your correct Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="Please specify if you will be attending the event")]
        public bool? WillAttend { get; set; }
    }
}
