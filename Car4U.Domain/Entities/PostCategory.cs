using Car4U.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Car4U.Domain.Entities
{
    public class PostCategory : BaseEntity<int>
    {
        public PostCategory() { }
        public PostCategory(string brandName, CarTypes carType,bool isImported, bool isUsed, DriveTypes driveType, TransmissionTypes transmissionType)
        {
            BrandName = brandName;
            CarType = carType;
            IsImported = isImported;
            IsUsed = isUsed;
            DriveType = driveType;
            Transmission = transmissionType;
        }

        [StringLength(50)]
        public string BrandName { get; set; }
        public CarTypes CarType { get; set; }
        [StringLength(50)]
        public bool IsImported { get; set; }
        public bool IsUsed { get; set; }
        public DriveTypes DriveType { get; set; }
        public TransmissionTypes Transmission { get; set; }
        [DataType(DataType.Url)]
        public string LogoUrl { get; set; }
        [ForeignKey("PostCategoryId")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
