using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IPostService
    {
        Task<ICollection<Post>> GetNewestPostsAsync(Guid userId, int? pageMargin);
        Task<Post> GetPostAsync(Guid id);
        Task DeletePostAsync(Guid id);
        Task CheckExpiredPostAsync(Guid id);
        Task RenewPostAsync(Guid id);
        Task<Post> CreatePostAsync(Guid id, Car car, ICollection<CarImage> images);
         
        
    }
}
