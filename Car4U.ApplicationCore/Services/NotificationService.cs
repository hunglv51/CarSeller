
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using System.Linq;
using Car4U.ApplicationCore.Specifications;
using Car4U.ApplicationCore.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Car4U.ApplicationCore.Services{
    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUriComposer _uriComposer;
        private readonly IAppLogger<NotificationService> _logger;
        private readonly INotificationRepository _notificationRepository;
        
        public NotificationService(IUnitOfWork unitOfWork, IAppLogger<NotificationService> logger, INotificationRepository notificationRepository)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _notificationRepository = notificationRepository;
        }
        public async Task DeleteNotification(Guid id)
        {
            var notification = await GetNotificationAsync(id);
            _notificationRepository.Delete(notification);
            await _unitOfWork.CommitAsync();
            _logger.LogInfo($"Notification with id {id.ToString()} has been deleted");
        }

        public async Task<IEnumerable<Notification>> GetNewestNotificationAsync(Guid? userId, int pageMargin = 10, int pageIndex = 1)
        {
            IQueryable<Notification> newestNotification;
            if(userId == null)
            {
                newestNotification =  _notificationRepository.ListAll();
                _logger.LogInfo($"Get {pageMargin} newest notifications");
            }
            else
            {
                var notificationFilter = new NotificationFilterSpecification((Guid)userId);
                newestNotification =  _notificationRepository.List(notificationFilter);
                _logger.LogInfo($"Get {pageMargin} newest notifications of userid {userId.ToString()}");
            }
            return (await newestNotification.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageMargin).Take(pageMargin).ToListAsync());
        }

       

        public async Task<Notification> GetNotificationAsync(Guid id)
        {
             var notification = await _notificationRepository.GetById(id);
            if(notification == null)
            {
                _logger.LogError($"Notification with id {id.ToString()} does not exist");
                throw new NotificationNotFoundException(id);
            }
            return notification;
        }




        public async Task MarkNotificationAsync(Guid id)
        {
            var notification = await _notificationRepository.GetById(id);
            notification.IsRead = true;
            _notificationRepository.Update(notification);
            await _unitOfWork.CommitAsync();
        }

        public async Task UnmarkNotificationAsync(Guid id)
        {
            var notification = await _notificationRepository.GetById(id);
            notification.IsRead = false;
            _notificationRepository.Update(notification);
            await _unitOfWork.CommitAsync();
        }

        public async Task CreateNotification(Notification notification)
        {
            _notificationRepository.Add(notification);
            await _unitOfWork.CommitAsync();
            
        }
       
    }
}