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
                            .Select(x => _mapper.Map<PostCategoryViewModel>(x));
                            

            return await categories.ToListAsync();
        }
        
    }


}