using System;
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
    public class PostCategoryController : ControllerBase
    {
        private PostCategoryService _postCategoryService;
        public PostCategoryController(CarSellerContext context, IAppLogger<PostCategoryService> logger)
        {
            var repository = new PostCategoryRepository(context);
            var uow = new UnitOfWork(context);
            _postCategoryService = new PostCategoryService(uow, logger, repository);    
        }
        [HttpGet]
        public async Task<IEnumerable<PostCategory>> GetAll()
        {
            return (await _postCategoryService.GetListPostCategories());
        }

        
        [HttpGet("{id}", Name = "GetPostCategory")]
        public async Task<ActionResult<PostCategory>> GetById(int id)
        {
            var postCategory = await _postCategoryService.GetPostCategory(id);
            if(postCategory == null)
                return NotFound();
            return postCategory;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostCategory postCategory)
        {
            await _postCategoryService.CreatePostCategory(postCategory);
            
            return CreatedAtRoute("GetPostCategory", new {id = postCategory.Id}, postCategory);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PostCategory postCategory){
            var category = await _postCategoryService.GetPostCategory(id);
            if(category == null)
                return NotFound();
            postCategory.Id = id;
            await _postCategoryService.UpdatePostCategory(postCategory);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var category = await _postCategoryService.GetPostCategory(id);
            if(category == null)
                return NoContent();

            await _postCategoryService.DeletePostCategory(id);
            return NoContent();
        }
    }
}