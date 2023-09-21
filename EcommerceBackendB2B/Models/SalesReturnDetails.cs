namespace EcommerceBackendB2B.Models
{
    public class SalesReturnDetails
    {
        public int ID { get; set; }
        public int SalesReturnID { get; set; }
        public int ProductID { get; set; }
        public int QuantityReturned { get; set; }
        public decimal RefundAmount { get; set; }

        // Navigation properties
        public SalesReturn SalesReturn { get; set; }
        public Product Product { get; set; }
    }
}
//Attributes: ID, SalesReturnID, ProductID, QuantityReturned,
//    RefundAmount, etc.
//Relationships: Many - to - One with SalesReturn, 
//    Many-to-One with Product.
