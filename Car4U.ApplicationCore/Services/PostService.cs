

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;

namespace Car4U.ApplicationCore.Services{
    public class PostService : IPostService
    {
        public Task CheckExpiredPostAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> CreatePostAsync(Guid id, Car car, ICollection<CarImage> images)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Post>> GetNewestPostsAsync(Guid userId, int? pageMargin)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task RenewPostAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}