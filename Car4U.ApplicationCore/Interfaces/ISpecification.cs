using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Car4U.ApplicationCore.Interfaces
{
    public class ISpecification<T>
    {
        Expression<Func<T, bool>> Criterial { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
    }
}
