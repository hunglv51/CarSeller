using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IPostCategoryService
    {
        Task<IEnumerable<PostCategory>> GetListPostCategories(int pageMargin, int pageIndex);
        Task<PostCategory> GetPostCategory(int id);
        Task DeletePostCategory(int id);
        Task CreatePostCategory(PostCategory postCategory);  

        Task UpdatePostCategory(PostCategory postCategory);
    }
}