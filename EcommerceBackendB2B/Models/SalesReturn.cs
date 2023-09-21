namespace EcommerceBackendB2B.Models
{
    public class SalesReturn
    {
        public int ID { get; set; }
        public string Reasons { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnStatus { get; set; }
        public decimal TotalRefundAmount { get; set; }

       // Navigation property for the Customer associated with this return
        public int RetailertId { get; set; }
        public virtual Retailer Retailer { get; set; }

        // Navigation property for the Wholesaler associated with this return
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

        // Collection of ReturnProduct items associated with this return
        public virtual ICollection<SalesReturnDetails> SalesReturnDetails { get; set; }
    }
}
