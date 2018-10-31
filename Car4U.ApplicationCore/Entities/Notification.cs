using CarSeller.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car4U.ApplicationCore.Entities
{
   public class Notification :BaseEntity<Guid>
    {
        private Notification()
        {

        }

        public Notification(NotificationTypes notificationType, string content, bool forAdmin)
        {
            Type = notificationType;
            Content = content;
            ForAdmin = forAdmin;
            CreatedDate = ModifiedDate = DateTime.Now;
        }

        public NotificationTypes Type { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool ForAdmin { get; set; }
        public bool IsRead { get; set; }
    }
}
