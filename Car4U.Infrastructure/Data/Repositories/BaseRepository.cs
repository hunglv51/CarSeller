using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4U.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository<TKey, TVal> : IRepository<TKey,TVal> where TVal : class
    {
        private readonly CarSellerContext _context;
        private DbSet<TVal> _dbSet => _context.Set<TVal>();
        

        private BaseRepository(){
            
        }
        public BaseRepository(CarSellerContext context)
        {
            _context = context;
        }
        public virtual async Task Add(TVal entity)
        {
            await _dbSet.AddAsync(entity);
        }

      

        public virtual void Delete(TVal entity)
        {
            _dbSet.Remove(entity);
        }

      

        // public virtual TVal GetById(TKey id) => _context.Set<TVal>().Find(id);

        public virtual async Task<TVal> GetById(TKey id)
        {
            return await _context.Set<TVal>().FindAsync(id);
        }

        // public virtual TVal GetSingleBySpec(ISpecification<TVal> spec)
        // {
        //     return List(spec).FirstOrDefault();
        // }

        public virtual async Task<TVal> GetSingleBySpec(ISpecification<TVal> spec)
        {
            return (await List(spec).ToListAsync()).FirstOrDefault();
        }

        // public virtual IEnumerable<TVal> List(ISpecification<TVal> spec)
        // {
        //     var queryableResultWithIncludes = spec.Includes
        //     .Aggregate(_context.Set<TVal>().AsQueryable(), (current, include) => current.Include(include));
            
        //     var resultIncludeStrings = queryableResultWithIncludes.Where(spec.Criterial).AsEnumerable();
        //     return resultIncludeStrings;
        // }

        // public virtual IEnumerable<TVal> ListAll()
        // {
        //     return _context.Set<TVal>().AsEnumerable();
        // }

        public virtual IQueryable<TVal> ListAll()
        {
          return _context.Set<TVal>();
        }

        public IQueryable<TVal> List(ISpecification<TVal> spec)
        {
            var queryableResultWithIncludes = spec.Includes
            .Aggregate(_context.Set<TVal>().AsQueryable(), (current, include) => current.Include(include));
            
            return queryableResultWithIncludes.Where(spec.Criterial);
        }

        public virtual void Update(TVal entity)
        {
            // _dbSet.Attach(entity);   
            // _context.Entry(entity).State = EntityState.Modified;            
            _context.Set<TVal>().Update(entity);

        }

       
    }
}
