namespace EcommerceBackendB2B.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string ContactInfo { get; set; }
       
      
    }
}
//Attributes: ID, Username, Email, Password, Role (Admin),
//Status (Active / Banned), ContactInfo, ApprovalStatus (Auto - Approved), etc.
//Relationships: One - to - Many with Notifications, One-to-Many with Commission (as commission setter),
//One - to - Many with Sales(for sales reports).
