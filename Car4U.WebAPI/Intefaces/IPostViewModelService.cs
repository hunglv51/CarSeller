using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.WebAPI.ViewModels;

namespace Car4U.WebAPI.Intefaces
{
    public interface IPostViewModelService
    {
        Task<IEnumerable<PostViewModel>> NewestPost();
        Task<IEnumerable<PostViewModel>> GetByUser(UserViewModel user);
        Task<IEnumerable<PostViewModel>> GetByCategory(PostCategoryViewModel categoryViewModel);

        
    }
}