using Microsoft.AspNetCore.Mvc;

namespace BlazorServerCRUD.Data
{
    public class Product
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; } = string.Empty;
        public string Renk { get; set; } = string.Empty;
        public int Fiyat { get; set; }

    }
}
