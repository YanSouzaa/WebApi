using Products_Domain.Model;
using Products_Domain.ViewModel;

namespace Products_Domain.Interfaces
{
    public interface IProductsService
    {
        Task<List<Products>> GetAll(string? orderBy);
        Task<Products> GetById(int id);
        Task<Products> GetByName(string name);
        Task Add(CreateProductViewModel product);
        Task Delete(int id);
        Task Update(UpdateProductsViewModel product);
    }
}
