namespace EcommerceBackendB2B.DTOs
{
    public class ProductDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }
    }
}
