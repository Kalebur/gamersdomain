using gamersdomain.Shared;
using Microsoft.EntityFrameworkCore;

namespace gamersdomain.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, Name = "Test Product #1", Description = "Test product #1! The finest test product known to man!"},
                new Product() { ProductId = 2, Name = "Test Product #2", Description = "Test product #2! The second finest test product known to man!"},
                new Product() { ProductId = 3, Name = "Test Product #3", Description = "Test product #3! We don't really like to talk about test product #3. Gary made that one. Gary was a WEIRD dude..."}
            );
        }
    }
}
