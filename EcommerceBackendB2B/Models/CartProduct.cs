namespace EcommerceBackendB2B.Models
{
    public class CartProduct
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int CartProductDetailsId { get; set; }
        public virtual CartProductDetails CartProductDetails { get; set; }

    }
}