
using System;

namespace Car4U.Domain.Exceptions
{
    public class NotificationNotFoundException : EntityNotFoundException<Guid>
    {
        public NotificationNotFoundException(Guid notificationId) : base($"Notification with id {notificationId} didn't exist")
        {

        }

        public NotificationNotFoundException(string msg) : base(msg)
        {

        }
        public NotificationNotFoundException(string msg, Exception innerException) : base(msg, innerException)
        {

        }
    }
}