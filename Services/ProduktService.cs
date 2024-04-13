using Dapper;
using E_Handel.Extras;
using E_Handel.Models;
using Microsoft.Data.SqlClient;

namespace E_Handel.Services
{
    public class ProduktService : IProduktService
    {
        private readonly SqlConnection _connectionString;
        public ProduktService(IDBContext dBContext)
        {
            _connectionString = dBContext.GetConnection();
        }

        public void AddProduct(Produkt product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produkt> GetAllProducts()
        {
            using (_connectionString)
            {
                return _connectionString.Query<Produkt>("SELECT * FROM Produkt");
            }
        }

        public Produkt GetProductById(int produktId)
        {
            using (_connectionString)
            {
                return _connectionString.Query<Produkt>
                    ("SELECT * FROM Produkt WHERE Id = @ProduktId", new { ProduktId = produktId }).FirstOrDefault();
            }
        }

        public void UpdateProduct(Produkt product)
        {
            throw new NotImplementedException();
        }
    }
}
