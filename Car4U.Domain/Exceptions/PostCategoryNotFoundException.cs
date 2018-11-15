using System;

namespace Car4U.Domain.Exceptions
{
    public class PostCategoryNotFoundException : EntityNotFoundException<int>
    {
         public PostCategoryNotFoundException(int id) : base($"Category with id {id} didn't exist")
        {

        }

        public PostCategoryNotFoundException(string msg) : base(msg)
        {

        }
        public PostCategoryNotFoundException(string msg, Exception innerException) : base(msg, innerException)
        {

        }
    }
}