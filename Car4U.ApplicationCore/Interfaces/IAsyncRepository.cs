using Car4U.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<TKey, TVal> where TVal : BaseEntity<TKey>
    {
        Task<TVal> GetByIdAsync(TKey id);
        Task<TVal> GetSingleBySpecAsync(ISpecification<TVal> spec);
        Task<IEnumerable<TVal>> ListAllAsync();
        Task<IEnumerable<TVal>> ListAsync(ISpecification<TVal> spec);
        void Add(TVal entity);
        void Update(TVal entity);
        void Delete(TVal entity);
        
    }
}
