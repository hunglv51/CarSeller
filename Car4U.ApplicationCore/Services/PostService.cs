using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Exceptions;
using Car4U.ApplicationCore.Interfaces;
using Car4U.ApplicationCore.Specifications;

namespace Car4U.ApplicationCore.Services{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUriComposer _uriComposer;
        private readonly IAppLogger<Post> _logger;
        public async Task<bool> IsExpiredPostAsync(Guid id)
        {
            var post = await GetPostAsync(id);
            return DateTime.Now.CompareTo(post.ExpiredDate) == 1;
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            return await _unitOfWork.PostAsyncRepository.AddAsync(post);
        }

        public async Task DeletePostAsync(Guid id)
        {
            var post = await GetPostAsync(id);
            await _unitOfWork.PostAsyncRepository.DeleteAsync(post);
        }

        public async Task<IEnumerable<Post>> GetNewestPostsAsync(Guid? userId, int pageMargin)
        {
             IEnumerable<Post> newestPosts;
            if(userId == null)
            {
                newestPosts = await _unitOfWork.PostAsyncRepository.ListAllAsync();
                _logger.LogInfo($"Get {pageMargin} newest Posts");
            }
            else
            {
                var postFilter = new PostFilterSpecification((Guid)userId);
                newestPosts = await _unitOfWork.PostAsyncRepository.ListAsync(postFilter);
                _logger.LogInfo($"Get {pageMargin} newest Posts of userid {userId.ToString()}");
            }
            return newestPosts.Take(pageMargin);
        }

        public async Task<Post> GetPostAsync(Guid id)
        {
            var post = await _unitOfWork.PostAsyncRepository.GetByIdAsync(id);
            if(post == null)
            {
                _logger.LogError($"Post id {id.ToString()} does not exist");
                throw new PostNotFoundException(id);
            }
            return post;
        }

        public async Task RenewPostAsync(Guid id, DateTime newExpiredDate)
        {
            var post = await GetPostAsync(id);
            post.ExpiredDate = newExpiredDate;
            await _unitOfWork.PostAsyncRepository.UpdateAsync(post);


        }
    }
}