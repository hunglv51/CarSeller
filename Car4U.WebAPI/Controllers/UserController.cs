using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IIdentityService _indentityService;
        const int PageMargin = 10;
        public UserController(CarSellerContext context, IAppLogger<IIdentityService> logger)
        {
            var unitOfWork = new UnitOfWork(context);
            var userRepository = new UserRepository(context);
            
        }

        [HttpGet]
        public async Task<IEnumerable<AppUser>> Get(int pageIndex = 1){
            return (await _indentityService.ListUser(PageMargin, pageIndex));
        }
    }
}