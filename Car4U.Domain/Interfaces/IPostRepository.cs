using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car4U.Domain.Entities;

namespace Car4U.Domain.Interfaces
{
    public interface IPostRepository :IRepository<Guid, Post>
    {
    }
}
