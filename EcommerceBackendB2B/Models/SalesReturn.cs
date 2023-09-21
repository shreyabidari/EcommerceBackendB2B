namespace EcommerceBackendB2B.Models
{
    public class SalesReturn
    {
        public int ID { get; set; }
        public int SalesID { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnStatus { get; set; }
        public decimal TotalRefundAmount { get; set; }

        // Navigation properties
        public Sales Sale { get; set; }
        public List<SalesReturnDetails> SalesReturnDetails { get; set; }
    }
}
//Attributes: ID, SalesID, ReturnDate, ReturnStatus, 
//    TotalRefundAmount, etc.
//Relationships: Many - to - One with Sales, 
//    One-to-Many with SalesReturnDetails.