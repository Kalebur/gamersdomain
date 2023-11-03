using gamersdomain.Shared;
using Microsoft.EntityFrameworkCore;

namespace gamersdomain.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { 
                    ProductId = 1,
                    Name = "Test Product #1",
                    Description = "Test product #1! The finest test product known to man!",
                    CategoryId = 1,
                    Price = 1499.99m,
                    ImageUrl = "/images/computers/comp1.png"
                },
                new Product() { 
                    ProductId = 2, 
                    Name = "Test Product #2", 
                    Description = "Test product #2! The second finest test product known to man!",
                    CategoryId = 2,
                    Price = 149.99m,
                    ImageUrl = "/images/mice/m3.png"
                },
                new Product() { 
                    ProductId = 3, 
                    Name = "Test Product #3", 
                    Description = "Test product #3! We don't really like to talk about test product #3. Gary made that one. Gary was a WEIRD dude...",
                    CategoryId = 4,
                    Price = 199.99m,
                    ImageUrl = "/images/headsets/hs6.png"
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Computers", Url="computers"},
                new Category() { CategoryId = 2, Name = "Keyboards", Url="keyboards"},
                new Category() { CategoryId = 3, Name = "Mice", Url="mice"},
                new Category() { CategoryId = 4, Name = "Headsets", Url="headsets"}
                );
        }
    }
}
