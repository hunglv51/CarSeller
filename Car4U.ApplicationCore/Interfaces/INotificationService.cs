
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Interfaces{
    public interface INotificationService
    {
        Task<ICollection<Notification>> GetNewestNotificaitonAsync(Guid userId, int? pageMargin);
        Task<Notification> GetNotificationAsync(Guid id);
        Task MarkNotificationAsync(Guid id);
        Task UnmarkNotificaitonAsync(Guid id);
        Task DeleteNotification(Guid id);
    }
}