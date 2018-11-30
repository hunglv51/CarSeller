using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Car4U.Domain.Entities;
using Car4U.Domain.Enums;
namespace Car4U.Application.ViewModels
{
    public class PostViewModel  : BaseViewModel<Guid>
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpiredDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public CarViewModel Car { get; set; }
        public ICollection<NotificationViewModel> Notifications { get; set; }
        public string CarFamily { get; set; }
        public string City { set; get; }
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
        public string Category { get; set; }
        public string Phone { get; set; }
        public CarTypes CarType {get;set;}
        public TransmissionTypes Tranmission { get; set; }
        public bool IsImported{ get; set; }
        public bool  IsUsed { get; set; }
        public DriveTypes DriveType { get; set; }


    }
}