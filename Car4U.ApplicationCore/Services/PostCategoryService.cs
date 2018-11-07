using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Car4U.ApplicationCore.Services
{
    public class PostCategoryService : IPostCategoryService
    {
        private readonly IAppLogger<PostCategoryService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPostCategoryRepository _categoryRepository;

        public PostCategoryService(IUnitOfWork unitOfWork, IAppLogger<PostCategoryService> logger, IPostCategoryRepository categoryRepository)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }
        public async Task CreatePostCategory(PostCategory postCategory)
        {
            await _categoryRepository.Add(postCategory);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeletePostCategory(int id)
        {
            var category = await _categoryRepository.GetById(id);
            _categoryRepository.Delete(category);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<PostCategory>> GetListPostCategories(int pageMargin = 10, int pageIndex = 1)
        {
           return (await _categoryRepository.ListAll().OrderBy(x => x.BrandName).Skip((pageIndex - 1) * pageMargin).Take(pageMargin).ToListAsync());

        }

        public async Task<PostCategory> GetPostCategory(int id)
        {
            return (await _categoryRepository.GetById(id));
        }

        public async Task UpdatePostCategory(PostCategory postCategory)
        {
            _categoryRepository.Update(postCategory);
            await _unitOfWork.CommitAsync();

        }
    }
}