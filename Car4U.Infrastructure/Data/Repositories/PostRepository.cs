using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class PostRepository : BaseRepository<Guid, Post>, IPostRepository
    {
        public PostRepository(CarSellerContext context) : base(context)
        {
        }

    }
}
