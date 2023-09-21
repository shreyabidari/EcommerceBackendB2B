namespace EcommerceBackendB2B.Models
{
    public class Commission
    {
        public int ID { get; set; }
        
        public decimal CommissionAmount { get; set; }


        // Navigation properties
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

    }
}
//Attributes: ID, WholesalerID, AdminID, Amount, 
//    Status (Paid / Unpaid), etc.
//Relationships: Many - to - One with Wholesaler, 
//    Many-to-One with Admin.
