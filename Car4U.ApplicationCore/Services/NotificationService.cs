
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using System.Linq;
using Car4U.ApplicationCore.Specifications;
using Car4U.ApplicationCore.Exceptions;

namespace Car4U.ApplicationCore.Services{
    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUriComposer _uriComposer;
        private readonly IAppLogger<Notification> _logger;

        
        public NotificationService(IUnitOfWork unitOfWork, IUriComposer uriComposer, IAppLogger<Notification> logger)
        {
            _unitOfWork = unitOfWork;
            _uriComposer = uriComposer;
            _logger = logger;
        }
        public async Task DeleteNotification(Guid id)
        {
            var notification = await GetNotificationAsync(id);
            _unitOfWork.NotificationAsyncRepository.Delete(notification);
            await _unitOfWork.CommitAsync();
            _logger.LogInfo($"Notification with id {id.ToString()} has been deleted");
        }

        public async Task<IEnumerable<Notification>> GetNewestNotificationAsync(Guid? userId, int pageMargin)
        {
            IEnumerable<Notification> newestNotification;
            if(userId == null)
            {
                newestNotification = await _unitOfWork.NotificationAsyncRepository.ListAllAsync();
                _logger.LogInfo($"Get {pageMargin} newest notifications");
            }
            else
            {
                var notificationFilter = new NotificationFilterSpecification((Guid)userId);
                newestNotification = await _unitOfWork.NotificationAsyncRepository.ListAsync(notificationFilter);
                _logger.LogInfo($"Get {pageMargin} newest notifications of userid {userId.ToString()}");
            }
            return newestNotification.Take(pageMargin);
        }

      

        public async Task<Notification> GetNotificationAsync(Guid id)
        {
             var notification = await _unitOfWork.NotificationAsyncRepository.GetByIdAsync(id);
            if(notification == null)
            {
                _logger.LogError($"Notification with id {id.ToString()} does not exist");
                throw new NotificationNotFoundException(id);
            }
            return notification;
        }




        public async Task MarkNotificationAsync(Guid id)
        {
            var notification = await _unitOfWork.NotificationAsyncRepository.GetByIdAsync(id);
            notification.IsRead = true;
            _unitOfWork.NotificationAsyncRepository.Update(notification);
            await _unitOfWork.CommitAsync();
        }

        public async Task UnmarkNotificationAsync(Guid id)
        {
            var notification = await _unitOfWork.NotificationAsyncRepository.GetByIdAsync(id);
            notification.IsRead = false;
            _unitOfWork.NotificationAsyncRepository.Update(notification);
            await _unitOfWork.CommitAsync();
        }

       
    }
}