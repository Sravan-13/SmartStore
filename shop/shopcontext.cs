using Microsoft.EntityFrameworkCore;
using shop.Models;

namespace shop
{
    public class shopcontext:DbContext
    {
        public shopcontext()
        {

        }
        public shopcontext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<users> users { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<orders> orders { get; set; }
        public DbSet<BillingAddress> BillingAddresses { get; set; }
        public DbSet<demo> demos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=SRAVAN;initial catalog=SMARTSTORE100000;integrated security=true");
        }
    }
}
