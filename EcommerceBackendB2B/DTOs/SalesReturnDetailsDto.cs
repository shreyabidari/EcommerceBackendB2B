namespace EcommerceBackendB2B.DTOs
{
    public class SalesReturnDetailsDto
    {
        public int ID { get; set; }
        public int SalesReturnID { get; set; }
        public int ProductID { get; set; }
        public int QuantityReturned { get; set; }
        public decimal RefundAmount { get; set; }
    }
}
