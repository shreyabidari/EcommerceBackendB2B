namespace EcommerceBackendB2B.Models
{
    public class PaymentMethod
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public List<CartCheckout> CartCheckouts { get; set; }
        
    }
}

