using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Car4U.Domain.Entities;

namespace Car4U.Application.ViewModels
{
    public class UserViewModel  : BaseViewModel<Guid>
    {
        [RegularExpression(@"\w")]
        public string UserName { get; set; }
        public string FullName { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}