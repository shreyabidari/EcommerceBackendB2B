namespace EcommerceBackendB2B.Models
{
    public class WholesalerCategory
    {
        public int WholesalerCategoryId { get; set; }
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
