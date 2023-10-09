using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<IReadOnlyList<Product>> FindProductAsync(Expression<Func<Product, bool>> predicate);
        Task<Product> GetByIdAsync(int id);
        Task AddProductAsync(string userId, Product entity);
        Task DeleteProduct(int productId);
        Task UpdateProduct(Product entity);
    }


}
