using System;
using System.Collections.Generic;
using System.Text;
using Car4U.Domain.Entities;
using Car4U.Domain.Interfaces;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class NotificationRepository : BaseRepository<Guid, Notification>, INotificationRepository
    {
        public NotificationRepository(CarSellerContext context) : base(context)
        {
        }
    }
}
