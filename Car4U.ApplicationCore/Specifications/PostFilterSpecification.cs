using System;
using Car4U.ApplicationCore.Entities;

namespace Car4U.ApplicationCore.Specifications
{
    public class PostFilterSpecification : BaseSpecification<Post>
    {
        public PostFilterSpecification(Guid userId) : base(i => i.User.Id == userId)
        {

        }
    }
}