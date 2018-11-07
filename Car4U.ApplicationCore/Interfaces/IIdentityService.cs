using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IIdentityService 
    {
        Task AddUser(AppUser user);
        Task<AppUser> GetUserAsync(Guid id);
        Task UpdateUser(AppUser user);
        Task DeleteUser(Guid id);
        Task<IEnumerable<AppUser>> ListUser(int pageMargin, int pageIndex);
    }
}