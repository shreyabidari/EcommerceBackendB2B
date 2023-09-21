namespace EcommerceBackendB2B.Models
{
    public class WholesalerRetailer
    {
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

        public int RetailerId { get; set; }
        public virtual Retailer Retailer { get; set; }
    }
}

