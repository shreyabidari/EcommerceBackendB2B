namespace EcommerceBackendB2B.Models
{
    public class SalesProductDetails
    {
        public int ID { get; set; }
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        //public  Sales Sale { get; set; }
        public Product Product { get; set; }
    }
}
//Attributes: ID, SalesID, ProductID, Quantity, TotalPrice, etc.
//Relationships: Many - to - One with Sales, 
//    Many-to-One with Product.