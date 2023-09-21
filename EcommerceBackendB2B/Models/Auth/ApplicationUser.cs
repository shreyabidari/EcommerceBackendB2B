using Microsoft.AspNetCore.Identity;

namespace EcommerceBackendB2B.Models.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public bool RequiresApproval { get; set; } = true;

       
    }
}
