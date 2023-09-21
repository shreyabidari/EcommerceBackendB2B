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

        // Foreign key
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        // Navigation property for the many-to-many relationship with  CartproductDetails
        public virtual ICollection<CartProduct> CartProducts { get; set; }


    }
}
//Attributes: ID, Name, Description, Price, Quantity, 
//    Image, CategoryID, etc.
//Relationships: Many - to - One with Category, 
//    One-to-Many with CartProductDetails, 
//    One-to-Many with SalesProductDetails, 
//    Many-to-Many with Cart (through CartProductDetails),
//    Many - to - Many with Sales(through SalesProductDetails).
