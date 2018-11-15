using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;
using Car4U.Application.Services;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class PostsController : ControllerBase
    {
        const int PageMargin = 10;
        private readonly PostViewModelService _postService;
        public PostsController(CarSellerContext context, IMapper mapper)
        {
            var unitOfWork = new UnitOfWork(context);
            var postRepository = new PostRepository(context);
            _postService = new PostViewModelService(unitOfWork, postRepository, mapper);
        }
        
        // [HttpGet]
        // public async Task<IEnumerable<Post>> Get(int pageIndex = 1){
        //     return (await _postService.Get(null, PageMargin, pageIndex));
        // }

    }
}