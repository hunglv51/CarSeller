using Car4U.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IRepository<TKey, TVal> where TVal : BaseEntity<TKey>
    {
        Task<TVal> GetById(TKey id);
        Task<TVal> GetSingleBySpec(ISpecification<TVal> spec);
        IQueryable<TVal> ListAll();
        IQueryable<TVal> List(ISpecification<TVal> spec);
        void Add(TVal entity);
        void Update(TVal entity);
        void Delete(TVal entity);
    }
}
