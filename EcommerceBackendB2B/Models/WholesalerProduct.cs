namespace EcommerceBackendB2B.Models
{
    public class WholesalerProduct
    {
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
