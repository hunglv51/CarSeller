using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Car4U.ApplicationCore.Interfaces;

namespace Car4U.ApplicationCore.Specifications
{
    public abstract class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification(Expression<Func<T, bool>> criterial)
        {
            Criterial = criterial;
        }

        public List<Expression<Func<T, object>>> Includes { get;} = new List<Expression<Func<T, object>>>();
        public List<string> IncludeStrings { get;} = new List<string>();

        public Expression<Func<T, bool>> Criterial { get;}

        protected virtual void AddInclude(Expression<Func<T, object>> includeExpression){
            Includes.Add(includeExpression);
        }
        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
    }
}