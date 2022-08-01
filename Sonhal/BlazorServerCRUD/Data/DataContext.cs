using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get;set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(pi =>new { pi.UrunId } );
            //modelBuilder.Entity<Product>().Has
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        UrunId = 1,
                        UrunAdi = "Msi Laptop",
                        Renk = "Neon Gri",
                        Fiyat=156,
                        
                    },
                    new Product
                    {
                        UrunId = 2,
                        UrunAdi = "Lenova m30",
                        Renk = "Siyah",
                        Fiyat = 1886,
                        
                    }
                );
        }

       
    }
}
