using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Car4U.Domain.Entities
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
        

        public AppUser User { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpiredDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public virtual Car Car { get; set; }
        [ForeignKey("PostId")]
        public virtual ICollection<Notification> Notifications { get; set; }
      
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
        [ForeignKey("PostCategoryId")]
        public PostCategory Category { get; set; }
    }
}
