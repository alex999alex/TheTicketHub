using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TheTicketHub
{
    public class TheTicketHub
    {
        [Required(ErrorMessage = "Concert ID is required.")] 
        public int concertId { get; set; } = 0;

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Email address is required.")]
        [StringLength(100, ErrorMessage = "Email address cannot exceed 100 characters.")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        [RegularExpression(@"^[a-zA-Z\s-']+$", ErrorMessage = "Name can only contain letters, spaces, hyphens, and apostrophes.")]
        public string name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Please enter a valid phone number (e.g., +1234567890 or 1234567890).")]
        public string phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 10, ErrorMessage = "Quantity must be between 1 and 10 tickets.")]
        public int quantity { get; set; } = 0;

        [Required(ErrorMessage = "Credit card number is required.")]
        [RegularExpression(@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|6(?:011|5[0-9]{2})[0-9]{12}|(?:2131|1800|35\d{3})\d{11})$", 
            ErrorMessage = "Please enter a valid credit card number.")]
        public string creditCard { get; set; } = string.Empty;

        [Required(ErrorMessage = "Expiration date is required.")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/([0-9]{2})$", ErrorMessage = "Please enter a valid expiration date (MM/YY).")]
        public string expiration { get; set; } = string.Empty;

        [Required(ErrorMessage = "Security code is required.")]
        [RegularExpression(@"^[0-9]{3,4}$", ErrorMessage = "Security code must be 3 or 4 digits.")]
        public string securityCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 200 characters.")]
        public string address { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "City must be between 2 and 100 characters.")]
        [RegularExpression(@"^[a-zA-Z\s-']+$", ErrorMessage = "City can only contain letters, spaces, hyphens, and apostrophes.")]
        public string city { get; set; } = string.Empty;

        [Required(ErrorMessage = "Province is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Province must be between 2 and 100 characters.")]
        [RegularExpression(@"^[a-zA-Z\s-']+$", ErrorMessage = "Province can only contain letters, spaces, hyphens, and apostrophes.")]
        public string province { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required.")]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$", ErrorMessage = "Please enter a valid postal code (e.g., A1A 1A1).")]
        public string postalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Country must be between 2 and 100 characters.")]
        [RegularExpression(@"^[a-zA-Z\s-']+$", ErrorMessage = "Country can only contain letters, spaces, hyphens, and apostrophes.")]
        public string country { get; set; } = string.Empty;
    }
}
