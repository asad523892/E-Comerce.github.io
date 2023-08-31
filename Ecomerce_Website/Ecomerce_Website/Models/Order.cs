using System.ComponentModel.DataAnnotations;

namespace Ecomerce_Website.Models
{
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        public int cart_id { get; set; }
        public string status { get; set; }
    }
}
