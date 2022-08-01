namespace BlazorServerCRUD.Data
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task LoadProducts();
        Task<Product> GetSingleProduct(int UrunId);
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product, int UrunId);
        Task DeleteProduct(int UrunId);
        
    }
}
