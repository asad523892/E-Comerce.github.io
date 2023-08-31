using System.ComponentModel.DataAnnotations;

namespace Ecomerce_Website.Models
{
    public class Feedback
    {
        [Key]
        public int feedback_id { get; set; }
        public string feedback_username { get; set; }
        public string feedback_message { get; set; }
    }
}