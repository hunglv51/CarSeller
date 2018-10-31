using System;
using System.Collections.Generic;
using System.Text;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IPostRepository<Guid, Post>: IRepository<Guid, BaseEntity<Guid>> , IAsyncRepository<Guid, BaseEntity<Guid>>
    {
        
    }
}
