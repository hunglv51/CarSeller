
using System;

namespace Car4U.ApplicationCore.Exceptions
{
    public class NotificationNotFoundException : Exception
    {
        public NotificationNotFoundException(Guid notificationId) : base($"Notification with id {notificationId} didn't exist")
        {

        }

        public NotificationNotFoundException(string msg) : base(msg)
        {

        }
        public NotificationNotFoundException(string msg, Exception innerException)
        {

        }
    }
}