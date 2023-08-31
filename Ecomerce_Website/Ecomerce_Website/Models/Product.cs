using System.ComponentModel.DataAnnotations;

namespace Ecomerce_Website.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int product_price { get; set; }
        public string product_image { get; set; }
        public string product_description { get; set; }
        public int category_id { get; set; }
    }
}
