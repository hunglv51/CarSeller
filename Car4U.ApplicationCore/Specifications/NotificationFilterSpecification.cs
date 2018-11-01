
using System;
using System.Linq.Expressions;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Specifications
{
    public class NotificationFilterSpecification : BaseSpecification<Notification>
    {
        public NotificationFilterSpecification(Guid userId) : base(i => i.User.Id == userId)
        {
        }
    }
}