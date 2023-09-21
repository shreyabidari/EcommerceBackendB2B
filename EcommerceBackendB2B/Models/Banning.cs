namespace EcommerceBackendB2B.Models
{
    public class Banning
    {
        public int ID { get; set; }
        public int WholesalerID { get; set; }
        public string Status { get; set; }
        public DateTime TimeStamp  { get; set; }

        // Navigation property
        public Wholesaler Wholesaler { get; set; }
    }
}

