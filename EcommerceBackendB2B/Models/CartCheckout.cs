namespace EcommerceBackendB2B.Models
{
    public class CartCheckout
    {
        public int ID { get; set; }
        
       
        public DateTime CheckoutDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public int CartID { get; set; }
        public Cart Cart { get; set; }
        
        public int PaymentMethodID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
//Attributes: ID, CartID, RetailerID, PaymentMethodID,
//    CheckoutDate, TotalAmount, etc.
//Relationships: One - to - One with Cart, 
//    Many-to-One with PaymentMethod.
