using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceBackendB2B.Models
{
    public class Sales
    {
        public int ID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }

        // Navigation properties
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }
        public int PaymentMethodID { get; set; }
        public virtual PaymentMethod PaymentMethod { get;}
        public virtual ICollection<SalesProductDetails> ProductDetails { get; set; }   }
}
