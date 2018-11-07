using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class PostCategoryRepository : BaseRepository<int, PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(CarSellerContext context) : base(context)
        {
        }
    }
}