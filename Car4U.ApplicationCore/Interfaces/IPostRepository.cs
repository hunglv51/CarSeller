using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IPostRepository :IRepository<Guid, Post>
    {
    }
}
