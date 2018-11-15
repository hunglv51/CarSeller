using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;
using Car4U.Application.Services;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Car4U.Application.ViewModels;
using AutoMapper;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {

        private NotificationViewModelService _notificationService;
        private PageViewModel _pageInfo = new PageViewModel(10);

        private readonly CarSellerContext _db;
        public NotificationsController(CarSellerContext context, IMapper mapper)
        {
            var repository = new NotificationRepository(context);
            var uow = new UnitOfWork(context);
            _notificationService = new NotificationViewModelService(uow, repository, mapper);    
        }
        [HttpGet]
        public async Task<IEnumerable<NotificationViewModel>> GetAll(int page = 1)
        {
            _pageInfo.PageIndex = page;
            return (await _notificationService.GetListEntities(_pageInfo));
        }

        // [HttpPost]
        // public async Task<IActionResult> Post(NotificationViewModel notificationViewModel)
        // {
            
        //     await _notificationService.CreateNotification(notificationViewModel);
        //     return CreatedAtRoute("GetNotification", new {id = notification.Id}, notification);
        // }
        [HttpGet("{id}", Name = "GetNotification")]
        public async Task<NotificationViewModel> GetById(Guid id)
        {
            var notification = await _notificationService.GetEntity(id);
            return notification;
        }
    }
}