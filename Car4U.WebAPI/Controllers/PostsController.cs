using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;
using Car4U.Application.Services;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Car4U.Application.ViewModels;
using System;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class PostsController : ControllerBase
    {
        const int PageMargin = 10;
        private PageViewModel pageInfo = new PageViewModel(10);
        private readonly PostViewModelService _postService;
        public PostsController(CarSellerContext context, IMapper mapper)
        {
            var unitOfWork = new UnitOfWork(context);
            var postRepository = new PostRepository(context);
            _postService = new PostViewModelService(unitOfWork, postRepository, mapper);
            
        }
        
        [HttpGet]
        public async Task<ListPostViewModel> Get(string brandName,int pageIndex = 1){
            if(brandName != null)
            {
                return (await _postService.GetByBrandName(brandName));
            }
            pageInfo.PageIndex = pageIndex;
            return (await _postService.GetNewestPostViewModel(pageInfo));
        }
        [HttpGet("{id}")]
        [Route("GetPost")]
        public async Task<PostViewModel> Get(Guid id){
            return (await _postService.GetEntity(id));
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PostViewModel postViewModel)
        {
            // await _postService.CreateEntity(postViewModel);
            // return CreatedAtRoute("GetPost", new {id = postViewModel.Id}, postViewModel);
            return  Ok();
        }
    }
}