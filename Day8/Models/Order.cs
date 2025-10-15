using System.ComponentModel.DataAnnotations;

namespace WebApp_Day8.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        

        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
