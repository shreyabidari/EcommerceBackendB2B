namespace EcommerceBackendB2B.Models
{
    public class CommissionConfig
    {
        public int Id { get; set; }
        public decimal ComissionRate { get; set; }
        public DateTime commisionset { get; set; }
        public decimal UpdateComission { get; set; }

        //Navigation
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

    }
}
