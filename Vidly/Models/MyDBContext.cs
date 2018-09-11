using System.Data.Entity;

namespace Vidly.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public MyDbContext()
        {
        }
    }
}