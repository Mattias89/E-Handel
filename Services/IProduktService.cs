using E_Handel.Models;

namespace E_Handel.Services
{
    public interface IProduktService
    {
        IEnumerable<Produkt> GetAllProducts();
        Produkt GetProductById(int productId);
        void AddProduct(Produkt product);
        void UpdateProduct(Produkt product);
        void DeleteProduct(int productId);
    }
}
