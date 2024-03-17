using Products_Data;
using Products_Data.Exceptions;
using Products_Domain.Interfaces;
using Products_Domain.Model;
using Products_Domain.ViewModel;

namespace WebApi.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productRepository;
        private readonly ConnectionContext _context;

        public ProductsService(IProductsRepository productRepository, ConnectionContext context)
        {
            _productRepository = productRepository;
            _context = context;
        }

        public async Task<List<Products>> GetAll(string? orderBy)
        {
            return await _productRepository.GetAll(orderBy);
        }

        public async Task<Products> GetById(int id)
        {
            var product = await _productRepository.GetById(id);
            if (product == null)
                throw new ProductNotFoundException("ID do produto não encontrado!");

            return product;
        }
        public async Task<Products> GetByName(string name)
        {
            var product = await _productRepository.GetByName(name);
            if (product == null)
                throw new ProductNotFoundException("Nome do produto não encontrado!");

            return product;
        }

        public async Task Add(CreateProductViewModel product)
        {
            if (product.Stock < 0)
                throw new ProductNotFoundException("O estoque não pode ser negativo!");

            var newProduct = new Products
            {
                Name = product.Name,
                Stock = product.Stock,
                Value = product.Value
            };
            await _productRepository.Add(newProduct);
        }

        public async Task Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                throw new ProductNotFoundException("ID do produto não encontrado!");

            await _productRepository.Delete(product);
        }

        public async Task Update(UpdateProductsViewModel product)
        {
            var productsExistant = await _context.Products.FindAsync(product.Id);

            if (productsExistant == null)
                throw new ProductNotFoundException("Produto não encontrado!");

            productsExistant.Name = product.Name;
            productsExistant.Stock = product.Stock;
            productsExistant.Value = product.Value;

            await _productRepository.Update(productsExistant);
        }
    }
}