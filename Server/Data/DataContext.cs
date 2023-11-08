using gamersdomain.Shared;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

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
                    ImageUrl = "/images/mice/m1.png"
                },
                new Product() { 
                    ProductId = 3, 
                    Name = "Test Product #3", 
                    Description = "Test product #3! We don't really like to talk about test product #3. Gary made that one. Gary was a WEIRD dude...",
                    CategoryId = 4,
                    Price = 199.99m,
                    ImageUrl = "/images/headsets/hs1.png"
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Test Product #4",
                    Description = "Test Product #4! The fourth finest product known to man!",
                    CategoryId = 3,
                    Price = 74.99m,
                    ImageUrl = "/images/keyboards/kb1.jpg"
                },
                new Product()
                {
                    ProductId = 5,
                    Name = "Test Product #5",
                    Description = "An incredibly powerful gaming system!",
                    CategoryId = 1,
                    Price = 2499.99m,
                    ImageUrl = "/images/computers/comp2.png"
                },
                new Product()
                {
                    ProductId = 6,
                    Name = "Test Product #6",
                    Description = "An incredibly powerful gaming system!",
                    CategoryId = 1,
                    Price = 3299.99m,
                    ImageUrl = "/images/computers/comp3.png"
                },
                new Product()
                {
                    ProductId = 7,
                    Name = "Test Product #7",
                    Description = "An incredibly powerful gaming system!",
                    CategoryId = 1,
                    Price = 999.99m,
                    ImageUrl = "/images/computers/comp4.png"
                },
                new Product()
                {
                    ProductId = 8,
                    Name = "Test Product #8",
                    Description = "A stylish mouse for all your gaming needs!",
                    CategoryId = 3,
                    Price = 49.99m,
                    ImageUrl = "/images/mice/m2.png"
                },
                new Product()
                {
                    ProductId = 9,
                    Name = "Test Product #9",
                    Description = "A stylish mouse for all your gaming needs!",
                    CategoryId = 3,
                    Price = 69.99m,
                    ImageUrl = "/images/mice/m3.png"
                },
                new Product()
                {
                    ProductId = 10,
                    Name = "Test Product #10",
                    Description = "A stylish mouse for all your gaming needs!",
                    CategoryId = 3,
                    Price = 119.99m,
                    ImageUrl = "/images/mice/m4.png"
                },
                new Product()
                {
                    ProductId = 11,
                    Name = "Gamers Dominion 'Minion'",
                    Description = "A stylish keyboard for all your gaming needs!",
                    CategoryId = 2,
                    Price = 49.99m,
                    ImageUrl = "/images/keyboards/kb2.jpg"
                },
                new Product()
                {
                    ProductId = 12,
                    Name = "Gamers Dominion 'Afterburner'",
                    Description = "A stylish keyboard for all your gaming needs!",
                    CategoryId = 2,
                    Price = 219.99m,
                    ImageUrl = "/images/keyboards/kb3.jpg"
                },
                new Product()
                {
                    ProductId = 13,
                    Name = "Gamers Dominion 'Bobcat'",
                    Description = "A stylish keyboard for all your gaming needs!",
                    CategoryId = 2,
                    Price = 19.99m,
                    ImageUrl = "/images/keyboards/kb4.jpg"
                },
                new Product()
                {
                    ProductId = 14,
                    Name = "Gamers Dominion 'Sunstorm'",
                    Description = "A stylish headset for all your gaming needs!",
                    CategoryId = 4,
                    Price = 49.99m,
                    ImageUrl = "/images/headsets/hs2.png"
                },
                new Product()
                {
                    ProductId = 15,
                    Name = "Gamers Dominion 'Honeybadger'",
                    Description = "A stylish headset for all your gaming needs!",
                    CategoryId = 4,
                    Price = 199.99m,
                    ImageUrl = "/images/headsets/hs3.png"
                },
                new Product()
                {
                    ProductId = 16,
                    Name = "Gamers Dominion 'Glory'",
                    Description = "A stylish headset for all your gaming needs!",
                    CategoryId = 4,
                    Price = 249.99m,
                    ImageUrl = "/images/headsets/hs4.png"
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
