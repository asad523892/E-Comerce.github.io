using Microsoft.EntityFrameworkCore;

namespace Ecomerce_Website.Models
{
    public class Mycontext :DbContext
    {
        public Mycontext(DbContextOptions<Mycontext> options ): base(options)
        {
                
        }
        public DbSet<Admin> tbl_admin { get; set; }

        public DbSet<Customer> tbl_customer { get; set; }
        public DbSet<Category> tbl_categories { get; set; }
        public DbSet<Product> tbl_product { get; set; }
        public DbSet<Cart> tbl_cart { get; set; }
        public DbSet<Order> tbl_order { get; set; }
        public DbSet<Feedback> tbl_feedback { get; set; }
        public DbSet<FAQs> tbl_FAQs { get; set; }



    }


}
