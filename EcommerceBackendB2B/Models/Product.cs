namespace EcommerceBackendB2B.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        // Foreign key property for the Category associated with this product
        public int CategoryId { get; set; }

        // Navigation property for the Category associated with this product
        public virtual Category Category { get; set; }

        // Navigation property for the many-to-many relationship with  CartproductDetails
        public virtual ICollection<CartProduct> CartProducts { get; set; }
        // Navigation property for the many-to-many relationship with wholesalers
        public virtual ICollection<WholesalerProduct> WholesalerProducts { get; set; }

        // Navigation property for the one-to-many relationship with SalesProduct
        public virtual ICollection<SalesProductDetails> SalesProductDetails { get; set; }

        // Navigation property for Returns associated with this product
        public virtual ICollection<SalesReturnDetails> SalesReturnDetails { get; set; }

    }
}

