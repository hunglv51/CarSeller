using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Interfaces;
using Car4U.WebAPI.Intefaces;
using Car4U.WebAPI.ViewModels;

namespace Car4U.WebAPI.Services
{
    public class PostViewModelService : IPostViewModelService
    {

        private readonly IAppLogger<PostViewModelService> _logger;
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;
        public PostViewModelService(IUnitOfWork uow, IPostRepository postRepository, IAppLogger<PostViewModelService> logger)
        {
            _unitOfWork = uow;
            _postRepository = postRepository;
            _logger = logger;
        }
        public Task<IEnumerable<PostViewModel>> GetByCategory(PostCategoryViewModel categoryViewModel)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<PostViewModel>> GetByUser(UserViewModel user)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<PostViewModel>> NewestPost()
        {
            throw new System.NotImplementedException();
        }
    }
}