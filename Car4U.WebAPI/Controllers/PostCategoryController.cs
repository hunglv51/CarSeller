using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.Domain.Entities;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Car4U.Application.ViewModels;
using Car4U.Domain.Exceptions;
using AutoMapper;
using Car4U.Domain.Enums;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostCategoryController : ControllerBase
    {
        private readonly IMapper _testMapper;
        private PostCategoryViewModelService _postCategoryService;
        private PageViewModel pageInfo = new PageViewModel(10);
        public PostCategoryController(CarSellerContext context, IMapper mapper)
        {
            var repository = new PostCategoryRepository(context);
            var uow = new UnitOfWork(context);
            _testMapper = mapper;
            _postCategoryService = new PostCategoryViewModelService(repository,  uow, mapper);    
        }
        [HttpGet]
        public async Task<IEnumerable<PostCategoryViewModel>> GetAll(int pageIndex = 1)
        {
            // pageInfo.PageIndex = pageIndex;            
            // return (await _postCategoryService.GetListEntities(pageInfo));
            return (await _postCategoryService.GetCategories());
        }
        

        
        [HttpGet("{id}", Name = "GetPostCategory")]
        public async Task<ActionResult<PostCategoryViewModel>> GetById(int id)
        {
            try{
                var postCategoryViewModel = await _postCategoryService.GetEntity(id);
                return postCategoryViewModel;

            }
            catch(EntityNotFoundException<PostCategory>)
            {
                return NotFound();
            }
           
        }

        // public ActionResult<PostCategory> GetById(int id)
        // {
            
        //     var categoryViewModel = new PostCategoryViewModel{
        //         BrandName = "HONDA",
        //         CarType = "SUV",
        //         CarFamily = "CRV",
        //         IsImported =  true,
        //         IsUsed =  true,
        //         DriveType = "RearWheel",
        //         Transmission = "Mix"
        //     };
        //     PostCategory category = _testMapper.Map<PostCategory>(categoryViewModel);
        //     return category;

           
            
        // }

        [HttpPost]
        public async Task<IActionResult> Post(PostCategoryViewModel postCategoryViewModel)
        {
            await _postCategoryService.CreateEntity(postCategoryViewModel);
            
            return CreatedAtRoute("GetPostCategory", new {id = postCategoryViewModel.Id}, postCategoryViewModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PostCategoryViewModel postCategoryViewModel){
            try{
                await _postCategoryService.UpdateEntity(id, postCategoryViewModel);
                return NoContent();
            }
            catch(EntityNotFoundException<PostCategory>)
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try{
                await _postCategoryService.DeleteEntity(id);
                return NoContent();
            }
            catch(EntityNotFoundException<PostCategory>)
            {
                return NotFound();
            }
        }
    }
}