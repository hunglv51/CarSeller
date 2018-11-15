using Car4U.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car4U.Domain.Entities
{
   public class Notification :BaseEntity<Guid>
    {
        private Notification()
        {

        }

        public Notification(string content)
        {
            Content = content;
            CreatedDate = ModifiedDate = DateTime.Now;
        }

        [StringLength(2000)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsRead { get; set; }
        public string Title { get; set; }
        public Post Post { get; set; }
        public AppUser User { get; set; }
    }
}
