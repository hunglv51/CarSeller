using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Services;
using Car4U.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Car4U.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {

        private NotificationService _notificationService;
        private readonly CarSellerContext _db;
        public NotificationsController(CarSellerContext context)
        {
            
        }
        [HttpGet]
        public async Task<IEnumerable<Notification>> Get()
        {
            return (await _notificationService.GetNewestNotificationAsync(null));
        }
    }
}