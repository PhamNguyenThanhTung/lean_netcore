using System.ComponentModel.DataAnnotations;

namespace WebApp_Day8.Models
{
    public class Customer
    {
        [Key]
        public string Id { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public bool Activated { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
