using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.Domain.Entities
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

        
    }
}
