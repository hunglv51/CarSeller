using Car4U.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IRepository<TKey, TVal> where TVal : BaseEntity<TKey>
    {
        TVal GetById(TKey id);
        TVal GetSingleBySpec(ISpecification<TVal> spec);
        IEnumerable<TVal> ListAll();
        IEnumerable<TVal> List(ISpecification<TVal> spec);
        void Add(TVal entity);
        void Update(TVal entity);
        void Delete(TVal entity);
    }
}
