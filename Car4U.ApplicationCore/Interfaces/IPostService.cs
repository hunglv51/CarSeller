using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetNewestPostsAsync(Guid? userId, int pageMargin);
        Task<Post> GetPostAsync(Guid id);
        Task DeletePostAsync(Guid id);
        Task<bool> IsExpiredPostAsync(Guid id);
        Task RenewPostAsync(Guid id,DateTime newExpiredDate);
        Task<Post> CreatePostAsync(Post post);
         
        
    }
}
