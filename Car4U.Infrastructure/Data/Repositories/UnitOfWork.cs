using System;
using System.Linq;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork(CarSellerContext context)
        {
            _context = context;
        }

        private readonly CarSellerContext _context;
        
  
     
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Rollback()
        {
            foreach(var entity in _context.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged))
            {
                switch(entity.State){
                    case EntityState.Added:
                        entity.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:    
                    case EntityState.Modified:
                        entity.Reload();
                    break;
                }
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}