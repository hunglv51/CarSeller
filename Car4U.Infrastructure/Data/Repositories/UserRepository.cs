using System;
using Car4U.ApplicationCore.Entities;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class UserRepository : BaseRepository<Guid, AppUser>
    {
        public UserRepository(CarSellerContext context) : base(context)
        {
        }
    }
}