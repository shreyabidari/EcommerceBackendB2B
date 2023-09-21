namespace EcommerceBackendB2B.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }


        // Navigation properties
        public int RetailerId { get; set; }
        public Retailer Retailer { get; set; }
        public virtual ICollection<CartProductDetails> CartProducts { get; set; }
        public virtual CartCheckout CartCheckout { get; set; }
    }
}

