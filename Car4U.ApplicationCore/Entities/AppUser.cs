using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Car4U.ApplicationCore.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            
        }
        public AppUser(string userName,string address, string fullName, string email, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Address = address;
            Email = email;
            FullName = fullName;
            UserName = userName;
            PhoneNumber = phoneNumber;
            
        }

        public string Address { set; get; }
        public string FullName { get; set; }
        public bool IsSalon { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}