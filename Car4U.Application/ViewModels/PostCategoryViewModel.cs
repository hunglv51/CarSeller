using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Car4U.Domain.Entities;

namespace Car4U.Application.ViewModels
{
    public class PostCategoryViewModel : BaseViewModel<int>
    {
        [StringLength(50)]
        public string BrandName { get; set; }
        public string CarType { get; set; }
        [StringLength(50)]
        public string CarFamily { get; set; }
        public bool IsImported { get; set; }
        public bool IsUsed { get; set; }
        public string DriveType { get; set; }
        public string Transmission { get; set; }
        public int PostQuantity { get; set; }
        public PostCategoryViewModel()
        {
            
        }

        // public PostCategoryViewModel( string brandName ,
        //  string carFamily, 
        //  bool isImported,
        //  bool isUsed 
        //  )
        // {
        //     BrandName = brandName;
        //     CarFamily = carFamily;
        //     IsImported = isImported;
        //     IsUsed = isUsed;
      
        // }

        public PostCategoryViewModel( string brandName ,
         string carType ,
         string carFamily, 
         bool isImported,
         bool isUsed ,
         string driveType ,
         string transmission )
        {
            BrandName = brandName;
            CarType = carType;
            CarFamily = carFamily;
            IsImported = isImported;
            IsUsed = isUsed;
            DriveType = driveType;
            Transmission = transmission;
        }

        public PostCategoryViewModel(PostCategoryViewModel categoryViewModel,int quantity) : this(categoryViewModel.BrandName, categoryViewModel.CarType, categoryViewModel.CarFamily, categoryViewModel.IsImported, categoryViewModel.IsUsed, categoryViewModel.DriveType, categoryViewModel.Transmission)
        {
            
            this.PostQuantity = quantity;
        }
    }
}