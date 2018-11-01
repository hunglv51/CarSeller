
using System;
using Car4U.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        IAsyncRepository<Guid,Notification> NotificationAsyncRepository{get;}
        IRepository<Guid, Notification> NotificationRepository{get;}
        IAsyncRepository<Guid,Post> PostAsyncRepository{get;}
        IRepository<Guid, Post> PostRepository{get;}
        void Commit();
        void Rollback();
    }
}