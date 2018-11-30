using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Car4U.Domain.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            
        }
        public AppUser(string userName, string fullName, string email, string phoneNumber)
        {
            Id = Guid.NewGuid();
            
            Email = email;
            FullName = fullName;
            UserName = userName;
            PhoneNumber = phoneNumber;
            
        }

        
        public string FullName { get; set; }
        public bool IsSalon { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}