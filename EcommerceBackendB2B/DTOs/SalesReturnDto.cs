namespace EcommerceBackendB2B.DTOs
{
    public class SalesReturnDto
    {
        public int ID { get; set; }
        public int SalesID { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnStatus { get; set; }
        public decimal TotalRefundAmount { get; set; }
    }
}
