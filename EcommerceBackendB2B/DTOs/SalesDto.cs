namespace EcommerceBackendB2B.DTOs
{
    public class SalesDto
    {
        public int ID { get; set; }
        public int RetailerID { get; set; }
        public int WholesalerId { get; set; }
        public int PaymentMethodID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
