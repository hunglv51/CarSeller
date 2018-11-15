using Car4U.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4U.Domain.Interfaces
{
    public interface IRepository<TKey, TVal> 
    {
        Task<TVal> GetById(TKey id);
        Task<TVal> GetSingleBySpec(ISpecification<TVal> spec);
        IQueryable<TVal> ListAll();
        IQueryable<TVal> List(ISpecification<TVal> spec);
        Task Add(TVal entity);
        void Update(TVal entity);
        void Delete(TVal entity);
    }
}
