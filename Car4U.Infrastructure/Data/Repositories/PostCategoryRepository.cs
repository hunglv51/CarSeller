using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Car4U.Infrastructure.Data.Repositories
{
    public class PostCategoryRepository : BaseRepository<int, PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(CarSellerContext context) : base(context)
        {

        }
        public override IQueryable<PostCategory> ListAll()
        {
        //   return _context.Set<PostCategory>().Include(x => x.Posts.Count);
            return  _context.PostCategories.Include(x => x.Posts);
        }
    }
}