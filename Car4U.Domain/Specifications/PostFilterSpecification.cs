using System;
using Car4U.Domain.Entities;

namespace Car4U.Domain.Specifications
{
    public class PostFilterSpecification : BaseSpecification<Post>
    {
        public PostFilterSpecification(string brandName) : base(i => i.Category.BrandName == brandName)
        {

        }
    }
}