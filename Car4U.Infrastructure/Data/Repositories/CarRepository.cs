using System;
using System.Collections.Generic;
using System.Text;
using Car4U.Domain.Entities;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class CarRepository : BaseRepository<long,Car>
    {
        public CarRepository(CarSellerContext context) : base(context)
        {
            
        }
    }
}
