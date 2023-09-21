namespace EcommerceBackendB2B.Models
{
    public class CartProductDetails
    {
        public int ID { get; set; }    
        
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public int CartID { get; set; }
        public Cart Cart { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}

