namespace EcommerceBackendB2B.Models
{
    public class Retailer
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string ApprovalStatus { get; set; }
        public string ContactInfo { get; set; }

        // Foreign key
        public int WholesalerID { get; set; }
        public Wholesaler Wholesaler { get; set; }

        // Navigation properties

        public List<Cart> Carts { get; set; }
        //public ICollection<Sales> Sales { get; set; }

        public List<ApprovalRequest> ApprovalRequests { get; set; }
    }
}
//Attributes: ID, Username, Email, Password, Role (Retailer),
//    Status (Pending / Approved / Banned), ApprovalStatus, 
//    ContactInfo, etc.
//Relationships: One - to - Many with Notifications, 
//    Many-to-One with Wholesaler ,
//    One - to - Many with Cart, One-to-Many with Sales, 
//    One-to-Many with ApprovalRequest (as Requester).
