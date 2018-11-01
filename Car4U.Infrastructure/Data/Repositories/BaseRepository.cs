using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4U.Infrastructure.Data.Repositories
{
    class BaseRepository<TKey, TVal> : IRepository<TKey, TVal>, IAsyncRepository<TKey,TVal> where TVal : BaseEntity<TKey>
    {
        private readonly CarSellerContext _context;
        private DbSet<TVal> _dbSet => _context.Set<TVal>();
        public  IQueryable<TVal> _entities => _dbSet.AsQueryable();
        public BaseRepository(CarSellerContext context)
        {
            _context = context;
        }
        public virtual void Add(TVal entity)
        {
            _entities.Append(entity);
        }

        public virtual async Task AddAsync(TVal entity)
        {
            _entities.Append(entity);
        }

        public virtual void Delete(TVal entity)
        {
            _entities.
        }

        public virtual Task DeleteAsync(TVal entity)
        {
            throw new NotImplementedException();
        }

        public virtual TVal GetById(TKey id) => _context.Set<TVal>().Find(id);

        public virtual async Task<TVal> GetByIdAsync(TKey id)
        {
            return await _context.Set<TVal>().FindAsync(id);
        }

        public virtual TVal GetSingleBySpec(ISpecification<TVal> spec)
        {
            return List(spec).FirstOrDefault();
        }

        public virtual async Task<TVal> GetSingleBySpecAsync(ISpecification<TVal> spec)
        {
            return (await ListAsync(spec)).FirstOrDefault();
        }

        public virtual IEnumerable<TVal> List(ISpecification<TVal> spec)
        {
            var queryableResultWithIncludes = spec.Includes
            .Aggregate(_context.Set<TVal>().AsQueryable(), (current, include) => current.Include(include));
            
            var resultIncludeStrings = queryableResultWithIncludes.Where(spec.Criterial).AsEnumerable();
            return resultIncludeStrings;
        }

        public virtual IEnumerable<TVal> ListAll()
        {
            return _context.Set<TVal>().AsEnumerable();
        }

        public virtual async Task<IEnumerable<TVal>> ListAllAsync()
        {
            return (await _context.Set<TVal>().ToListAsync());
        }

        public virtual async Task<IEnumerable<TVal>> ListAsync(ISpecification<TVal> spec)
        {
            var queryableResultWithIncludes = spec.Includes
            .Aggregate(_context.Set<TVal>().AsQueryable(), (current, include) => current.Include(include));
            
            var resultIncludeStrings = await queryableResultWithIncludes.Where(spec.Criterial).ToListAsync();
            return  resultIncludeStrings;
        }

        public virtual void Update(TVal entity)
        {
            _context.Set<TVal>().Update(entity);

        }

        public virtual async Task UpdateAsync(TVal entity)
        {
            _context.Set<TVal>().Update(entity);
        }
    }
}
