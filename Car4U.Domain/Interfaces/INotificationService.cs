
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.Domain.Entities;

namespace Car4U.Domain.Interfaces{
    public interface INotificationService
    {
        Task<IEnumerable<Notification>> GetNewestNotificationAsync(Guid? userId, int pageMargin, int pageIndex);
        Task<Notification> GetNotificationAsync(Guid id);
        Task MarkNotificationAsync(Guid id);
        Task UnmarkNotificationAsync(Guid id);
        Task DeleteNotification(Guid id);
    }
}