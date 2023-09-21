namespace EcommerceBackendB2B.DTOs
{
    public class ApprovalRequestDto
    {
        public int ID { get; set; }
        public int RetailerID { get; set; }
        public string RequestType { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
