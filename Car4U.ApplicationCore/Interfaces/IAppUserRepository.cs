using System;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IAppUserRepository : IRepository<Guid, AppUser>
    {
        
    }
}