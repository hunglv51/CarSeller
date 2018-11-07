using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using Car4U.ApplicationCore.Services;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class PostsController : ControllerBase
    {
        const int PageMargin = 10;
        private readonly PostService _postService;
        public PostsController(CarSellerContext context, IAppLogger<PostService> logger)
        {
            var unitOfWork = new UnitOfWork(context);
            var postRepository = new PostRepository(context);
            _postService = new PostService(unitOfWork, logger, postRepository);
        }
        
        [HttpGet]
        public async Task<IEnumerable<Post>> Get(int pageIndex = 1){
            return (await _postService.GetNewestPostsAsync(null, PageMargin, pageIndex));
        }

    }
}