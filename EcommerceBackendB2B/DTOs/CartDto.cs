namespace EcommerceBackendB2B.DTOs
{
    public class CartDto
    {
        public int ID { get; set; }
        public int RetailerID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
    }
}
