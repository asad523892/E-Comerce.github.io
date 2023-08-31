using System.ComponentModel.DataAnnotations;

namespace Ecomerce_Website.Models
{
    public class FAQs
    {
        [Key]
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

    }
}
