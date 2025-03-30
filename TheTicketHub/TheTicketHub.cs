using System.ComponentModel.DataAnnotations;

namespace TheTicketHub
{
    public class TheTicketHub
    {

        //[Required(ErrorMessage = "First Name is required.")]
        //public string FirstName { get; set; } = string.Empty;

        //[MaxLength(10, ErrorMessage = "Last Name need to be maxiaum length of 10 charecters.")]
        //[Required(ErrorMessage = "Last Name is required.")]
        //public string LastName { get; set; } = string.Empty;

        //[EmailAddress]
        //[Required]
        //public string Email { get; set; } = string.Empty;



        //[Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        //[MaxLength(10, ErrorMessage = "Phone need to be maxiaum length of 10 charecters.")]
        //[Required(ErrorMessage = "Phone is required.")]
        public string Phone { get; set; } = string.Empty;

        //[EmailAddress]
        //[Required]
        //public string Email { get; set; } = string.Empty;
    }
}
