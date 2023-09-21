namespace EcommerceBackendB2B.Models
{
    public class CartProductDetails
    {
        public int ID { get; set; }    
        
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public int CartID { get; set; }
        public Cart Cart { get; set; }
      

        // Navigation property for the many-to-many relationship with Products
        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}

