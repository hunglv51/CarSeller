using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class PostCategoryRepository : BaseRepository<int, PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(CarSellerContext context) : base(context)
        {
        }
    }
}