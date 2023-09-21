using System.ComponentModel.DataAnnotations;

namespace EcommerceBackendB2B.Models.Auth
{
    public class Register
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
        public string Role { get; set; }
        public bool IsRetailerOrWholesaler(string role)
        {
            return role == UserRoles.Retailer || role == UserRoles.Wholesaler;
        }
    }
}