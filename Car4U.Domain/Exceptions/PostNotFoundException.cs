using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.Domain.Exceptions
{
    public class PostNotFoundException : EntityNotFoundException<Guid>
    {
        public PostNotFoundException(Guid postId) : base($"Post with id {postId} didn't exist")
        {

        }

        public PostNotFoundException(string msg) : base(msg)
        {

        }
        public PostNotFoundException(string msg, Exception innerException) : base(msg, innerException)
        {

        }
        
    }
}
