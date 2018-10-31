using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.ApplicationCore.Exceptions
{
    public class PostNotFoundException : Exception
    {
        public PostNotFoundException(Guid postId) : base($"Post with id {postId} didn't exist")
        {

        }

        public PostNotFoundException(string msg) : base(msg)
        {

        }
        public PostNotFoundException(string msg, Exception innerException)
        {

        }
        
    }
}
