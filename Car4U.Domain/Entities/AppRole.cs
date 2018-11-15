using System;
using Microsoft.AspNetCore.Identity;

namespace Car4U.Domain.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public AppRole()
        {
            
        }

        public AppRole(string name, string description)
        {
            Description = description;
            Name = name;
            Id = Guid.NewGuid();
        }
        public string Description { get; set; }
    }
}