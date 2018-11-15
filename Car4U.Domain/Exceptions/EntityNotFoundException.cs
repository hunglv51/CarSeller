using System;

namespace Car4U.Domain.Exceptions
{
    public class EntityNotFoundException<TKey> : Exception
    {
        public EntityNotFoundException(TKey entityId) : base($"Notification with id {entityId} didn't exist")
        {

        }

        public EntityNotFoundException(string msg) : base(msg)
        {

        }
        public EntityNotFoundException(string msg, Exception innerException)
        {

        }
    }
}