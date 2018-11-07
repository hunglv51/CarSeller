using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Car4U.ApplicationCore.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IAppLogger<IdentityService> _logger;
        public async Task AddUser(AppUser user)
        {
            await _appUserRepository.Add(user);
            await _unitOfWork.CommitAsync();

        }

        public async Task<AppUser> GetUserAsync(Guid id)
        {
            return (await _appUserRepository.GetById(id));

        }

        public async Task UpdateUser(AppUser user)
        {
            _appUserRepository.Update(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteUser(Guid id)
        {
            var user = await GetUserAsync(id);
            _appUserRepository.Delete(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<AppUser>> ListUser(int pageMargin = 10, int pageIndex = 1)
        {
            return (await _appUserRepository.ListAll().OrderBy(x => x.UserName).Skip((pageIndex - 1) * pageMargin).Take(pageMargin).ToListAsync());
        }
    }    
}