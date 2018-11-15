using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;
using System;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        // private readonly IIdentityService _indentityService;
        // const int PageMargin = 10;
        // public UserController(CarSellerContext context, IAppLogger<IIdentityService> logger)
        // {
        //     var unitOfWork = new UnitOfWork(context);
        //     var userRepository = new UserRepository(context);
            
        // }

        // [HttpGet]
        // public async Task<IEnumerable<AppUser>> Get(int pageIndex = 1){
        //     return (await _indentityService.ListUser(PageMargin, pageIndex));
        // }

        // [HttpGet("{id}", Name="GetUser")]
        // public async Task<ActionResult<AppUser>> GetById(Guid id)
        // {
        //     return (await _indentityService.GetUserAsync(id));
        // }
        // [HttpPost]
        // public async Task<ActionResult<AppUser>> Post(AppUser user)
        // {
        //     await _indentityService.AddUser(user);
        //     return CreatedAtRoute("GetUser", new {id = user.Id}, user);
        // }

        // [HttpPut]
        // public async Task<ActionResult> Put(Guid id,AppUser user)
        // {
        //     await 
        // }
       
    }
}