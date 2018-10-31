﻿using CarSeller.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car4U.ApplicationCore.Entities
{
    public class PostCategory : BaseEntity<int>
    {
        private PostCategory() { }
        public PostCategory(string brandName, CarTypes carType, string carFamily, bool isImported, bool isUsed, DriveTypes driveType, TransmissionTypes transmissionType)
        {
            BrandName = brandName;
            CarType = carType;
            CarFamily = carFamily;
            IsImported = isImported;
            IsUsed = isUsed;
            DriveType = driveType;
            Transmission = transmissionType;
        }

        [StringLength(50)]
        public string BrandName { get; set; }
        public CarTypes CarType { get; set; }
        [StringLength(50)]
        public string CarFamily { get; set; }
        public bool IsImported { get; set; }
        public bool IsUsed { get; set; }
        public DriveTypes DriveType { get; set; }
        public TransmissionTypes Transmission { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
