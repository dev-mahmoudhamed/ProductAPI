using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
        {
            return await _context.Set<Product>()
                .AsNoTracking()
                .Where(x => x.IsDeleted != true)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Product>> FindProductAsync(Expression<Func<Product, bool>> predicate)
        {
            return await _context.Set<Product>()
                .AsNoTracking()
                .Where(x => x.IsDeleted != true)
                .Where(predicate)
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Set<Product>()
                .Where(x => x.IsDeleted != true)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddProductAsync(string userId, Product entity)
        {
            entity.UserId = userId;
            await _context.Set<Product>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProduct(int ProductId)
        {
            //if (_context.Entry(entity).State == EntityState.Detached)
            //{
            //    _context.Set<Product>().Attach(entity);
            //}
            //_context.Set<Product>().Remove(entity);

            var itemToDelete = await _context.Set<Product>().FindAsync(ProductId);
            itemToDelete.IsDeleted = true;
            _context.SaveChanges();
        }

        public async Task UpdateProduct(Product entity)
        {
            // _dbSet.Attach(entity);
            //_context.Entry(entity).State = EntityState.Modified;
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }


    }
}
