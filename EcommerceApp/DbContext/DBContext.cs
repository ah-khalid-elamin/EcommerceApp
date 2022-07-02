using Microsoft.EntityFrameworkCore;
using EcommerceApp.Models;

namespace EcommerceApp.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext > options) :base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Order { get; set; }

    }
}
