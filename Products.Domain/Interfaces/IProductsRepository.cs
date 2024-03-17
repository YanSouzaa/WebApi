using Products_Domain.Model;

namespace Products_Domain.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Products>> GetAll(string? orderBy);
        Task<Products> GetById(int id);
        Task<Products> GetByName(string name);
        Task Add(Products product);
        Task Delete(Products product);
        Task Update(Products product);
    }
}
