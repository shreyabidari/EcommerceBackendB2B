namespace EcommerceBackendB2B.Models
{
    public class Wholesaler
    {
        public int ID { get; set; }
        public string WholesalerName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }


        // Navigation property for the many-to-many relationship with products
        public virtual ICollection<WholesalerProduct> WholesalerProducts { get; set; }

        // Navigation property for the many-to-many relationship with categories
        public virtual ICollection<WholesalerCategory> WholesalerCategories { get; set; }
        // Navigation property for the many-to-many relationship with Retailers
        public virtual ICollection<WholesalerRetailer> WholesalerRetailers { get; set; }


    }

}


