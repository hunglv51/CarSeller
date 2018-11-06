using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using Car4U.ApplicationCore.Services;
using Car4U.Infrastructure.Data;
using Car4U.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {

        private NotificationService _notificationService;


        private readonly CarSellerContext _db;
        public NotificationsController(CarSellerContext context, IAppLogger<NotificationService> logger)
        {
            var repository = new NotificationRepository(context);
            var uow = new UnitOfWork(context);
            _notificationService = new NotificationService(uow, logger, repository);    
        }
        [HttpGet]
        public async Task<IEnumerable<Notification>> GetAll()
        {
            return (await _notificationService.GetNewestNotificationAsync(null));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Notification notification)
        {
            notification.Id = Guid.NewGuid();
            await _notificationService.CreateNotification(notification);
            return CreatedAtRoute("GetNotification", new {id = notification.Id}, notification);
        }
        [HttpGet("{id}", Name = "GetNotification")]
        public async Task<Notification> GetById(Guid id)
        {
            var notification = await _notificationService.GetNotificationAsync(id);
            return notification;
        }
    }
}