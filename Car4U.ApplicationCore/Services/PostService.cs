using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Exceptions;
using Car4U.ApplicationCore.Interfaces;
using Car4U.ApplicationCore.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Car4U.ApplicationCore.Services{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUriComposer _uriComposer;
        private readonly IAppLogger<Post> _logger;
        private readonly IPostRepository _postRepository;
        public PostService(IUnitOfWork uow, IAppLogger<Post> logger, IPostRepository postRepository)
        {
            _unitOfWork = uow;
            _logger = logger;
            _postRepository  = postRepository;
        }
        public async Task<bool> IsExpiredPostAsync(Guid id)
        {
            var post = await GetPostAsync(id);
            return DateTime.Now.CompareTo(post.ExpiredDate) == 1;
        }

        public async Task CreatePostAsync(Post post)
        {
            _postRepository.Add(post);
            await _unitOfWork.CommitAsync();
            
        }

        public async Task DeletePostAsync(Guid id)
        {
            var post = await GetPostAsync(id);
            _postRepository.Delete(post);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Post>> GetNewestPostsAsync(Guid? userId, int pageMargin, int pageIndex)
        {
             IQueryable<Post> newestPosts;
            if(userId == null)
            {
                newestPosts = _postRepository.ListAll();
                _logger.LogInfo($"Get {pageMargin} newest Posts");
            }
            else
            {
                var postFilter = new PostFilterSpecification((Guid)userId);
                newestPosts = _postRepository.List(postFilter);
                _logger.LogInfo($"Get {pageMargin} newest Posts of userid {userId.ToString()}");
            }
            return (await newestPosts.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageMargin).Take(pageMargin).ToListAsync());
        }

        public async Task<Post> GetPostAsync(Guid id)
        {
            var post = await _postRepository.GetById(id);
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
            _postRepository.Update(post);
            await _unitOfWork.CommitAsync();

        }
    }
}