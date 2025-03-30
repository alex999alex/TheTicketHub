using System.ComponentModel.DataAnnotations;

namespace TheTicketHub
{
    public class TheTicketHub
    {
        [Required(ErrorMessage = "Concert ID is required.")] 
        public int concertId { get; set; } = 0;

        [EmailAddress]
        [Required(ErrorMessage = "Email address is required.")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name is required.")]
        public string name { get; set; } = string.Empty;

        [MaxLength(10, ErrorMessage = "Phone number need to be maxiaum length of 10 charecters.")]
        [Required(ErrorMessage = "Phone number is required.")]
        public string phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quantity is required.")]
        public int quantity { get; set; } = 0;

        [Required(ErrorMessage = "Credit card number is required.")]
        public string creditCard { get; set; } = string.Empty;

        [Required(ErrorMessage = "Expiration date is required.")]
        public string expiration{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Security code is required.")]
        public string securityCode{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required.")]
        public string address{ get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required.")]
        public string city{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Province is required.")]
        public string province{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required.")]
        public string postalCode{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required.")]
        public string country{ get; set; } = string.Empty;

    }
}
