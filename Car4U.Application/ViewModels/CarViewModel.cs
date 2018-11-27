using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Car4U.Domain.Entities;

namespace Car4U.Application.ViewModels
{
    public class CarViewModel : BaseViewModel<long>
    {
        public int ManufactureYear { get; set; }

        [Range(0, 1000000)]
        public double Price { get; set; }
        public int DrivenDistance { get; set; }
        [StringLength(50)]
        public string Size { get; set; }
        public int? Weight { get; set; }
        public int? CylinderCapacity { get; set; }
        public int? FuelCapacity { get; set; }
        public int? TireInfo { get; set; }
        public int? WheelBase { get; set; }
        public int? MaxSeatingCapacity { get; set; }
        public int? NumDoor { get; set; }
        public ICollection<CarImageViewModel> Images { get; set; }
        public string CarFamily { get; set; }
    }
}