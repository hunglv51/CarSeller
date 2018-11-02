using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class PostRepository : BaseRepository<Guid, Post>, IPostRepository
    {
        public PostRepository(CarSellerContext context) : base(context)
        {
        }

    }
}
