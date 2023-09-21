namespace EcommerceBackendB2B.DTOs
{
    public class CartCheckoutDto
    {
        public int ID { get; set; }
        public int CartID { get; set; }
        public int RetailerID { get; set; }
        public int PaymentMethodID { get; set; }
        public DateTime CheckoutDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
