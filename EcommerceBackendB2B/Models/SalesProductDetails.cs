namespace EcommerceBackendB2B.Models
{
    public class SalesProductDetails
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        // Navigation property for the Sales associated with this SalesProduct
        public int SalesId { get; set; }
        public virtual Sales Sales { get; set; }
        // Navigation property for the Product associated with this SalesProduct
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
