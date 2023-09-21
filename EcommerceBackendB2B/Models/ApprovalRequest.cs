namespace EcommerceBackendB2B.Models
{
    public class ApprovalRequest
    {
        public int Id { get; set; }
        public string Status { get; set; }

        //navigation  for Retailer
        public int RetailerId { get; set; }
        public virtual Retailer Retailer { get; set; }

        //navigation for Wholesaler
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

       

    }
}
