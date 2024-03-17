using Microsoft.EntityFrameworkCore;
using Products_Domain.Model;

namespace Products_Data
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    Id = 1,
                    Name = "Abacate",
                    Stock = 50,
                    Value = 5
                },
                new Products
                {
                    Id = 2,
                    Name = "Biscoito",
                    Stock = 100,
                    Value = 5
                }, new Products
                {
                    Id = 3,
                    Name = "Manga",
                    Stock = 80,
                    Value = 6
                }, new Products
                {
                    Id = 4,
                    Name = "Cenoura",
                    Stock = 90,
                    Value = 4
                }, new Products
                {
                    Id = 5,
                    Name = "Alface",
                    Stock = 30,
                    Value = 3
                }, new Products
                {
                    Id = 6,
                    Name = "Uva",
                    Stock = 200,
                    Value = 15
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
