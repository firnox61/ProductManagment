using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Data
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly NavigationManager _navigationManager;

        public ProductService(DataContext context, NavigationManager navigationManager)
        {
            _context = context;
            _navigationManager = navigationManager;
            _context.Database.EnsureCreated();//ilgili context için databasein var olup olmadığını kontrol eder
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("productspage");
        }

        public async Task DeleteProduct(int UrunId)
        {
            var dbProduct = await _context.Products.FindAsync(UrunId);
            if (dbProduct == null)
                throw new Exception("No product here. :/");

            _context.Products.Remove(dbProduct);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("productspage");
        }

        public async Task<Product> GetSingleProduct(int UrunId)
        {
            var product = await _context.Products.FindAsync(UrunId);
            if (product == null)
                throw new Exception("No product here. :/");
            return product;
        }

        public async Task LoadProducts()
        {
            Products = await _context.Products.ToListAsync();
        }

       

        public async Task UpdateProduct(Product product, int UrunId)
        {
            var dbProduct = await _context.Products.FindAsync(UrunId);
            if (dbProduct == null)
                throw new Exception("No product here. :/");

            dbProduct.UrunAdi = product.UrunAdi;
            dbProduct.Renk = product.Renk;
            dbProduct.Fiyat= product.Fiyat; 

            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("productspage");
        }
    }
}
