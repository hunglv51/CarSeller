using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car4U.Infrastructure.Data
{
    class BaseRepository<TKey, TVal> : IRepository<TKey, TVal>, IAsyncRepository<TKey,TVal> where TVal : BaseEntity<TKey>
    {
        public TVal Add(TVal entity)
        {
            throw new NotImplementedException();
        }

        public Task<TVal> AddAsync(TVal entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TVal entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TVal entity)
        {
            throw new NotImplementedException();
        }

        public TVal GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TVal> GetByIdAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public TVal GetSingleBySpec(ISpecification<TVal> spec)
        {
            throw new NotImplementedException();
        }

        public Task<TVal> GetSingleBySpecAsync(ISpecification<TVal> spec)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TVal> List(ISpecification<TVal> spec)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TVal> ListAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TVal>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TVal>> ListAsync(ISpecification<TVal> spec)
        {
            throw new NotImplementedException();
        }

        public void Update(TVal entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TVal entity)
        {
            throw new NotImplementedException();
        }
    }
}
