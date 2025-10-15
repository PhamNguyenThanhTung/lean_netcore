using System.ComponentModel.DataAnnotations;

namespace WebApp_Day8.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Image { get; set; }
        public DateTime ProductDate { get; set; }
        public int CategoryId { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
