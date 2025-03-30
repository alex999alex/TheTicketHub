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


        //[MaxLength(10, ErrorMessage = "Phone need to be maxiaum length of 10 charecters.")]
        //[Required(ErrorMessage = "Phone is required.")]


        //[EmailAddress]
        //[Required]

        //concentID, set to 0
        public int contactId { get; set; } = 0;

        public string email { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;

        //quantity, set to 0
        public int quantity { get; set; } = 0;

        //credit caed, string, set to empty
        public string creditCard { get; set; } = string.Empty;

        public string expiration{ get; set; } = string.Empty;

        public string securityCode{ get; set; } = string.Empty;

        public string address{ get; set; } = string.Empty;

        public string city{ get; set; } = string.Empty;

        public string province{ get; set; } = string.Empty;

        public string postalCode{ get; set; } = string.Empty;

        public string country{ get; set; } = string.Empty;

    }
}
