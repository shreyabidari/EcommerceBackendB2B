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

        // Navigation property for Returns associated with this retailer
        public virtual ICollection<SalesReturn> SalesReturns { get; set; }

        // Navigation property for the many-to-many relationship with Wholesalers
        public virtual ICollection<WholesalerRetailer> WholesalerRetailers { get; set; }
    }
}

