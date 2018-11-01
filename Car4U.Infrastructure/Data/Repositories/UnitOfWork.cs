using System;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork(CarSellerContext context)
        {
            _context = context;
        }

        private readonly CarSellerContext _context;
        
        public IAsyncRepository<Guid, Notification> NotificationAsyncRepository{get;}

        public IRepository<Guid, Notification> NotificationRepository => throw new NotImplementedException();

        public IAsyncRepository<Guid, Post> PostAsyncRepository => throw new NotImplementedException();

        public IRepository<Guid, Post> PostRepository => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}