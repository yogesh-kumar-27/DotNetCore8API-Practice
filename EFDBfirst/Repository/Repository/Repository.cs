using EFDBfirst.Models;
using EFDBfirst.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFDBfirst.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly NorthwindContext northwindContext;
        private readonly DbSet<T> dbset;

        public Repository(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
            this.dbset = northwindContext.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            await northwindContext.AddAsync(entity);
            await northwindContext.SaveChangesAsync();
            return entity;
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var item = await dbset.ToListAsync();
            return item;
        }

        public async Task<T> GetById(int id)
        {
            var item = await dbset.FindAsync(id);
            return item;
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
