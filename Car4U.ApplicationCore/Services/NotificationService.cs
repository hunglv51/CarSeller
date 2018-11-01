
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;
using System.Linq;
using Car4U.ApplicationCore.Specifications;

namespace Car4U.ApplicationCore.Services{
    public class NotificationService : INotificationService
    {
        private readonly IAsyncRepository<Guid, Notification> _notifificationReporsitory;
        private readonly IUriComposer _uriComposer;
        private readonly IAppLogger<Notification> _logger;

        public async Task DeleteNotification(Guid id)
        {
            var notification = await _notifificationReporsitory.GetByIdAsync(id);
            await _notifificationReporsitory.DeleteAsync(notification);
        }

        public async Task<IEnumerable<Notification>> GetNewestNotificaitonAsync(Guid? userId, int pageMargin)
        {
            IEnumerable<Notification> newestNotification;
            if(userId == null)
            {
                newestNotification = await _notifificationReporsitory.ListAllAsync();
                
            }
            else
            {
                var notificationFilter = new NotificationFilterSpecification((Guid)userId);
                newestNotification = await _notifificationReporsitory.ListAsync(notificationFilter);
            }
            return newestNotification.Take(pageMargin);
        }

        public Task<ICollection<Notification>> GetNewestNotificaitonAsync(Guid userId, int? pageMargin)
        {
            throw new NotImplementedException();
        }

        public async Task<Notification> GetNotificationAsync(Guid id)
        {
            return await _notifificationReporsitory.GetByIdAsync(id);
            
        }

        public Task MarkNotificationAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task MarkReadNotificationAsync(Guid id)
        {
            var notification = await _notifificationReporsitory.GetByIdAsync(id);
            notification.IsRead = true;
            await _notifificationReporsitory.UpdateAsync(notification);
        }

        public async Task MarkNotificaitonAsync(Guid id)
        {
            var notification = await _notifificationReporsitory.GetByIdAsync(id);
            notification.IsRead = true;
            await _notifificationReporsitory.UpdateAsync(notification);
        }

        public async Task UnmarkNotificaitonAsync(Guid id)
        {
            var notification = await _notifificationReporsitory.GetByIdAsync(id);
            notification.IsRead = false;
            await _notifificationReporsitory.UpdateAsync(notification);
        }
    }
}