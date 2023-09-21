using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceBackendB2B.Models
{
    public class Sales
    {
        public int ID { get; set; }
        public int RetailerID { get; set; }
        public int WholesalerId { get; set; }
        public int PaymentMethodID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }

        // Navigation properties
        //public Retailer Retailer { get; set; }
        ////public  Wholesaler? Wholesaler { get; set; }
        //public PaymentMethod PaymentMethod { get; set; }
        //public List<SalesProductDetails> SalesProductDetails { get; set; }

    }
}
//Attributes: ID, RetailerID, WholesalerID, PaymentMethodID, 
//    TotalAmount, SaleDate, etc.
//Relationships: Many - to - One with Retailer, 
//    Many-to-One with Wholesaler, 
//    One-to-Many with SalesProductDetails.
