using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Car4U.Application.Intefaces;
using Car4U.Application.Services;
using Car4U.Domain.Entities;
using Car4U.Domain.Exceptions;
using Car4U.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Car4U.Application.ViewModels
{
    public class PostCategoryViewModelService : ViewModelService<PostCategory, PostCategoryViewModel, int>, IPostCategoryViewModelService
    {
        public PostCategoryViewModelService(PostCategoryRepository postcategoryRepository, UnitOfWork uow, IMapper mapper) : base(uow, postcategoryRepository, mapper)
        {
            
        }

        public async Task<IEnumerable<PostCategoryViewModel>> GetCategories()
        {
            var listCategories = new List<PostCategoryViewModel>();
            var categories = _repository.ListAll()
                            // .Skip(pageInfo.PageSkip).Take(pageInfo.PageMargin)
                            // .Select(x => new PostCategoryViewModel{
                            //     BrandName = x.BrandName,
                            //     CarFamily = x.CarFamily,
                            //     CarType = x.CarType.ToString(),
                            //     DriveType = x.DriveType.ToString(),
                            //     Id = x.Id,
                            //     IsImported = x.IsImported,
                            //     IsUsed = x.IsUsed,
                            //     Transmission = x.Transmission.ToString(),
                            //     PostQuantity = x.Posts.Count
                            // });
                            .Select(x => new PostCategoryViewModel(_mapper.Map<PostCategoryViewModel>(x), x.Posts.Count));
            // return (await categories.ToListAsync());
            return categories;
        }
        private PostCategoryViewModel CustomMap(PostCategory postCategory)
        {
            var categoryViewModel = _mapper.Map<PostCategoryViewModel>(postCategory);
            if(postCategory.Posts != null)
                categoryViewModel.PostQuantity = postCategory.Posts.Count;
            return categoryViewModel;
                            
        }
    }


}