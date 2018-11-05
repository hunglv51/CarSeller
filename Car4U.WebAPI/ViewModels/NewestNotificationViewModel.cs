using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Car4U.ApplicationCore.Entities;

namespace Car4U.WebAPI.ViewModels
{
    public class NewestNotificationViewModel 
    {
        public IEnumerable<Notification> Notifications { get; set; }
    }
}