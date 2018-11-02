using System;
using System.Collections.Generic;
using System.Text;
using Car4U.ApplicationCore.Entities;
using Car4U.ApplicationCore.Interfaces;

namespace Car4U.Infrastructure.Data.Repositories
{
    public class NotificationRepository : BaseRepository<Guid, Notification>, INotificationRepository
    {
        public NotificationRepository(CarSellerContext context) : base(context)
        {
        }
    }
}
