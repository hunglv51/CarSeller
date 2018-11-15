
using System;
using System.Linq.Expressions;
using Car4U.Domain.Entities;

namespace Car4U.Domain.Specifications
{
    public class NotificationFilterSpecification : BaseSpecification<Notification>
    {
        public NotificationFilterSpecification(Guid userId) : base(i => i.User.Id == userId)
        {
        }
    }
}