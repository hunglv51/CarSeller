
using System;
using System.Threading.Tasks;
using Car4U.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car4U.Domain.Interfaces
{
    public interface IUnitOfWork
    {

        // void Commit();
        Task CommitAsync();
        void Rollback();
    }
}