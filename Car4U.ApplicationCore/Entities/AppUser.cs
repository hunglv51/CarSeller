using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Car4U.ApplicationCore.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Address { set; get; }
        public string FullName { get; set; }
        public bool IsSalon { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}