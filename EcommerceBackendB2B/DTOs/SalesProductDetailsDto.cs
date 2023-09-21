namespace EcommerceBackendB2B.DTOs
{
    public class SalesProductDetailsDto
    {
        public int ID { get; set; }
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
