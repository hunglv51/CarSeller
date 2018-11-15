using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car4U.Domain.Entities;

namespace Car4U.Domain.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetNewestPostsAsync(Guid? userId, int pageMargin, int pageIndex);
        Task<Post> GetPostAsync(Guid id);
        Task DeletePostAsync(Guid id);
        Task<bool> IsExpiredPostAsync(Guid id);
        Task RenewPostAsync(Guid id,DateTime newExpiredDate);
        Task CreatePostAsync(Post post);
         
        
    }
}
