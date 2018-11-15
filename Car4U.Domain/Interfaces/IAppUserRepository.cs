using System;
using Car4U.Domain.Entities;

namespace Car4U.Domain.Interfaces
{
    public interface IAppUserRepository : IRepository<Guid, AppUser>
    {
        
    }
}