using Microsoft.EntityFrameworkCore;
using Products_Domain.Interfaces;
using Products_Domain.Model;
using System.Linq.Expressions;

namespace Products_Data.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ConnectionContext _context;
        private readonly Dictionary<string, Expression<Func<Products, object>>> _orderByMappings;

        public ProductsRepository(ConnectionContext context)
        {
            _context = context;
            _orderByMappings = new Dictionary<string, Expression<Func<Products, object>>>
            {
                { "Id", p => p.Id },
                { "Name", p => p.Name },
                { "Nome", p => p.Name },
                { "Stock", p => p.Stock },
                { "Estoque", p => p.Stock },
                { "Value", p => p.Value },
                { "Valor", p => p.Value }
            };
        }

        public async Task<List<Products>> GetAll(string? orderBy)
        {
            if (string.IsNullOrWhiteSpace(orderBy) || !_orderByMappings.ContainsKey(orderBy))
            {
                orderBy = "Id";
            }

            IQueryable<Products> query = _context.Products.OrderBy(_orderByMappings[orderBy]);

            return await query.ToListAsync();
        }

        public async Task<Products> GetById(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Products> GetByName(string name)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Name == name);
        }


        public async Task Add(Products product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Products product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Products product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
