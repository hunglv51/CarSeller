﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Car4U.ApplicationCore.Entities
{
    public class Post : BaseEntity<Guid>
    {
        private Post()
        {

        }

        public Post(Guid id, string title,string content, DateTime expiredDate)
        {
            Id = id;
            Title = title;
            Content = content;
            ExpiredDate = expiredDate;
            CreatedDate = ModifiedDate = DateTime.Now;
        }
        
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpiredDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public virtual Car Car { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
      
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("PostCategoryId")]
        public PostCategory Category { get; set; }
    }
}