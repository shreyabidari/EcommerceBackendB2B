namespace EcommerceBackendB2B.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property for the many-to-many relationship with wholesalers
        public virtual ICollection<WholesalerCategory> WholesalerCategories { get; set; }
        // Navigation property for the one-to-many relationship with Products
        public virtual ICollection<Product> Products { get; set; }
    }
}
