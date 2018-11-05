
using System;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {

        // void Commit();
        Task CommitAsync();
        void Rollback();
    }
}