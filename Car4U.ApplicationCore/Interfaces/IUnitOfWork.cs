
using System;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        IAsyncRepository<Guid,Notification> NotificationAsyncRepository{get;}
        IAsyncRepository<Guid,Post> PostAsyncRepository{get;}
        // void Commit();
        Task CommitAsync();
        void Rollback();
    }
}