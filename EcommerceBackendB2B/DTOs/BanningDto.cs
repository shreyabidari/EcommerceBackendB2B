namespace EcommerceBackendB2B.DTOs
{
    public class BanningDto
    {
        public int ID { get; set; }
        public int WholesalerID { get; set; }
        public string BanningType { get; set; }
        public DateTime BanDate { get; set; }
    }
}
