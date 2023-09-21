namespace EcommerceBackendB2B.Models
{
    public class SalesReturnDetails
    {
        public int ID { get; set; }
        public int Quantity { get; set;}
        public decimal RefundAmount { get; set;}

        // Navigation property for the Return associated with this return product
        public int SalesReturnId { get; set; }
        public virtual SalesReturn Return { get; set; }

        // Navigation property for the Product associated with this return product
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
