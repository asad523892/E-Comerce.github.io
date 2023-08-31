using System.ComponentModel.DataAnnotations;

namespace Ecomerce_Website.Models
{
    public class Cart
    {
        [Key]
        public int cart_id { get; set; }
        public int prod_id { get; set; }
        public int quantity { get; set; }
        public int cat_id { get; set; }
        public string status { get; set; }

    }
}
