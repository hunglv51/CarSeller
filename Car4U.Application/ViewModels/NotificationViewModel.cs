using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Car4U.Domain.Entities;
using Car4U.Domain.Enums;

namespace Car4U.Application.ViewModels
{
    public class NotificationViewModel : BaseViewModel<Guid>
    {
        [StringLength(2000)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        
        public bool IsRead { get; set; }
        public string Title { get; set; }
        public string PostId { get; set; }
        public string UserId { get; set; }
    }
}